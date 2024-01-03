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
    public partial class frmUnitView : SampleView
    {
        int create = 0, update = 0, delete = 0, export = 0, import = 0;
        public frmUnitView()
        {
            InitializeComponent();
        }

        private void frmUnitView_Load(object sender, EventArgs e)
        {
            ConfigData(dataUnit);
            LoadData();
            Privilege();
            if (create == 0) { btnAddNew.Visible = false; }
            if (import == 0) { btnImport.Visible = false; }
        }

        private void Privilege()
        {
            string qry = @"SELECT [create], [update], [delete], [export], [import] FROM Privilege WHERE id_feature = 8 AND id_role = '" + ROLEID + "'";

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
            BlurBackground(new frmUnitAdd());
            LoadData();
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedData(dataUnit, "Unit");
            LoadData();
        }

        public override void btnExport_Click(object sender, EventArgs e)
        {
            Exports(dataUnit,4);
        }

        public override void btnImport_Click(object sender, EventArgs e)
        {
            BlurBackground(new frmUnitImport());
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

            string qry = @"SELECT id, name, unit_code, information FROM Unit WHERE id LIKE '%" + txtSearch.Text + "%'OR name LIKE'%" + txtSearch.Text + "%' OR unit_code LIKE'%" + txtSearch.Text + "%'" +
                "ORDER BY id asc";

            DataMethod.LoadData(qry, dataUnit, lb);
        }

        private void dataUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataUnit.Columns[e.ColumnIndex].Name == "dgvEdit")
            {
                int id = Convert.ToInt32(dataUnit.CurrentRow.Cells["dgvID"].Value);
                string name = Convert.ToString(dataUnit.CurrentRow.Cells["dgvName"].Value);
                string UC = Convert.ToString(dataUnit.CurrentRow.Cells["dgvCode"].Value);
                string info = Convert.ToString(dataUnit.CurrentRow.Cells["dgvInformation"].Value);

                frmUnitAdd UnitAdd = new frmUnitAdd();
                UnitAdd.id = id;
                UnitAdd.txtName.Text = name;
                UnitAdd.txtCode.Text = UC;
                UnitAdd.txtInformation.Text = info;
                if (update == 0)
                {
                    MessageBox.Show("You do not have privilege to delete this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                BlurBackground(UnitAdd);
                LoadData();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataUnit.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                if (delete == 0)
                {
                    MessageBox.Show("You do not have privilege to delete this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                DeleteColumn(dataUnit, "Unit");
                LoadData();
            }
        }

        private void dataUnit_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataUnit.Columns["dgvCheck"].Index)
            {
                foreach (DataGridViewRow row in dataUnit.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["dgvCheck"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {
                        checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);
                    }
                }
            }
        }

        private void dataUnit_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool rowChecked = CheckCheckedRow(dataUnit);

            btnExport.Visible = rowChecked && export == 1;
            btnDelete.Visible = rowChecked && delete == 1;
        }

    }
}
