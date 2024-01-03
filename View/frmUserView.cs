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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POS_SYSTEM.Class.CommonMethod;
using static POS_SYSTEM.Class.DataMethod;

namespace POS_SYSTEM.View
{
    public partial class frmUserView : SampleView
    {
        int create = 0, update = 0, delete = 0, export = 0, import = 0;
        public frmUserView()
        {
            InitializeComponent();
        }

        private void frmUserView_Load(object sender, EventArgs e)
        {
            ConfigData(dataAccount);
            LoadData();
            Privilege();
            if (create == 0) { btnAddNew.Visible = false; }
            if (import == 0) { btnImport.Visible = false; }
        }

        private void Privilege()
        {
            string qry = @"SELECT [create], [update], [delete], [export], [import] FROM Privilege WHERE id_feature = 5 AND id_role = '" + ROLEID + "'";

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
            BlurBackground(new frmUserAdd());
            LoadData();
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedData(dataAccount, "Account");
            LoadData();
        }

        public override void btnExport_Click(object sender, EventArgs e)
        {
            Exports(dataAccount, 5);
        }

        public override void btnImport_Click(object sender, EventArgs e)
        {
            BlurBackground(new frmUserImport());
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
            lb.Items.Add(dgvInformation);

            string qry = @"SELECT a.id, s.staff_id, a.username, a.information
                    FROM Account a JOIN Staff s ON a.id_staff = s.id 
                    WHERE (s.staff_id LIKE '%" + txtSearch.Text + "%' OR a.username LIKE '%" + txtSearch.Text + "%') " +
                   " AND s.id <> " + ID + " ORDER BY a.id asc";

            DataMethod.LoadData(qry, dataAccount, lb);
        }

        private void dataAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = Convert.ToString(dataAccount.CurrentRow.Cells["dgvName"].Value);

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataAccount.Columns[e.ColumnIndex].Name == "dgvEdit")
            {
                int id = Convert.ToInt32(dataAccount.CurrentRow.Cells["dgvID"].Value);
                string idStaff = Convert.ToString(dataAccount.CurrentRow.Cells["dgvStaffID"].Value);
                string information = Convert.ToString(dataAccount.CurrentRow.Cells["dgvInformation"].Value);

                frmUserAdd userAdd = new frmUserAdd();
                userAdd.LoadCB();
                userAdd.id = id;
                userAdd.comboStaffID.Text = idStaff;
                userAdd.txtUsername.Text = name;
                userAdd.txtInformation.Text = information;
                if (update == 0)
                {
                    MessageBox.Show("You do not have privilege to delete this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                BlurBackground(userAdd);
                LoadData();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataAccount.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                if (delete == 0)
                {
                    MessageBox.Show("You do not have privilege to delete this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                DeleteColumn(dataAccount, "Account");
                LoadData();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataAccount.Columns[e.ColumnIndex].Name == "dgvMore")
            {
                frmUserDetailView userDetailView = new frmUserDetailView();
                userDetailView.name = name;
                BlurBackground(userDetailView);
            }
        }

        private void dataAccount_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataAccount.Columns["dgvCheck"].Index)
            {
                foreach (DataGridViewRow row in dataAccount.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["dgvCheck"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {
                        checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);
                    }
                }
            }
        }

        private void dataAccount_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool rowChecked = CheckCheckedRow(dataAccount);

            btnExport.Visible = rowChecked && export == 1;
            btnDelete.Visible = rowChecked && delete == 1;
        }
    }
}
