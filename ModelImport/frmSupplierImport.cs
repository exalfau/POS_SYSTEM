﻿using ExcelDataReader;
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
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static POS_SYSTEM.Class.CommonMethod;
using static POS_SYSTEM.Class.DataMethod;
using static POS_SYSTEM.Class.ValidationMethod;
using DataSet = System.Data.DataSet;

namespace POS_SYSTEM.ModelImport
{
    public partial class frmSupplierImport : SampleAdd
    {
        DataTableCollection tableCollection;
        Byte[] imageByteArray;

        public frmSupplierImport()
        {
            InitializeComponent();
        }

        private void frmSupplierImport_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.inventory_color;
            lblHeader.Text = "Import SUpplier Details";
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            bool status = true;
            bool validationFailed = false;

            for (int i = 0; i < dataImport.Rows.Count; i++)
            {
                if (dataImport.RowCount == 0)
                {
                    MessageBox.Show("Table cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                }

                string name = dataImport.Rows[i].Cells[0].Value?.ToString();
                object joinDate = dataImport.Rows[i].Cells[1].Value;
                string phone = dataImport.Rows[i].Cells[2].Value?.ToString();
                string address = dataImport.Rows[i].Cells[3].Value?.ToString();
                string info = dataImport.Rows[i].Cells[4].Value?.ToString();

                if (joinDate == null || string.IsNullOrWhiteSpace(joinDate.ToString()))
                {
                    MessageBox.Show("Column Date Out cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                string dateFormat = "d/MM/yyyy";
                DateTime parsedDate;
                string dateStr = joinDate is DateTime ? ((DateTime)joinDate).ToShortDateString() : joinDate.ToString();
                if (!DateTime.TryParseExact(dateStr, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                {
                    MessageBox.Show($"Invalid Date Out format. Please use the format = dd/MM/yyyy.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Column Name cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (string.IsNullOrWhiteSpace(phone))
                {
                    MessageBox.Show("Column Phone cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (ValidatePhoneNumber(phone.Trim()) == false)
                {
                    MessageBox.Show($"Invalid Phone format. Please use the format = 08XXXXXXXXX.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (string.IsNullOrWhiteSpace(address))
                {
                    MessageBox.Show("Column Address cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string joinDate = dataImport.Rows[i].Cells[1].Value?.ToString();
                string phone = dataImport.Rows[i].Cells[2].Value?.ToString();
                string address = dataImport.Rows[i].Cells[3].Value?.ToString();
                string info = dataImport.Rows[i].Cells[4].Value?.ToString();

                joinDate = joinDate.Split(' ')[0];
                joinDate = joinDate.Trim();


                DateTime date = DateTime.ParseExact(joinDate, "d/MM/yyyy", CultureInfo.InvariantCulture);

                string qry = @"INSERT INTO Supplier (supplier_id, name, image, join_date, phone, address, information) 
                            VALUES (@supplier_id, @name, @image, @join_date, @phone, @address, @information)";

                Image temp = new Bitmap(Properties.Resources.businessman_color);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();
                Hashtable ht = new Hashtable();

                ht.Add("@supplier_id", GenerateSupplierID());
                ht.Add("@name", name);
                ht.Add("@image", imageByteArray);
                ht.Add("@join_date", date);
                ht.Add("@phone", phone);
                ht.Add("@address", address);
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
                dataImport.Columns["JoinDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
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
