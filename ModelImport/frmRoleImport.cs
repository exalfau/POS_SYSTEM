using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;
using static POS_SYSTEM.Class.DataMethod;
using static POS_SYSTEM.Class.CommonMethod;
using Aspose.Words.Tables;
using System.Security.Cryptography;
using ExcelDataReader;
using System.IO;
using DataSet = System.Data.DataSet;

namespace POS_SYSTEM.ModelImport
{
    public partial class frmRoleImport : SampleAdd
    {
        DataTableCollection tableCollection;
        public frmRoleImport()
        {
            InitializeComponent();
        }

        private void frmRoleImport_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.id_card_color;
            lblHeader.Text = "Import Role Details";
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            bool status = true;
            bool validationFailed = false;
            if (dataImport.RowCount == 0)
            {
                MessageBox.Show("Table cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validationFailed = true;
            }

            for (int i = 0; i < dataImport.Rows.Count; i++)
            {
                string name = dataImport.Rows[i].Cells[0].Value?.ToString();
                string info = dataImport.Rows[i].Cells[1].Value?.ToString();


                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Column Name cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }
            }

            if (validationFailed)
            {
                return;
            }

            int result = 0;
            for (int i = 0; i < dataImport.Rows.Count; i++)
            {
                string name = dataImport.Rows[i].Cells[0].Value?.ToString();
                string info = dataImport.Rows[i].Cells[1].Value?.ToString();

                string qry1 = @"INSERT INTO Role (name, code, information) VALUES (@name, @code, @information)
                           SELECT SCOPE_IDENTITY()";
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                SqlCommand cmd1 = new SqlCommand(qry1, connection);
                cmd1.Parameters.AddWithValue("@name", name.ToUpper());
                cmd1.Parameters.AddWithValue("@code", GetRole(name));
                cmd1.Parameters.AddWithValue("@information", info);
                int id = Convert.ToInt32(cmd1.ExecuteScalar());

                for (int j = 0; j < 20; j++)
                {
                    string qry2 = @"INSERT INTO Privilege (id_role, id_feature, [view], [create], [update], [delete], [export], [import])
                               VALUES (@id_role, @id_feature, @view, @create, @update, @delete, @export, @import)";

                    SqlCommand cmd2 = new SqlCommand(qry2, connection);
                    cmd2.Parameters.AddWithValue("@id_feature", j + 1);
                    cmd2.Parameters.AddWithValue("@id_role", id);
                    cmd2.Parameters.AddWithValue("@view", 0);
                    cmd2.Parameters.AddWithValue("@create", 0);
                    cmd2.Parameters.AddWithValue("@update", 0);
                    cmd2.Parameters.AddWithValue("@delete", 0);
                    cmd2.Parameters.AddWithValue("@export", 0);
                    cmd2.Parameters.AddWithValue("@import", 0);
                    result += cmd2.ExecuteNonQuery();
                }

                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                if (result <= 0)
                {
                    status = false;
                }
            }

            if (status)
            {
                MessageBox.Show("Input Successful", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Input Failed", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public override void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            comboSheet.Items.Clear();
            comboSheet.Text = "";
            dataImport.DataSource = null;
            bool fileInUseMessageShown = false;

            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "Excel Files|*.xls;*.xlsx;" })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = openFile.FileName;
                    try
                    {
                        using (var stream = File.Open(openFile.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollection = dataSet.Tables;
                                comboSheet.Items.Clear();
                                foreach (DataTable table in tableCollection)
                                    comboSheet.Items.Add(table.TableName);
                            }
                        }
                    }
                    catch (IOException ex)
                    {
                        if (!fileInUseMessageShown)
                        {
                            MessageBox.Show("File is being used by another process.", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtFileName.Text = "";
                            fileInUseMessageShown = true;
                        }
                    }
                }
            }
        }

        private void comboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = tableCollection[comboSheet.SelectedItem.ToString()];

            if (table != null)
            {
                dataImport.AutoGenerateColumns = false;

                List<string> excelColumnNames = table.Columns.Cast<DataColumn>().Select(col => col.ColumnName).ToList();

                List<string> missingColumns = new List<string>();
                List<string> extraColumns = new List<string>();

                foreach (DataGridViewColumn dgvCol in dataImport.Columns)
                {
                    DataColumn dataColumn = table.Columns
                        .Cast<DataColumn>()
                        .FirstOrDefault(col => col.ColumnName == dgvCol.HeaderText);

                    if (dataColumn != null)
                    {
                        dgvCol.DataPropertyName = dataColumn.ColumnName;
                        dgvCol.HeaderText = dataColumn.ColumnName;
                    }
                    else
                    {
                        missingColumns.Add(dgvCol.HeaderText);
                    }
                }

                if (missingColumns.Count > 0)
                {
                    string missingColumnsMessage = "Missing columns in the Table: " + string.Join(", ", missingColumns);
                    MessageBox.Show(missingColumnsMessage, "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboSheet.Items.Clear();
                    comboSheet.Text = "";
                    txtFileName.Text = "";
                    dataImport.DataSource = null;
                    return;
                }

                // Create a new DataTable with sorted columns
                DataTable sortedTable = new DataTable();

                foreach (string columnName in excelColumnNames)
                {
                    DataColumn dataColumn = table.Columns[columnName];
                    sortedTable.Columns.Add(dataColumn.ColumnName, dataColumn.DataType);
                }

                foreach (DataRow row in table.Rows)
                {
                    DataRow newRow = sortedTable.NewRow();

                    foreach (string columnName in excelColumnNames)
                    {
                        newRow[columnName] = row[columnName];
                    }

                    sortedTable.Rows.Add(newRow);
                }

                dataImport.DataSource = sortedTable;

                foreach (string excelColumnName in excelColumnNames)
                {
                    if (!dataImport.Columns.Cast<DataGridViewColumn>().Any(col => col.HeaderText == excelColumnName))
                    {
                        extraColumns.Add(excelColumnName);
                    }
                }

                if (extraColumns.Count > 0)
                {
                    string extraColumnsMessage = "Please delete all unnecessary columns in the Excel data: " + string.Join(", ", extraColumns);
                    MessageBox.Show(extraColumnsMessage, "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboSheet.Items.Clear();
                    comboSheet.Text = "";
                    txtFileName.Text = "";
                    dataImport.DataSource = null;
                    return;
                }
            }
        }
    }
}
