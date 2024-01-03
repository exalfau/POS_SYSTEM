using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using Excel = Microsoft.Office.Interop.Excel;
using System.Security.Cryptography;
using Aspose.Words.Lists;
using Aspose.Words.Tables;
using Aspose.Words.Themes;
using Microsoft.SqlServer.Management.Smo;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Security.Policy;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace POS_SYSTEM.Class
{
    internal class CommonMethod
    {
        public static DateTime timer { get; set; }
        public static Random random = new Random();

        public class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public static string ComputeSHA384Hash(string input)
        {
            using (SHA384 sha384 = SHA384.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha384.ComputeHash(bytes);

                // Convert the byte array to a hexadecimal string
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                Background.Size = frmMain.Instance.Size;
                Background.Location = frmMain.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();
            }
        }

        public static string GetRole(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 2)
            {
                return input;
            }

            char firstLetter = input[0];
            char secondLetter = input[1];
            char lastLetter = input[input.Length - 1];

            return firstLetter.ToString() + secondLetter.ToString() + lastLetter.ToString().ToUpper();
        }


        public static string GenerateRandomNumber(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string GenerateStaffID(int roleID, string roleName)
        {
            string rolePart = GetRole(roleName);
            string roleIDPart = roleID.ToString("D3");
            string lastStaffPart = DataMethod.GetStaffId().ToString("D5");
            string randomPart = GenerateRandomNumber(3);

            return $"{rolePart}-{roleIDPart}-{lastStaffPart}-{randomPart}";
        }

        public static string GenerateCusomerID()
        {
            string customerID = DataMethod.GetCustomerID().ToString("D5");
            string randomPart = GenerateRandomNumber(3);

            return $"CR-{customerID}-{randomPart}";
        }

        public static string GenerateSupplierID()
        {
            string customerID = DataMethod.GetSupplierID().ToString("D5");
            string randomPart = GenerateRandomNumber(3);

            return $"SR-{customerID}-{randomPart}";
        }

        public static bool CheckCheckedRow(DataGridView dataGrid)
        {
            bool anyRowChecked = false;

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;

                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                {
                    anyRowChecked = true;
                    break;
                }
            }

            return anyRowChecked;
        }

        public static void ConfigData(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.ReadOnly = true;
            }

            dataGridView.Columns[0].ReadOnly = false;

            int totalColumns = dataGridView.Columns.Count;
            dataGridView.Columns[totalColumns - 1].ReadOnly = false;
            dataGridView.Columns[totalColumns - 2].ReadOnly = false;
        }

        public static void Exports(DataGridView dataGrid, int columnsToSkip)
        {
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            xlapp.DisplayAlerts = false; 

            try
            {
                Workbook xlWbook = xlapp.Workbooks.Add();
                Worksheet xlsheet = (Worksheet)xlWbook.ActiveSheet;

                for (int col = columnsToSkip; col < dataGrid.ColumnCount; col++)
                {
                    if (!string.IsNullOrEmpty(dataGrid.Columns[col].HeaderText))
                    {
                        xlsheet.Cells[1, col - columnsToSkip + 1] = dataGrid.Columns[col].HeaderText;
                    }
                }
                int rowOffset = 1;

                for (int row = 0; row < dataGrid.RowCount; row++)
                {
                    DataGridViewRow dgvRow = dataGrid.Rows[row];
                    bool isChecked = dgvRow.Cells[0].Value != null && dgvRow.Cells[0].Value.Equals(true);

                    if (isChecked)
                    {
                        rowOffset++;

                        for (int col = columnsToSkip; col < dataGrid.ColumnCount; col++)
                        {
                            DataGridViewCell cell = dgvRow.Cells[col];

                            if (cell is DataGridViewTextBoxCell && !string.IsNullOrEmpty(cell.Value?.ToString()))
                            {
                                string cellValue = cell.Value?.ToString();

                                // Check if the value starts with a zero and it's numeric
                                if (!string.IsNullOrEmpty(cellValue) && cellValue.StartsWith("0") && int.TryParse(cellValue, out _))
                                {
                                    // If the value starts with a zero and is numeric, add an apostrophe to treat it as text
                                    xlsheet.Cells[rowOffset, col - columnsToSkip + 1] = "'" + cellValue;
                                }
                                else
                                {
                                    // Otherwise, write the value as it is
                                    xlsheet.Cells[rowOffset, col - columnsToSkip + 1] = cellValue;
                                }
                            }
                        }
                    }
                }
            }
            finally
            {
                // Release Excel objects to avoid memory leaks
                Marshal.ReleaseComObject(xlapp);
            }
        }

        public class PasswordGenerator
        {
            private const string UppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            private const string LowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            private const string NumericChars = "0123456789";
            private const string SpecialChars = "!@#$%^&*()-_=+[]{}|;:'\",.<>?";

            public static string GeneratePassword(int length = 12)
            {
                if (length < 8)
                {
                    throw new ArgumentException("Password length must be at least 8 characters.");
                }

                var pool = UppercaseChars + LowercaseChars + NumericChars + SpecialChars;

                using (var rng = new RNGCryptoServiceProvider())
                {
                    var passwordBuilder = new StringBuilder();
                    var randomBytes = new byte[length];

                    while (passwordBuilder.Length < length)
                    {
                        rng.GetBytes(randomBytes);
                        foreach (var randomByte in randomBytes)
                        {
                            if (passwordBuilder.Length >= length)
                            {
                                break;
                            }
                            var index = randomByte % pool.Length;
                            passwordBuilder.Append(pool[index]);
                        }
                    }

                    var password = passwordBuilder.ToString();
                    if (!MeetsRequirements(password))
                    {
                        return GeneratePassword(length);
                    }

                    return password;
                }
            }

            private static bool MeetsRequirements(string password)
            {
                return
                    password.Any(char.IsUpper) &&
                    password.Any(char.IsLower) &&
                    password.Any(char.IsDigit) &&
                    password.Any(IsSpecialChar);
            }

            private static bool IsSpecialChar(char c)
            {
                return SpecialChars.Contains(c);
            }
        }
    }
}

