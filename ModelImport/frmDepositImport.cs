using ExcelDataReader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POS_SYSTEM.Class.DataMethod;

namespace POS_SYSTEM.ModelImport
{
    public partial class frmDepositImport : SampleAdd
    {
        DataTableCollection tableCollection;
        public frmDepositImport()
        {
            InitializeComponent();
        }

        private void frmDepositImport_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.deposit_color;
            lblHeader.Text = "Import Deposit Details";
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
                string customer = dataImport.Rows[i].Cells[0].Value?.ToString();
                object date = dataImport.Rows[i].Cells[1].Value;
                string amount = dataImport.Rows[i].Cells[2].Value?.ToString();
                string info = dataImport.Rows[i].Cells[3].Value?.ToString();

                string customerQry = @"SELECT id FROM Customer WHERE name = '" + customer + "'";
                int customerId = Convert.ToInt32(SQLScalar(customerQry));

                if (string.IsNullOrWhiteSpace(customer))
                {
                    MessageBox.Show("Column Customer cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (customerId == 0)
                {
                    MessageBox.Show(customer + " is not found in the database", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (date == null || string.IsNullOrWhiteSpace(date.ToString()))
                {
                    MessageBox.Show("Column Date cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                string dateFormat = "d/MM/yyyy";
                DateTime parsedJoinDate;
                string dateStrJoin = date is DateTime ? ((DateTime)date).ToShortDateString() : date.ToString();
                if (!DateTime.TryParseExact(dateStrJoin, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedJoinDate))
                {
                    MessageBox.Show($"Invalid Date format. Please use the format = dd/MM/yyyy.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (!int.TryParse(amount, out int amountValue))
                {
                    MessageBox.Show("Column Amount has invalid format.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (amountValue <= 0)
                {
                    MessageBox.Show("Column Amount cannot be empty or zero.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string customer = dataImport.Rows[i].Cells[0].Value?.ToString();
                string date = dataImport.Rows[i].Cells[1].Value?.ToString();
                string amount = dataImport.Rows[i].Cells[2].Value?.ToString();
                string info = dataImport.Rows[i].Cells[3].Value?.ToString();
                date = date.Split(' ')[0];

                DateTime parsedDate = DateTime.ParseExact(date, "d/MM/yyyy", CultureInfo.InvariantCulture);

                string qry = @"INSERT INTO Customer_Deposit ( id_customer, date, amount, type, information) 
                            VALUES ( (SELECT id FROM Customer WHERE name = @customer ), @date, @amount, @type, @information)";

                Hashtable ht = new Hashtable();
                ht.Add("@customer", customer);
                ht.Add("@date", parsedDate);
                ht.Add("@amount", Convert.ToDecimal(amount));
                ht.Add("@type", "deposit");
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
