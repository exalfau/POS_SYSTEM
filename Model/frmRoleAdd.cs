using POS_SYSTEM.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static POS_SYSTEM.Class.DataMethod;
using static POS_SYSTEM.Class.ValidationMethod;
using static POS_SYSTEM.Class.CommonMethod;
using System.Security.Cryptography;

namespace POS_SYSTEM.Model
{
    public partial class frmRoleAdd : SampleAdd
    {
        public int id = 0, view = 0, create = 0, update = 0, delete = 0, export = 0, import = 0;
        public frmRoleAdd()
        {
            InitializeComponent();
        }

        private void frmRoleAdd_Load(object sender, EventArgs e)
        {

            pictLogo.Image = Properties.Resources.id_card_color;
            if (id == 0)
            {
                LoadData();
                lblHeader.Text = "Create Role details";
                lblClock.Text = "Created at " + timer.ToString("HH:mm");
            }
            if (id > 0)
            {
                lblHeader.Text = "Update Role details";
                lblClock.Text = "Updated at " + timer.ToString("HH:mm");
                LoadPrivilege();
            }
            dataPrivilege.Columns["dgvFeature"].ReadOnly = true;
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation(this,id) == false)
            {
                return;
            }
            else
            {
                string qry1 = "";
                string qry2 = "";
                int record = 0;

                if (id == 0)
                {
                     qry1 = @"INSERT INTO Role (name, code, information) VALUES (@name, @code, @information)
                           SELECT SCOPE_IDENTITY()";
                }
                else
                {
                    qry1 = @"UPDATE Role SET name = @name , code = @code, information = @information, date_updated = @date_updated WHERE id = @id";
                }

                SqlCommand cmd1 = new SqlCommand(qry1, connection);
                cmd1.Parameters.AddWithValue("@id", id);
                cmd1.Parameters.AddWithValue("@name", txtName.Text);
                cmd1.Parameters.AddWithValue("@code", txtCode.Text);
                cmd1.Parameters.AddWithValue("@information", txtInformation.Text);
                cmd1.Parameters.AddWithValue("@date_updated", timer);

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                if (id == 0)
                {
                    id = Convert.ToInt32(cmd1.ExecuteScalar());
                }
                else
                {
                    cmd1.ExecuteNonQuery();
                }

                foreach (DataGridViewRow row in dataPrivilege.Rows)
                {
                    int pId = Convert.ToInt32(row.Cells["dgvID"].Value);

                    if (pId == 0)
                    {
                        qry2 = @"INSERT INTO Privilege (id_role, id_feature, [view], [create], [update], [delete], [export], [import])
                               VALUES (@id_role, @id_feature, @view, @create, @update, @delete, @export, @import)";

                    }
                    else
                    {
                        qry2 = @"UPDATE Privilege SET id_role = @id_role, id_feature = @id_feature, [view] = @view,
                               [create] = @create, [update] = @update, [delete] = @delete, [export] = @export, [import] = @import, date_updated = @date_updated 
                               WHERE id = @id";
                    }


                    SqlCommand cmd2 = new SqlCommand(qry2, connection);
                    cmd2.Parameters.AddWithValue("@id_feature", row.Index + 1);
                    cmd2.Parameters.AddWithValue("@id_role", id);
                    cmd2.Parameters.AddWithValue("@view", Convert.ToInt32(row.Cells["dgvViewValue"].Value));
                    cmd2.Parameters.AddWithValue("@create", Convert.ToInt32(row.Cells["dgvCreateValue"].Value));
                    cmd2.Parameters.AddWithValue("@update", Convert.ToInt32(row.Cells["dgvUpdateValue"].Value));
                    cmd2.Parameters.AddWithValue("@delete", Convert.ToInt32(row.Cells["dgvDeleteValue"].Value));
                    cmd2.Parameters.AddWithValue("@export", Convert.ToInt32(row.Cells["dgvExportValue"].Value));
                    cmd2.Parameters.AddWithValue("@import", Convert.ToInt32(row.Cells["dgvImportValue"].Value));
                    cmd2.Parameters.AddWithValue("@date_updated", timer);
                    cmd2.Parameters.AddWithValue("@id", pId);
                    record += cmd2.ExecuteNonQuery();
                }

                if (record > 0)
                {
                    MessageBox.Show("Input Sucessfull", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void dataPrivilege_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                string columnName = dataPrivilege.Columns[e.ColumnIndex].Name;

                if (columnName.StartsWith("dgv"))
                {
                    string valueColumnName = columnName + "Value";
                    foreach (DataGridViewRow row in dataPrivilege.Rows)
                    {
                        DataGridViewCheckBoxCell cell = row.Cells[columnName] as DataGridViewCheckBoxCell;
                        if (cell != null)
                        {
                            int currentValue = Convert.ToInt32(row.Cells[valueColumnName].Value);
                            row.Cells[valueColumnName].Value = (currentValue == 1) ? 0 : 1;

                        }
                    }
                }
            }
        }

        private void dataPrivilege_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataPrivilege.Rows[e.RowIndex];

                DataGridViewCheckBoxCell dgvViewCell = row.Cells["dgvView"] as DataGridViewCheckBoxCell;
                DataGridViewCheckBoxCell dgvCreateCell = row.Cells["dgvCreate"] as DataGridViewCheckBoxCell;
                DataGridViewCheckBoxCell dgvUpdateCell = row.Cells["dgvUpdate"] as DataGridViewCheckBoxCell;
                DataGridViewCheckBoxCell dgvDeleteCell = row.Cells["dgvDelete"] as DataGridViewCheckBoxCell;
                DataGridViewCheckBoxCell dgvExportCell = row.Cells["dgvExport"] as DataGridViewCheckBoxCell;
                DataGridViewCheckBoxCell dgvImportCell = row.Cells["dgvImport"] as DataGridViewCheckBoxCell;

                if (dgvViewCell != null && dgvCreateCell != null && dgvUpdateCell != null &&
                    dgvDeleteCell != null && dgvExportCell != null && dgvImportCell != null)
                {
                    // Update dgvViewValue
                    if (e.ColumnIndex == dgvViewCell.ColumnIndex)
                    {
                        row.Cells["dgvViewValue"].Value = Convert.ToInt32(dgvViewCell.Value);
                    }

                    // Update dgvCreateValue
                    else if (e.ColumnIndex == dgvCreateCell.ColumnIndex)
                    {
                        row.Cells["dgvCreateValue"].Value = Convert.ToInt32(dgvCreateCell.Value);
                    }

                    // Update dgvUpdateValue
                    else if (e.ColumnIndex == dgvUpdateCell.ColumnIndex)
                    {
                        row.Cells["dgvUpdateValue"].Value = Convert.ToInt32(dgvUpdateCell.Value);
                    }

                    // Update dgvDeleteValue
                    else if (e.ColumnIndex == dgvDeleteCell.ColumnIndex)
                    {
                        row.Cells["dgvDeleteValue"].Value = Convert.ToInt32(dgvDeleteCell.Value);
                    }

                    // Update dgvExportValue
                    else if (e.ColumnIndex == dgvExportCell.ColumnIndex)
                    {
                        row.Cells["dgvExportValue"].Value = Convert.ToInt32(dgvExportCell.Value);
                    }

                    // Update dgvImportValue
                    else if (e.ColumnIndex == dgvImportCell.ColumnIndex)
                    {
                        row.Cells["dgvImportValue"].Value = Convert.ToInt32(dgvImportCell.Value);
                    }
                }
            }
        }

