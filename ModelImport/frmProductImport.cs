using ExcelDataReader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static POS_SYSTEM.Class.DataMethod;

namespace POS_SYSTEM.ModelImport
{
    public partial class frmProductImport : SampleAdd
    {
        DataTableCollection tableCollection;
        string productCode, productName, unitName, categoryName, supplierName, qty, coli,
            nettPrice, margin, tax, discount, sellPrice, info;
        int unitId, categoryId, supplierId;
        decimal nettPriceValue, marginValue, taxValue, discountValue, sellPriceValue, qtyValue, coliValue;
        Byte[] imageByteArray;
        public frmProductImport()
        {
            InitializeComponent();
        }

        private void frmProductImport_Load(object sender, EventArgs e)
        {
        }

        private string ValidateRow(int rowIndex)
        {

            productCode = dataImport.Rows[rowIndex].Cells[0].Value?.ToString();
            productName = dataImport.Rows[rowIndex].Cells[1].Value?.ToString();
            unitName = dataImport.Rows[rowIndex].Cells[2].Value?.ToString();
            categoryName = dataImport.Rows[rowIndex].Cells[3].Value?.ToString();
            supplierName = dataImport.Rows[rowIndex].Cells[4].Value?.ToString();
            nettPrice = dataImport.Rows[rowIndex].Cells[5].Value?.ToString();
            margin = dataImport.Rows[rowIndex].Cells[6].Value?.ToString();
            tax = dataImport.Rows[rowIndex].Cells[7].Value?.ToString();
            discount = dataImport.Rows[rowIndex].Cells[8].Value?.ToString();
            info = dataImport.Rows[rowIndex].Cells[9].Value?.ToString();

            string unitQry = @"SELECT id FROM Unit WHERE unit_code = '" + unitName + "'";
            unitId = Convert.ToInt32(SQLScalar(unitQry));

            string categoryQry = @"SELECT id FROM Category WHERE name = '" + categoryName + "'";
            categoryId = Convert.ToInt32(SQLScalar(categoryQry));

            string supplierQry = @"SELECT id FROM Supplier WHERE name = '" + supplierName + "'";
            supplierId = Convert.ToInt32(SQLScalar(supplierQry));

            if (string.IsNullOrWhiteSpace(productCode))
            {
                return "Column Code cannot be empty.";
            }

            if (string.IsNullOrWhiteSpace(productName))
            {
                return "Column Name cannot be empty.";
            }

            if (string.IsNullOrWhiteSpace(unitName))
            {
                return "Column Unit cannot be empty.";
            }

            if (unitId == 0)
            {
                return productName + " Unit is not found in the database";
            }

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                return "Column Category cannot be empty.";
            }

            if (categoryId == 0)
            {
                return productName + " Category is not found in the database";
            }

            if (string.IsNullOrWhiteSpace(supplierName))
            {
                return "Column Supplier cannot be empty.";
            }

            if (supplierId == 0)
            {
                return productName + " Supplier is not found in the database";
            }

            if (decimal.TryParse(qty, out qtyValue) && decimal.TryParse(coli, out coliValue))
            {
                if (qtyValue != 0 || coliValue != 0)
                {
                    // Show validation message only if qty or coli are not both 0
                    if (qtyValue != 0)
                    {
                        return "Column Qty cannot be imported manually. Empty out all values.";
                    }
                    else
                    {
                        return "Column Coli cannot be imported manually. Empty out all values.";
                    }
                }
            }

            if (!decimal.TryParse(nettPrice, out nettPriceValue))
            {
                return productName + " Nett Price has an invalid format.";
            }

            if (nettPriceValue <= 0)
            {
               return "Column Nett Price cannot be empty or zero.";
            }

            if (!decimal.TryParse(margin, out marginValue))
            {
               return productName +" Margin has an invalid format.";  
            }

            if (!decimal.TryParse(tax, out taxValue))
            {
                return productName + " Tax has an invalid format.";  
            }

            if (!decimal.TryParse(discount, out discountValue))
            {
                return productName + " Discount Price has an invalid format.";
            }

            if (decimal.TryParse(sellPrice, out sellPriceValue))
            {
                if (sellPriceValue != 0)
                {
                    return "Column Sell Price cannot be inserted manually. Empty out all values."; 
                }
            }

            sellPriceValue = ((nettPriceValue * (100 + marginValue) / 100) * (100 + taxValue) / 100) * (100 - discountValue) / 100;

