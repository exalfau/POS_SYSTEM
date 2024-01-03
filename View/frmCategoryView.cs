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
using static POS_SYSTEM.Class.CommonMethod;
using static POS_SYSTEM.Class.DataMethod;

namespace POS_SYSTEM.View
{
    public partial class frmCategoryView : SampleView
    {
        int create = 0, update = 0, delete = 0, export = 0, import = 0;
        public frmCategoryView()
        {
            InitializeComponent();
        }

        private void frmCategoryView_Load(object sender, EventArgs e)
        {
            ConfigData(dataCategory);
            LoadData();
            Privilege();
            if(create == 0) { btnAddNew.Visible = false; }
            if (import == 0) { btnImport.Visible = false; }
        }

        private void Privilege()
        {
            string qry = @"SELECT [create], [update], [delete], [export], [import] FROM Privilege WHERE id_feature = 9 AND id_role = '" + ROLEID + "'";

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
            BlurBackground(new frmCategoryAdd());
            LoadData();
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedData(dataCategory, "Category");
            LoadData();
        }

        public override void btnExport_Click(object sender, EventArgs e)
        {
            Exports(dataCategory,4);
        }

        public override void btnImport_Click(object sender, EventArgs e)
        {
            BlurBackground(new frmCategoryImport());
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

            string qry = @"SELECT id, name, category_code, information FROM Category WHERE  name LIKE'%" + txtSearch.Text + "%' OR category_code LIKE'%" + txtSearch.Text + "%'" +
                "ORDER BY id asc";

           DataMethod.LoadData(qry, dataCategory, lb);
        }

        private void dataCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataCategory.Columns[e.ColumnIndex].Name == "dgvEdit")
            {
                int id = Convert.ToInt32(dataCategory.CurrentRow.Cells["dgvID"].Value);
                string name = Convert.ToString(dataCategory.CurrentRow.Cells["dgvName"].Value);
                string CC = Convert.ToString(dataCategory.CurrentRow.Cells["dgvCode"].Value);
                string info = Convert.ToString(dataCategory.CurrentRow.Cells["dgvInformation"].Value);

                frmCategoryAdd CategoryAdd = new frmCategoryAdd();
                CategoryAdd.id = id;
                CategoryAdd.txtName.Text = name;
                CategoryAdd.txtCode.Text = CC;
                CategoryAdd.txtInformation.Text = info;
                if (update == 0)
                {
                    MessageBox.Show("You do not have privilege to edit this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                BlurBackground(CategoryAdd);
                LoadData();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataCategory.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                if (delete == 0)
                {
                    MessageBox.Show("You do not have privilege to delete this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                DeleteColumn(dataCategory, "Category");
                LoadData();
            }
        }

        private void dataCategory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataCategory.Columns["dgvCheck"].Index)
            {
                foreach (DataGridViewRow row in dataCategory.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["dgvCheck"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {
                        checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);
                    }
                }
            }
        }

        private void dataCategory_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool rowChecked = CheckCheckedRow(dataCategory);
            btnExport.Visible = rowChecked && export == 1;
            btnDelete.Visible = rowChecked && delete == 1;
        }
    }
}
