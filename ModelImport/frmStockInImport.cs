using ExcelDataReader;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static POS_SYSTEM.Class.DataMethod;
using ExcelDataReader;
using DataSet = System.Data.DataSet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Data.SqlTypes;
using static System.Windows.Forms.AxHost;
using Microsoft.SqlServer.Management.Smo;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
using Image = System.Drawing.Image;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace POS_SYSTEM.ModelImport
{
    public partial class frmStockInImport : SampleAdd
    {
        DataTableCollection tableCollection;
        Byte[] imageByteArray;
        int record;
        int qtyValue, coliValue;
        decimal nettPriceValue, totalValue; 
        public frmStockInImport()
        {
            InitializeComponent();
        }

        private void frmStockInImport_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.packaging_color;
            lblHeader.Text = "Import Stock In Details";
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            bool validationFailed = false;

            for (int i = 0; i < dataImport.Rows.Count; i++)
            {
                if (dataImport.RowCount == 0)
                {
                    MessageBox.Show("Table cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                }

                string supplierName = dataImport.Rows[i].Cells[0].Value?.ToString();
                object cellDateValue = dataImport.Rows[i].Cells[1].Value;
                object cellTimeValue = dataImport.Rows[i].Cells[2].Value;
                string productName = dataImport.Rows[i].Cells[3].Value?.ToString();
                string qty = dataImport.Rows[i].Cells[4].Value?.ToString();
                string coli = dataImport.Rows[i].Cells[5].Value?.ToString();

                if (cellDateValue == null || string.IsNullOrWhiteSpace(cellDateValue.ToString()))
                {
                    MessageBox.Show("Column Date In cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                string dateFormat = "d/MM/yyyy";
                DateTime parsedDate;
                string dateStr = cellDateValue is DateTime ? ((DateTime)cellDateValue).ToShortDateString() : cellDateValue.ToString();
                if (!DateTime.TryParseExact(dateStr, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                {
                    MessageBox.Show($"Invalid Date In format. Please use the format = dd/MM/yyyy.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (cellTimeValue == null || string.IsNullOrWhiteSpace(cellTimeValue.ToString()))
                {
                    MessageBox.Show("Column Time In cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                string timeFormat = "HH:mm";
                DateTime parsedTime;
                string timeStr = cellTimeValue is DateTime ? ((DateTime)cellTimeValue).ToString(timeFormat) : cellTimeValue.ToString();
                if (!DateTime.TryParseExact(timeStr, timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedTime))
                {
                    MessageBox.Show($"Invalid Time In format. Please use the format = HH:mm.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                }

                string supplierQry = @"SELECT id FROM Supplier WHERE name = '" + supplierName + "'";
                int supplierId = Convert.ToInt32(SQLScalar(supplierQry));

                 if (string.IsNullOrWhiteSpace(supplierName))
                 {
                     MessageBox.Show("Column Supplier cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     validationFailed = true;
                     break;
                 }

                if (supplierId == 0)
                {
                    MessageBox.Show(supplierName +" is not found in the database", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                string[] productNames = productName.Split(',');
                string[] qtyValues = qty.Split(',');
                string[] coliValues = coli.Split(',');

                if (productNames.Length != qtyValues.Length || productNames.Length != coliValues.Length || qtyValues.Length != coliValues.Length)
                {
                    MessageBox.Show("Product names, quantity, and coli values must have the same number of elements.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                for (int a = 0; a < productNames.Length; a++)
                {
                    string product = productNames[a].Trim();
                    string qtyValue = qtyValues[a].Trim();
                    string coliValue = coliValues[a].Trim();

                    string productQry = @"SELECT id FROM Product WHERE name = '" + product + "'";
                    int productId = Convert.ToInt32(SQLScalar(productQry));

                    if (string.IsNullOrWhiteSpace(product))
                    {
                        MessageBox.Show("Column Product cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validationFailed = true;
                        break;
                    }

                    if (productId == 0)
                    {
                        MessageBox.Show(product + " is not found in the database", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validationFailed = true;
                        break;
                    }

                    string pairQry = @"SELECT id FROM Product WHERE name = '" + product + "' AND id_supplier = (SELECT id FROM Supplier WHERE name = '" + supplierName + "' )";
                    int pairID = Convert.ToInt32(SQLScalar(pairQry));

                    if (pairID == 0 )
                    {
                        MessageBox.Show(supplierName + " does not have product "+ product, "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validationFailed = true;
                        break;
                    }

                    if (!int.TryParse(qtyValue, out int qtyOne))
                    {
                        MessageBox.Show(product + " Quantity In has invalid format.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validationFailed = true;
                        break;
                    }

                    if (qtyOne <= 0)
                    {
                        MessageBox.Show(product + "Quantity In cannot be empty or zero.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validationFailed = true;
                        break;
                    }

                    if (!int.TryParse(coliValue, out int coliOne))
                    {
                        MessageBox.Show(product + " Coli In has invalid format.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validationFailed = true;
                        break;
                    }

                    if (coliOne <= 0)
                    {
                        MessageBox.Show(product + "Coli In cannot be empty or zero.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validationFailed = true;
                        break;
                    }
                }
            }

            if (validationFailed)
             {
                 return;
             }

            for (int i = 0; i < dataImport.Rows.Count; i++)
            {
                string supplierName = dataImport.Rows[i].Cells[0].Value?.ToString();
                string dateInput = dataImport.Rows[i].Cells[1].Value?.ToString();
                string timeInput = dataImport.Rows[i].Cells[2].Value?.ToString();
                string productName  = dataImport.Rows[i].Cells[3].Value?.ToString();
                string qty = dataImport.Rows[i].Cells[4].Value?.ToString();
                string coli = dataImport.Rows[i].Cells[5].Value?.ToString();
                string info = dataImport.Rows[i].Cells[6].Value?.ToString();
                dateInput = dateInput.Split(' ')[0];
                timeInput = timeInput.Split(' ')[1];
                dateInput = dateInput.Trim();
                timeInput = timeInput.Trim();


                DateTime date = DateTime.ParseExact(dateInput, "d/MM/yyyy", CultureInfo.InvariantCulture);

                string[] productNames = productName.Split(',');
                string[] qtyValues = qty.Split(',');
                string[] coliValues = coli.Split(',');

                string qry1 = @"INSERT INTO [Transaction] (date, time, image, type, confirm, information)
                           VALUES (@date, @time, @image, @type, @confirm, @information)
                           SELECT SCOPE_IDENTITY()";

                Image temp = new Bitmap(Properties.Resources.packaging_color);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();

                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                SqlCommand cmd1 = new SqlCommand(qry1, connection);
                cmd1.Parameters.AddWithValue("@date", date);
                cmd1.Parameters.AddWithValue("@time", Convert.ToDateTime(timeInput));
                cmd1.Parameters.AddWithValue("@image", imageByteArray);
                cmd1.Parameters.AddWithValue("@type", "stock_in");
                cmd1.Parameters.AddWithValue("@confirm", 0);
                cmd1.Parameters.AddWithValue("@information", info);
                int Tid = Convert.ToInt32(cmd1.ExecuteScalar());
                if (connection.State == ConnectionState.Open) { connection.Close(); }

                for (int a = 0; a < productNames.Length; a++)
                {
                    string product = productNames[a].Trim();
                    int quantity = int.Parse(qtyValues[a].Trim());
                    int coliValue = int.Parse(coliValues[a].Trim());

                    string qry2 = @"INSERT INTO Stock_In (id_transaction, id_product, id_supplier, quantity, coli, price, total_price)
                                   VALUES (@TransactionId, 
                                   (SELECT id FROM Product WHERE name = @productName), 
                                   (SELECT id FROM Supplier WHERE name = @supplierName), 
                                   @Quantity, 
                                   @Coli, 
                                   (SELECT nett_price FROM Product WHERE name = @productName), 
                                   ((SELECT nett_price FROM Product WHERE name = @productName) * @Quantity))";

                    if (connection.State == ConnectionState.Closed) { connection.Open(); }
                    SqlCommand cmd2 = new SqlCommand(qry2, connection);
                    cmd2.Parameters.AddWithValue("@TransactionId", Tid);
                    cmd2.Parameters.AddWithValue("@productName", product);
                    cmd2.Parameters.AddWithValue("@supplierName", supplierName);
                    cmd2.Parameters.AddWithValue("@Quantity", quantity);
                    cmd2.Parameters.AddWithValue("@Coli", coliValue);
                    record += cmd2.ExecuteNonQuery();
                    if (connection.State == ConnectionState.Open) { connection.Close(); }

                }


            }

            if (record > 0)
            {
                MessageBox.Show("Input Successful", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dataImport.Columns["date"].DefaultCellStyle.Format = "MM/dd/yyyy";
                dataImport.Columns["time"].DefaultCellStyle.Format = "HH:mm";

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