            if (sellPriceValue < 0)
            {
                return productName + " Sell price will be less than 0.";       }

            if (sellPriceValue < nettPriceValue)
            {
                return productName + " Sell price will be less than its Nett Price.";
            }
            return null; // If all checks pass, the row is considered valid
        }


        public override void btnSave_Click(object sender, EventArgs e)
        {
            bool status = true;

            for (int i = 0; i < dataImport.Rows.Count; i++)
            {
                string validationMessage = ValidateRow(i);

                if (validationMessage != null)
                {
                    if (validationMessage.Contains("Sell price will be less than its Nett Price"))
                    {
                        DialogResult result = MessageBox.Show(validationMessage + " Do you want to continue?", "POS SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result != DialogResult.Yes)
                        {
                            status = false;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show(validationMessage, "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        status = false;
                        break; // Break the loop if validation fails for any row
                    }
                }
            }
            if (status)
            {
                for (int i = 0; i < dataImport.Rows.Count; i++)
                {
                    string productCode = dataImport.Rows[i].Cells[0].Value?.ToString();
                    string productName = dataImport.Rows[i].Cells[1].Value?.ToString();
                    string unitName = dataImport.Rows[i].Cells[2].Value?.ToString();
                    string categoryName = dataImport.Rows[i].Cells[3].Value?.ToString();
                    string supplierName = dataImport.Rows[i].Cells[4].Value?.ToString();
                    string nettPrice = dataImport.Rows[i].Cells[5].Value?.ToString();
                    string margin = dataImport.Rows[i].Cells[6].Value?.ToString();
                    string tax = dataImport.Rows[i].Cells[7].Value?.ToString();
                    string discount = dataImport.Rows[i].Cells[8].Value?.ToString();
                    string info = dataImport.Rows[i].Cells[9].Value?.ToString();

                    string unitQry = @"SELECT id FROM Unit WHERE unit_code = '" + unitName + "'";
                    int unitId = Convert.ToInt32(SQLScalar(unitQry));

                    string categoryQry = @"SELECT id FROM Category WHERE name = '" + categoryName + "'";
                    int categoryId = Convert.ToInt32(SQLScalar(categoryQry));

                    string supplierQry = @"SELECT id FROM Supplier WHERE name = '" + supplierName + "'";
                    int supplierId = Convert.ToInt32(SQLScalar(supplierQry));
                    decimal nettPriceValue, marginValue, taxValue, discountValue, sellPriceValue;
                    decimal.TryParse(nettPrice, out nettPriceValue);
                    decimal.TryParse(margin, out marginValue);
                    decimal.TryParse(tax, out taxValue);
                    decimal.TryParse(discount, out discountValue);
                    sellPriceValue = ((nettPriceValue * (100 + marginValue) / 100) * (100 + taxValue) / 100) * (100 - discountValue) / 100;

                    string qry = @"INSERT INTO Product (id_unit, id_category, id_supplier, product_code, name, image, quantity_in, quantity_out, coli_in, coli_out,
                            nett_price, margin, tax, discount, sell_price, information) 
                            VALUES (@id_unit, @id_category, @id_supplier, @product_code, @name, @image, @quantity_in, @quantity_out, @coli_in, @coli_out,
                            @nett_price, @margin, @tax, @discount, @sell_price, @information)";

                    Hashtable ht = new Hashtable();
                    Image temp = new Bitmap(Properties.Resources.product);
                    MemoryStream ms = new MemoryStream();
                    temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageByteArray = ms.ToArray();

                    ht.Add("@id_unit", unitId);
                    ht.Add("@id_category", categoryId);
                    ht.Add("@id_supplier", supplierId);
                    ht.Add("@product_code", productCode);
                    ht.Add("@name", productName);
                    ht.Add("@image", imageByteArray);
                    ht.Add("@quantity_in", 0);
                    ht.Add("@quantity_out", 0);
                    ht.Add("@coli_in", 0);
                    ht.Add("@coli_out", 0);
                    ht.Add("@nett_price", nettPriceValue);
                    ht.Add("@margin", marginValue);
                    ht.Add("@tax", taxValue);
                    ht.Add("@discount", discountValue);
                    ht.Add("@sell_price", sellPriceValue);
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
            bool fileInUseMessageShown = false; // Initialize a flag

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
                        // Check if the message has been shown already
                        if (!fileInUseMessageShown)
                        {
                            MessageBox.Show("File is being used by another process.", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtFileName.Text = "";
                            fileInUseMessageShown = true; // Set the flag to true
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
