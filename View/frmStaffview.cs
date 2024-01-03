using Microsoft.ReportingServices.Diagnostics.Internal;
using Microsoft.SqlServer.Management.Smo;
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
using System.Web.Security;
using System.Windows.Forms;
using static POS_SYSTEM.Class.CommonMethod;
using static POS_SYSTEM.Class.DataMethod;

namespace POS_SYSTEM.View
{
    public partial class frmStaffview : SampleView
    {
        int create = 0, update = 0, delete = 0, export = 0, import = 0;
        public frmStaffview()
        {
            InitializeComponent();
        }

        private void frmStaffview_Load(object sender, EventArgs e)
        {
            ConfigData(dataStaff);
            LoadData();
            Privilege();
            if (create == 0) { btnAddNew.Visible = false; }
            if (import == 0) { btnImport.Visible = false; }
        }


        private void Privilege()
        {
            string qry = @"SELECT [create], [update], [delete], [export], [import] FROM Privilege WHERE id_feature = 4 AND id_role = '" + ROLEID + "'";

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
            BlurBackground(new frmStaffAdd());
            LoadData();
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DataMethod.DeleteSelectedData(dataStaff, "Staff");
            LoadData();
        }

        public override void btnExport_Click(object sender, EventArgs e)
        {
            Exports(dataStaff, 4);
        }

        public override void btnImport_Click(object sender, EventArgs e)
        {
            BlurBackground(new frmStaffImport());
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
            lb.Items.Add(dgvStaffID);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvJoinDate);
            lb.Items.Add(dgvGender);
            lb.Items.Add(dgvRole);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvAddress);
            lb.Items.Add(dgvInformation);
            string qry = @"SELECT s.id, s.staff_id, s.name, 
               CONVERT(varchar(10), s.join_date, 103) AS join_date, 
               s.gender, r.name, s.phone, s.address, s.information
               FROM Staff s 
               JOIN Role r ON s.id_role = r.id 
               WHERE s.staff_id LIKE '%" + txtSearch.Text + "%' OR  s.name LIKE '%" + txtSearch.Text + "%' " +
               "OR CONVERT(varchar(10), s.join_date, 103) LIKE'%" + txtSearch.Text + "%' OR s.Address LIKE '%" + txtSearch.Text + "%'" +
               " ORDER BY s.id ASC";

            DataMethod.LoadData(qry, dataStaff, lb);

        }

        private void dataStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataStaff.CurrentRow.Cells["dgvID"].Value);
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataStaff.Columns[e.ColumnIndex].Name == "dgvEdit")
            {
                string idStaff = Convert.ToString(dataStaff.CurrentRow.Cells["dgvStaffID"].Value);
                string name = Convert.ToString(dataStaff.CurrentRow.Cells["dgvName"].Value);
                string  dateValue = Convert.ToString(dataStaff.CurrentRow.Cells["dgvJoinDate"].Value);
                DateTime joinDate;
                DateTime.TryParseExact(dateValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out joinDate);
                string gender = Convert.ToString(dataStaff.CurrentRow.Cells["dgvGender"].Value);
                string role = Convert.ToString(dataStaff.CurrentRow.Cells["dgvRole"].Value);
                string phone = Convert.ToString(dataStaff.CurrentRow.Cells["dgvPhone"].Value);
                string address = Convert.ToString(dataStaff.CurrentRow.Cells["dgvAddress"].Value);
                string information = Convert.ToString(dataStaff.CurrentRow.Cells["dgvInformation"].Value);

                frmStaffAdd staffAdd = new frmStaffAdd();
                staffAdd.LoadCB();
                staffAdd.comboRole.Text = role;
                staffAdd.id = id;
                staffAdd.txtStaffID.Text = idStaff;
                if (gender == "M") { staffAdd.radioMale.Checked = true; } else { staffAdd.radioFemale.Checked = true; }
                staffAdd.txtName.Text = name;
                staffAdd.dateJoin.Value = joinDate;
                staffAdd.txtPhone.Text = phone.Trim();
                staffAdd.txtAddress.Text = address;
                staffAdd.txtInformation.Text = information;
                if (update == 0)
                {
                    MessageBox.Show("You do not have privilege to edit this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if (id == 1)
                {
                    MessageBox.Show("Data master can not be edited", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                BlurBackground(staffAdd);
                LoadData();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataStaff.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                if (delete == 0)
                {
                    MessageBox.Show("You do not have privilege to delete this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }

                if (id == 1)
                {
                    MessageBox.Show("Data master can not be deleted", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataMethod.DeleteColumn(dataStaff, "Staff");
                LoadData();
            }
        }

        private void dataStaff_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataStaff.Columns["dgvCheck"].Index)
            {
                for (int i = 1; i < dataStaff.Rows.Count; i++)
                {
                    DataGridViewRow row = dataStaff.Rows[i];
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["dgvCheck"] as DataGridViewCheckBoxCell;

                    if (checkBoxCell != null)
                    {
                        checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);
                    }
                }
            }
        }

        private void dataStaff_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool rowChecked = CheckCheckedRow(dataStaff);

            btnExport.Visible = rowChecked && export == 1;
            btnDelete.Visible = rowChecked && delete == 1;
        }

        private void dataStaff_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataStaff.Rows.Count > 0)
            {
                foreach (DataGridViewCell cell in dataStaff.Rows[0].Cells)
                {
                    cell.ReadOnly = true;
                }
            }
        }
    }
}
