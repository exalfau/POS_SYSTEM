using Microsoft.ReportingServices.Diagnostics.Internal;
using POS_SYSTEM.Class;
using POS_SYSTEM.Model;
using POS_SYSTEM.ModelImport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static POS_SYSTEM.Class.CommonMethod;
using static POS_SYSTEM.Class.DataMethod;

namespace POS_SYSTEM.View
{
    public partial class frmSupplierView : SampleView
    {
        int create = 0, update = 0, delete = 0, export = 0, import = 0;
        public frmSupplierView()
        {
            InitializeComponent();
        }

        private void frmSupplierView_Load(object sender, EventArgs e)
        {
            ConfigData(dataSupplier);
            LoadData();
            Privilege();
            if (create == 0) { btnAddNew.Visible = false; }
            if (import == 0) { btnImport.Visible = false; }
        }


        private void Privilege()
        {
            string qry = @"SELECT [create], [update], [delete], [export], [import] FROM Privilege WHERE id_feature = 17 AND id_role = '" + ROLEID + "'";

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
            BlurBackground(new frmSupplierAdd());
            LoadData();
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DataMethod.DeleteSelectedData(dataSupplier, "Supplier");
            LoadData();
        }

        public override void btnExport_Click(object sender, EventArgs e)
        {
            Exports(dataSupplier, 5);
        }

        public override void btnImport_Click(object sender, EventArgs e)
        {
            BlurBackground(new frmSupplierImport());
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
            lb.Items.Add(dgvSupplierID);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvJoinDate);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvAddress);
            lb.Items.Add(dgvInformation);
            string qry = @"SELECT id, supplier_id, name, CONVERT(NVARCHAR(10), join_date, 103) AS join_date, phone, address, information
                            FROM Supplier WHERE supplier_id LIKE '%" + txtSearch.Text + "%'OR " +
                            "name LIKE'%" + txtSearch.Text + "%' OR CONVERT(NVARCHAR(10), join_date, 103) LIKE'%" + txtSearch.Text + "%' OR Address LIKE'%" + txtSearch.Text + "%'ORDER BY id desc";

            DataMethod.LoadData(qry, dataSupplier, lb);
        }

        private void dataSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = Convert.ToString(dataSupplier.CurrentRow.Cells["dgvName"].Value);

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataSupplier.Columns[e.ColumnIndex].Name == "dgvEdit")
            {
                int id = Convert.ToInt32(dataSupplier.CurrentRow.Cells["dgvID"].Value);
                string idSupplier = Convert.ToString(dataSupplier.CurrentRow.Cells["dgvSupplierID"].Value);
                string  dateValue = Convert.ToString(dataSupplier.CurrentRow.Cells["dgvJoinDate"].Value);
                DateTime joinDate;
                DateTime.TryParseExact(dateValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out joinDate);
                string phone = Convert.ToString(dataSupplier.CurrentRow.Cells["dgvPhone"].Value);
                string address = Convert.ToString(dataSupplier.CurrentRow.Cells["dgvAddress"].Value);
                string information = Convert.ToString(dataSupplier.CurrentRow.Cells["dgvInformation"].Value);

                frmSupplierAdd SupplierAdd = new frmSupplierAdd();
                SupplierAdd.id = id;
                SupplierAdd.txtSupplierID.Text = idSupplier;
                SupplierAdd.txtName.Text = name;
                SupplierAdd.dateJoin.Value = joinDate;
                SupplierAdd.txtPhone.Text = phone.Trim();
                SupplierAdd.txtAddress.Text = address;
                SupplierAdd.txtInformation.Text = information;
                if (update == 0)
                {
                    MessageBox.Show("You do not have privilege to edit this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                BlurBackground(SupplierAdd);
                LoadData();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataSupplier.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                if (delete == 0)
                {
                    MessageBox.Show("You do not have privilege to delete this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                DataMethod.DeleteColumn(dataSupplier, "Supplier");
                LoadData();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataSupplier.Columns[e.ColumnIndex].Name == "dgvMore")
            {
                frmSupplierDetailView supplierDetailView = new frmSupplierDetailView();
                supplierDetailView.name = name;
                BlurBackground(supplierDetailView);
            }
        }

        private void dataSupplier_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataSupplier.Columns["dgvCheck"].Index)
            {
                foreach (DataGridViewRow row in dataSupplier.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["dgvCheck"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {
                        checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);
                    }
                }
            }
        }

        private void dataSupplier_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool rowChecked = CheckCheckedRow(dataSupplier);

            btnExport.Visible = rowChecked && export == 1;
            btnDelete.Visible = rowChecked && delete == 1;
        }

    }
}
