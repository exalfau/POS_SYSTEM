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
    public partial class frmCourierView : SampleView
    {
        int create = 0, update = 0, delete = 0, export = 0, import = 0;
        public frmCourierView()
        {
            InitializeComponent();
        }

        private void frmCourierView_Load(object sender, EventArgs e)
        {
            ConfigData(dataCourier);
            LoadData();
            Privilege();
            if (create == 0) { btnAddNew.Visible = false; }
            if (import == 0) { btnImport.Visible = false; }
        }
        private void Privilege()
        {
            string qry = @"SELECT [create], [update], [delete], [export], [import] FROM Privilege WHERE id_feature = 6 AND id_role = '" + ROLEID + "'";

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
            BlurBackground(new frmCourierAdd());
            LoadData();
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedData(dataCourier, "Courier");
            LoadData();
        }

        public override void btnExport_Click(object sender, EventArgs e)
        {
            Exports(dataCourier,5);
        }

        public override void btnImport_Click(object sender, EventArgs e)
        {
            BlurBackground(new frmCourierImport());
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
            lb.Items.Add(dgvLicensePlate);
            lb.Items.Add(dgvInformation);

            string qry = @"SELECT c.id, s.staff_id, s.name, c.license_plate, c.information
                            FROM Courier c JOIN Staff s ON c.id_staff = s.id WHERE s.staff_id LIKE '%" + txtSearch.Text + "%'OR s.name LIKE'%" + txtSearch.Text + "%'OR c.license_plate LIKE'%" + txtSearch.Text + "%'ORDER BY c.id desc";

            DataMethod.LoadData(qry, dataCourier, lb);
        }

        private void dataCourier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = Convert.ToString(dataCourier.CurrentRow.Cells["dgvName"].Value);
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataCourier.Columns[e.ColumnIndex].Name == "dgvEdit")
            {
                int id = Convert.ToInt32(dataCourier.CurrentRow.Cells["dgvID"].Value);
                string idStaff = Convert.ToString(dataCourier.CurrentRow.Cells["dgvStaffID"].Value);
                string licensePlate = Convert.ToString(dataCourier.CurrentRow.Cells["dgvLicensePlate"].Value);
                string information = Convert.ToString(dataCourier.CurrentRow.Cells["dgvInformation"].Value);

                frmCourierAdd courierAdd = new frmCourierAdd();
                courierAdd.LoadCB();
                courierAdd.comboStaffID.Text = idStaff;
                courierAdd.id = id;
                courierAdd.txtName.Text = name;
                courierAdd.txtLicensePlate.Text = licensePlate;
                courierAdd.txtInformation.Text = information;
                if (update == 0)
                {
                    MessageBox.Show("You do not have privilege to delete this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                BlurBackground(courierAdd);
                LoadData();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataCourier.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                if (delete == 0)
                {
                    MessageBox.Show("You do not have privilege to delete this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                DeleteColumn(dataCourier, "Courier");
                LoadData();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataCourier.Columns[e.ColumnIndex].Name == "dgvMore")
            {
                frmCourierDetailView courierDetail = new frmCourierDetailView();
                courierDetail.name = name;
                BlurBackground(courierDetail);
            }
        }

            private void dataCourier_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataCourier.Columns["dgvCheck"].Index)
            {
                foreach (DataGridViewRow row in dataCourier.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["dgvCheck"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {
                        checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);
                    }
                }
            }
        }

        private void dataCourier_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool rowChecked = CheckCheckedRow(dataCourier);

            btnExport.Visible = rowChecked && export == 1;
            btnDelete.Visible = rowChecked && delete == 1;
        }
    }
}
