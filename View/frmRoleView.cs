using Microsoft.Office.Interop.Excel;
using POS_SYSTEM.Class;
using POS_SYSTEM.Model;
using POS_SYSTEM.ModelImport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListBox = System.Windows.Forms.ListBox;
using static POS_SYSTEM.Class.CommonMethod;
using static POS_SYSTEM.Class.DataMethod;
using DataTable = System.Data.DataTable;

namespace POS_SYSTEM.View
{
    public partial class frmRoleView : SampleView
    {
        int create = 0, update = 0, delete = 0, export = 0, import = 0;
        public frmRoleView()
        {
            InitializeComponent();
        }

        private void frmRoleView_Load(object sender, EventArgs e)
        {
            ConfigData(dataRole);
            LoadData();
            Privilege();
            if (create == 0) { btnAddNew.Visible = false; }
            if (import == 0) { btnImport.Visible = false; }
        }

        private void Privilege()
        {
            string qry = @"SELECT [create], [update], [delete], [export], [import] FROM Privilege WHERE id_feature = 3 AND id_role = '" + ROLEID + "'";

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
            BlurBackground(new frmRoleAdd());
            LoadData();
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedData(dataRole, "Role");
            LoadData();
        }

        public override void btnExport_Click(object sender, EventArgs e)
        {
            Exports(dataRole, 4);
        }

        public override void btnImport_Click(object sender, EventArgs e)
        {
            BlurBackground(new frmRoleImport());
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
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvCode);
            lb.Items.Add(dgvInformation);
            string qry = @"SELECT id, name, code, information FROM Role WHERE name 
                        LIKE '%" + txtSearch.Text + "%'OR code LIKE'%" + txtSearch.Text + "%' ORDER BY id asc";
            DataMethod.LoadData(qry, dataRole, lb);
        }

        private void dataRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataRole.CurrentRow.Cells["dgvID"].Value);
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataRole.Columns[e.ColumnIndex].Name == "dgvEdit")
            {
                frmRoleAdd roleAdd = new frmRoleAdd();
                roleAdd.id = id;
                roleAdd.txtName.Text= Convert.ToString(dataRole.CurrentRow.Cells["dgvName"].Value);
                roleAdd.txtInformation.Text = Convert.ToString(dataRole.CurrentRow.Cells["dgvInformation"].Value);
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
                    BlurBackground(roleAdd);
                LoadData();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataRole.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                if (delete == 0)
                {
                    MessageBox.Show("You do not have privilege to delete this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if (id == 1)
                {
                    MessageBox.Show("Data master can not be edited", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DeleteColumn( dataRole, "Role");
                LoadData();
            }
        }

        private void dataRole_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataRole.Columns["dgvCheck"].Index)
            {
                for (int i = 1; i < dataRole.Rows.Count; i++)
                {
                    DataGridViewRow row = dataRole.Rows[i];
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["dgvCheck"] as DataGridViewCheckBoxCell;

                    if (checkBoxCell != null)
                    {
                        checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);
                    }
                }
            }
        }

        private void dataRole_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool rowChecked = CheckCheckedRow(dataRole);

            btnExport.Visible = rowChecked && export == 1;
            btnDelete.Visible = rowChecked && delete == 1;
        }

        private void dataRole_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataRole.Rows.Count > 0)
            {
                foreach (DataGridViewCell cell in dataRole.Rows[0].Cells)
                {
                    cell.ReadOnly = true;
                }
            }
        }
    }
}
