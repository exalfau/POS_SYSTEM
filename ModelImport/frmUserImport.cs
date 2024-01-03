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
using static POS_SYSTEM.Class.DataMethod;
using static POS_SYSTEM.Class.ValidationMethod;
using static POS_SYSTEM.Class.CommonMethod;

namespace POS_SYSTEM.ModelImport
{
    public partial class frmUserImport : SampleAdd
    {
        DataTableCollection tableCollection;
        public frmUserImport()
        {
            InitializeComponent();
        }

        private void frmUserImport_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.user_color;
            lblHeader.Text = "Import User Details";
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
                string staffID = dataImport.Rows[i].Cells[0].Value?.ToString();
                string username = dataImport.Rows[i].Cells[1].Value?.ToString();
                string password = dataImport.Rows[i].Cells[2].Value?.ToString();

                string checkCourierQuery = "SELECT COUNT(*) FROM Account WHERE id_staff = (SELECT id FROM staff WHERE staff_id = '" + staffID + "')";
                int rowCount1 = Convert.ToInt32(SQLScalar(checkCourierQuery));
                if (rowCount1 > 0)
                {
                    MessageBox.Show(staffID + " User already exists. Please choose a different Staff ID.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                string checkStaffQuery = "SELECT COUNT(*) FROM Staff WHERE id = (SELECT id FROM staff WHERE staff_id = '" + staffID + "')";
                int rowCount2 = Convert.ToInt32(SQLScalar(checkStaffQuery));
                if (rowCount2 == 0)
                {
                    MessageBox.Show(staffID + " Staff ID is not found in the database", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (string.IsNullOrWhiteSpace(staffID))
                {
                    MessageBox.Show("Column Staff ID cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                string checkUsernameQuery = "SELECT COUNT(*) FROM Account WHERE username = '" + username + "'";
                int rowCount3 = Convert.ToInt32(SQLScalar(checkUsernameQuery));
                if (rowCount3 > 0)
                {
                    MessageBox.Show(username + " User already exists. Please choose a different username.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Column Staff ID cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (PasswordValidator.ValidatePassword(password) == false)
                {
                    MessageBox.Show(password + " password format Invalid", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validationFailed = true;
                    break;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Column password cannot be empty.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string staffID = dataImport.Rows[i].Cells[0].Value?.ToString();
                string username = dataImport.Rows[i].Cells[1].Value?.ToString();
                string password = dataImport.Rows[i].Cells[2].Value?.ToString();
                string encryptPass = ComputeSHA384Hash(password);
                string info = dataImport.Rows[i].Cells[3].Value?.ToString();
                string qry = @"INSERT INTO Account (id_staff, username, password, information) VALUES ((SELECT id FROM staff WHERE staff_id = @staff_id), @username, @password, @information)";
                Hashtable ht = new Hashtable();

                ht.Add("@staff_id", staffID);
                ht.Add("@username", username);
                ht.Add("@password", encryptPass);
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
