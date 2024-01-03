using ExcelDataReader;
using System.Data.SqlClient;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
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
using DataSet = System.Data.DataSet;

namespace POS_SYSTEM.ModelImport
{
    public partial class frmStockOutImport : SampleAdd
    {

        DataTableCollection tableCollection;
        Byte[] imageByteArray;
        int record;

        public frmStockOutImport()
        {
            InitializeComponent();
        }

        private void frmStockOutImport_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.return_box_color;
            lblHeader.Text = "Import Stock Out Details";
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
                object dateOut = dataImport.Rows[i].Cells[1].Value;
                object timeOut = dataImport.Rows[i].Cells[2].Value;
                string productName = dataImport.Rows[i].Cells[3].Value?.ToString();
                string qty = dataImport.Rows[i].Cells[4].Value?.ToString();
                string coli = dataImport.Rows[i].Cells[5].Value?.ToString();
                string cause = dataImport.Rows[i].Cells[6].Value?.ToString();

                if (dateOut == null || string.IsNullOrWhiteSpace(dateOut.ToString()))
                {
                    MessageBox.Show("Column Date Out cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                string dateFormat = "d/MM/yyyy";
                DateTime parsedDate;
                string dateStr = dateOut is DateTime ? ((DateTime)dateOut).ToShortDateString() : dateOut.ToString();
                if (!DateTime.TryParseExact(dateStr, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                {
                    MessageBox.Show($"Invalid Date Out format. Please use the format = dd/MM/yyyy.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (timeOut == null || string.IsNullOrWhiteSpace(timeOut.ToString()))
                {
                    MessageBox.Show("Column Time cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                string timeFormat = "HH:mm";
                DateTime parsedTime;
                string timeStr = timeOut is DateTime ? ((DateTime)timeOut).ToString(timeFormat) : timeOut.ToString();
                if (!DateTime.TryParseExact(timeStr, timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedTime))
                {
                    MessageBox.Show($"Invalid Time format. Please use the format = HH:mm.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(supplierName + " is not found in the database", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                string productQry = @"SELECT id FROM Product WHERE name = '" + productName + "'";
                int productId = Convert.ToInt32(SQLScalar(productQry));

                if (string.IsNullOrWhiteSpace(productName))
                {
                    MessageBox.Show("Column Product cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (productId == 0)
                {
                    MessageBox.Show(productName + " is not found in the database", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                string pairQry = @"SELECT id FROM Product WHERE name = '" + productName + "' AND id_supplier = (SELECT id FROM Supplier WHERE name = '" + supplierName + "' )";
                int pairID = Convert.ToInt32(SQLScalar(pairQry));

                if (pairID == 0)
                {
                    MessageBox.Show(supplierName + " does not have product " + productName, "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (!int.TryParse(qty, out int qtyOne))
                {
                    MessageBox.Show(qty + " Quantity Out has invalid format.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (qtyOne <= 0)
                {
                    MessageBox.Show( productName + "Quantity Out cannot be empty or zero.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (!int.TryParse(coli, out int coliOne))
                {
                    MessageBox.Show(productName + " Coli Out has invalid format.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }


                if (coliOne < 0)
                {
                    MessageBox.Show(productName + "Coli Out cannot be bellow zero.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string supplierName = dataImport.Rows[i].Cells[0].Value?.ToString();
                string dateInput = dataImport.Rows[i].Cells[1].Value?.ToString();
                string timeInput = dataImport.Rows[i].Cells[2].Value?.ToString();
                string productName = dataImport.Rows[i].Cells[3].Value?.ToString();
                string qty = dataImport.Rows[i].Cells[4].Value?.ToString();
                string coli = dataImport.Rows[i].Cells[5].Value?.ToString();
                string cause = dataImport.Rows[i].Cells[6].Value?.ToString();
                string info = dataImport.Rows[i].Cells[7].Value?.ToString();
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
                cmd1.Parameters.AddWithValue("@type", "stock_out");
                cmd1.Parameters.AddWithValue("@confirm", 0);
                cmd1.Parameters.AddWithValue("@information", info);
                int Tid = Convert.ToInt32(cmd1.ExecuteScalar());
                if (connection.State == ConnectionState.Open) { connection.Close(); }

                string qry2 = @"INSERT INTO Stock_Out (id_transaction, id_supplier, id_product, quantity, coli, price, total_price, cause)
                                    VALUES (@id_transaction, (SELECT id FROM Supplier WHERE name = @supplierName), (SELECT id FROM Product WHERE name = @productName),
                                    @quantity, @coli, (SELECT nett_price FROM Product WHERE name = @productName), ((SELECT nett_price FROM Product WHERE name = @productName) * @Quantity), @cause)";

                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                SqlCommand cmd2 = new SqlCommand(qry2, connection);
                cmd2.Parameters.AddWithValue("@id_transaction", Tid);
                cmd2.Parameters.AddWithValue("@productName", productName);
                cmd2.Parameters.AddWithValue("@supplierName", supplierName);
                cmd2.Parameters.AddWithValue("@Quantity", qty);
                cmd2.Parameters.AddWithValue("@Coli", coli);
                cmd2.Parameters.AddWithValue("@Cause", cause);
                record += cmd2.ExecuteNonQuery();
                if (connection.State == ConnectionState.Open) { connection.Close(); }

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