        public override void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtCode.Text = GetRole(txtName.Text);
        }

        private void dataPrivilege_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataPrivilege.Rows[e.RowIndex];

                DataGridViewCheckBoxColumn dgvView = dataPrivilege.Columns["dgvView"] as DataGridViewCheckBoxColumn;
                DataGridViewCheckBoxColumn dgvCreate = dataPrivilege.Columns["dgvCreate"] as DataGridViewCheckBoxColumn;
                DataGridViewCheckBoxColumn dgvUpdate = dataPrivilege.Columns["dgvUpdate"] as DataGridViewCheckBoxColumn;
                DataGridViewCheckBoxColumn dgvDelete = dataPrivilege.Columns["dgvDelete"] as DataGridViewCheckBoxColumn;
                DataGridViewCheckBoxColumn dgvExport = dataPrivilege.Columns["dgvExport"] as DataGridViewCheckBoxColumn;
                DataGridViewCheckBoxColumn dgvImport = dataPrivilege.Columns["dgvImport"] as DataGridViewCheckBoxColumn;

                if (dgvView != null && dgvCreate != null && dgvUpdate != null && dgvDelete != null && dgvExport != null && dgvImport != null)
                {
                    // Check dgvView
                    if (e.ColumnIndex == dgvView.Index)
                    {
                        e.Value = Convert.ToBoolean(row.Cells["dgvViewValue"].Value);
                    }

                    // Check dgvCreate
                    else if (e.ColumnIndex == dgvCreate.Index)
                    {
                        e.Value = Convert.ToBoolean(row.Cells["dgvCreateValue"].Value);
                    }

                    // Check dgvUpdate
                    else if (e.ColumnIndex == dgvUpdate.Index)
                    {
                        e.Value = Convert.ToBoolean(row.Cells["dgvUpdateValue"].Value);
                    }

                    // Check dgvDelete
                    else if (e.ColumnIndex == dgvDelete.Index)
                    {
                        e.Value = Convert.ToBoolean(row.Cells["dgvDeleteValue"].Value);
                    }

                    // Check dgvExport
                    else if (e.ColumnIndex == dgvExport.Index)
                    {
                        e.Value = Convert.ToBoolean(row.Cells["dgvExportValue"].Value);
                    }

                    // Check dgvImport
                    else if (e.ColumnIndex == dgvImport.Index)
                    {
                        e.Value = Convert.ToBoolean(row.Cells["dgvImportValue"].Value);
                    }
                }
            }

        }

        private void LoadPrivilege()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvFeature);
            lb.Items.Add(dgvViewValue);
            lb.Items.Add(dgvCreateValue);
            lb.Items.Add(dgvUpdateValue);
            lb.Items.Add(dgvDeleteValue);
            lb.Items.Add(dgvExportValue);
            lb.Items.Add(dgvImportValue);

            string qry = "SELECT  p.id,  f.item, p.[view], p.[create], p.[update], p.[delete], p.[export], p.[import] " +
                         "FROM Privilege p " +
                         "JOIN Feature f ON p.id_feature = f.id WHERE p.id_role = '" + id + "'";

            DataMethod.LoadData(qry, dataPrivilege, lb);
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvFeature);

            string qry = @"SELECT item FROM Feature";

            DataMethod.LoadData(qry, dataPrivilege, lb);
        }

    }
}
