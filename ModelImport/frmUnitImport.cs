using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;
using ExcelDataReader;
using System.IO;
using Aspose.Words.Tables;
using Microsoft.SqlServer.Management.Smo;
using static POS_SYSTEM.Class.ValidationMethod;
using static POS_SYSTEM.Class.DataMethod;


namespace POS_SYSTEM.ModelImport
{
    public partial class frmUnitImport : SampleAdd
    {
        DataTableCollection tableCollection;
        public int id = 0;
        int result;
        bool status;
        public frmUnitImport()
        {
            InitializeComponent();
        }

        private void frmUnitImport_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.delivery_box_color;
            lblHeader.Text = "Import Unit Details";
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
                string code = dataImport.Rows[i].Cells[1].Value?.ToString();

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Column Name cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (string.IsNullOrWhiteSpace(code))
                {
                    MessageBox.Show("Column Code cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

            }


            if (validationFailed)
            {
                return;
            }

            for (int i = 0; i < dataImport.Rows.Count; i++)
            {
                string name = dataImport.Rows[i].Cells[0].Value?.ToString();
                string code = dataImport.Rows[i].Cells[1].Value?.ToString();
                string info = dataImport.Rows[i].Cells[2].Value?.ToString();
                string qry = @"INSERT INTO Unit (name, unit_code, information) VALUES (@name, @unit_code, @information)";
                Hashtable ht = new Hashtable();

                ht.Add("@name", name);
                ht.Add("@unit_code", code);
                ht.Add("@information", info);

                int result = SQL(qry, ht);

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

