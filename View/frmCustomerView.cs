using POS_SYSTEM.Class;
using POS_SYSTEM.Model;
using POS_SYSTEM.ModelImport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition.Primitives;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POS_SYSTEM.Class.CommonMethod;
using static POS_SYSTEM.Class.DataMethod;

namespace POS_SYSTEM.View
{
    public partial class frmCustomerView : SampleView
    {
        int create = 0, update = 0, delete = 0, export = 0, import = 0;
        public frmCustomerView()
        {
            InitializeComponent();
        }

        private void frmCustomerView_Load(object sender, EventArgs e)
        {
            ConfigData(dataCustomer);
            LoadData();
            Privilege();
            if (create == 0) { btnAddNew.Visible = false; }
            if (import == 0) { btnImport.Visible = false; }
        }


        private void Privilege()
        {
            string qry = @"SELECT [create], [update], [delete], [export], [import] FROM Privilege WHERE id_feature = 14 AND id_role = '" + ROLEID + "'";

            SqlCommand cmd = new SqlCommand(qry, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                create = Convert.ToInt32(dt.Rows[0]["create"]);
                update = Convert.ToInt32(dt.Rows[0]["update"]);
                delete = Convert.ToInt32(dt.Rows[0]["delete"]);
                export = Convert.ToInt32(dt.Rows[0]["export"]);
                import = Convert.ToInt32(dt.Rows[0]["import"]);
            }
        }

        public override void btnAddNew_Click(object sender, EventArgs e)
        {
            BlurBackground(new frmCustomerAdd());
            LoadData();
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedData(dataCustomer, "Customer");
            LoadData();
        }

        public override void btnExport_Click(object sender, EventArgs e)
        {
            Exports(dataCustomer, 5);
        }

        public override void btnImport_Click(object sender, EventArgs e)
        {
            BlurBackground(new frmCustomerImport());
            LoadData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvCustomerID);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvJoinDate);
            lb.Items.Add(dgvBirthDate);
            lb.Items.Add(dgvGender);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvAddress);
            lb.Items.Add(dgvInformation);
            string qry = @"SELECT id, customer_id, name, CONVERT(varchar(10), join_date, 103) AS join_date, CONVERT(varchar(10), birth_date, 103) AS birth_date, gender, phone, address, information
                            FROM Customer WHERE customer_id LIKE '%" + txtSearch.Text + "%'OR " +
                            "name LIKE'%" + txtSearch.Text + "%' OR join_date LIKE'%" + txtSearch.Text + "%' OR Address LIKE'%" + txtSearch.Text + "%'ORDER BY id desc";

            DataMethod.LoadData(qry, dataCustomer, lb);
        }

        private void dataCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = Convert.ToString(dataCustomer.CurrentRow.Cells["dgvName"].Value);

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataCustomer.Columns[e.ColumnIndex].Name == "dgvEdit")
            {
                int id = Convert.ToInt32(dataCustomer.CurrentRow.Cells["dgvID"].Value);
                string idCustomer = Convert.ToString(dataCustomer.CurrentRow.Cells["dgvCustomerID"].Value);
                string joinDateValue = Convert.ToString(dataCustomer.CurrentRow.Cells["dgvJoinDate"].Value);
                DateTime joinDate;
                DateTime.TryParseExact(joinDateValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out joinDate);
                string birthDateValue = Convert.ToString(dataCustomer.CurrentRow.Cells["dgvBirthDate"].Value);
                DateTime birthDate;
                DateTime.TryParseExact(birthDateValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate);
                string gender = Convert.ToString(dataCustomer.CurrentRow.Cells["dgvGender"].Value);
                string phone = Convert.ToString(dataCustomer.CurrentRow.Cells["dgvPhone"].Value);
                string address = Convert.ToString(dataCustomer.CurrentRow.Cells["dgvAddress"].Value);
                string information = Convert.ToString(dataCustomer.CurrentRow.Cells["dgvInformation"].Value);

                frmCustomerAdd customerAdd = new frmCustomerAdd();
                customerAdd.id = id;
                customerAdd.txtCustomerID.Text = idCustomer;
                if (gender == "M") { customerAdd.radioMale.Checked = true; } else { customerAdd.radioFemale.Checked = true; }
                customerAdd.txtName.Text = name;
                customerAdd.dateJoin.Value = joinDate;
                customerAdd.dateBirth.Value = birthDate;
                customerAdd.txtPhone.Text = phone.Trim();
                customerAdd.txtAddress.Text = address;
                customerAdd.txtInformation.Text = information;
                if (update == 0)
                {
                    MessageBox.Show("You do not have privilege to update this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                BlurBackground(customerAdd);
                LoadData();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataCustomer.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                if (delete == 0)
                {
                    MessageBox.Show("You do not have privilege to delete this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                DataMethod.DeleteColumn(dataCustomer, "Customer");
                LoadData();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataCustomer.Columns[e.ColumnIndex].Name == "dgvMore")
            {
                frmCustomerDetailView customerDetail = new frmCustomerDetailView();
                customerDetail.name = name;
                BlurBackground(customerDetail);
            }
        }

        private void dataCustomer_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataCustomer.Columns["dgvCheck"].Index)
            {
                foreach (DataGridViewRow row in dataCustomer.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["dgvCheck"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {
                        checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);
                    }
                }
            }
        }

        private void dataCustomer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool rowChecked = CheckCheckedRow(dataCustomer);
            btnExport.Visible = rowChecked && export == 1;
            btnDelete.Visible = rowChecked && delete == 1;
        }
    }
}
