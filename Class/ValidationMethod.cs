using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace POS_SYSTEM.Class
{
    internal class ValidationMethod
    {
        public static ToolTip toolTip;

        public static bool Validation(Form f,int id)
        {
            bool isValid = false;
            int count = 0;
            toolTip = new ToolTip();

            foreach (Control c in f.Controls)
            {
                if (Convert.ToString(c.Tag) == "t" && Convert.ToString(c.Tag) != null)
                {
                    if (c is Guna.UI2.WinForms.Guna2TextBox)
                    {
                        Guna.UI2.WinForms.Guna2TextBox t = (Guna.UI2.WinForms.Guna2TextBox)c;
                        if (t.Text.Trim() == "" || t.Text == "Invalid Input")
                        {
                            t.Focus();
                            t.BorderColor = Color.Red;
                            t.FocusedState.BorderColor = Color.Red;
                            t.HoverState.BorderColor = Color.Red;
                            toolTip.Show("Input invalid", t, 0, t.Height + 5, 5000);
                            count++;
                        }
                        else
                        {
                            t.BorderColor = Color.FromArgb(213, 218, 223);
                            t.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                            t.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                        }
                    }
                }
                else if (Convert.ToString(c.Tag) == "time" && Convert.ToString(c.Tag) != null)
                {
                    if (c is Guna.UI2.WinForms.Guna2TextBox)
                    {
                        Guna.UI2.WinForms.Guna2TextBox t = (Guna.UI2.WinForms.Guna2TextBox)c;
                        if (!IsValidTimeFormat(t.Text))
                        {
                            t.Focus();
                            t.BorderColor = Color.Red;
                            t.FocusedState.BorderColor = Color.Red;
                            t.HoverState.BorderColor = Color.Red;
                            toolTip.Show("Input invalid", t, 0, t.Height + 5, 5000);
                            count++;
                        }
                        else
                        {
                            t.BorderColor = Color.FromArgb(213, 218, 223);
                            t.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                            t.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                        }
                    }
                }
                else if (Convert.ToString(c.Tag) == "pass" && c is Guna.UI2.WinForms.Guna2TextBox pass)
                {
                    if (!PasswordValidator.ValidatePassword(pass.Text) || pass.Text == "")
                    {
                        pass.BorderColor = Color.Red;
                        pass.FocusedState.BorderColor = Color.Red;
                        pass.HoverState.BorderColor = Color.Red;
                        toolTip.IsBalloon = false;
                        toolTip.Show("Minimum length of 8 characters. \nContains at least 1 uppercase letter. \nContains at least 1 lowercase letter. \nContains at least 1 digit number. \nContains at least 1 special character.", pass, 0, pass.Height + 5, 5000);
                        count++;
                    }
                    else
                    {
                        pass.BorderColor = Color.FromArgb(213, 218, 223);
                        pass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                        pass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                    }
                }
                else if (Convert.ToString(c.Tag) == "p" && Convert.ToString(c.Tag) != null)
                {
                    Guna.UI2.WinForms.Guna2TextBox p = (Guna.UI2.WinForms.Guna2TextBox)c;
                    if (ValidatePhoneNumber(p.Text) == false || p.Text.Trim() == "")
                    {

                        p.BorderColor = Color.Red;
                        p.FocusedState.BorderColor = Color.Red;
                        p.HoverState.BorderColor = Color.Red;
                        toolTip.Show("Phone number format must be 08XXXXXXXXX.", p, 0, p.Height + 5, 5000);
                        count++;
                    }
                    else
                    {
                        p.BorderColor = Color.FromArgb(213, 218, 223);
                        p.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                        p.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                    }
                }
                else if (Convert.ToString(c.Tag) == "lp" && Convert.ToString(c.Tag) != null)
                {
                    Guna.UI2.WinForms.Guna2TextBox lp = (Guna.UI2.WinForms.Guna2TextBox)c;
                    if (ValidateLicesenPlate(lp.Text) == false || lp.Text.Trim() == "")
                    {

                        lp.BorderColor = Color.Red;
                        lp.FocusedState.BorderColor = Color.Red;
                        lp.HoverState.BorderColor = Color.Red;
                        toolTip.IsBalloon = false;
                        toolTip.Show("License Plate format must be BK 1234 ABC. \nContain BK. \nContain 1-4 Number. \nContain 1-3 Letter.", lp, 0, lp.Height + 5, 5000); // Display tooltip for 2 seconds
                        count++;
                    }
                    else
                    {
                        lp.BorderColor = Color.FromArgb(213, 218, 223);
                        lp.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                        lp.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                    }
                }
                else if (Convert.ToString(c.Tag) == "n" && Convert.ToString(c.Tag) != null)
                {
                    Guna.UI2.WinForms.Guna2TextBox n = (Guna.UI2.WinForms.Guna2TextBox)c;
                    if (ValidateDecimalNumber(n.Text) == false || n.Text.Trim() == "")
                    {

                        n.BorderColor = Color.Red;
                        n.FocusedState.BorderColor = Color.Red;
                        n.HoverState.BorderColor = Color.Red;
                        toolTip.Show("Value must be a number greater than 0", n, 0, n.Height + 5, 5000);
                        count++;
                    }
                    else
                    {
                        n.BorderColor = Color.FromArgb(213, 218, 223);
                        n.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                        n.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                    }
                }
                else if (Convert.ToString(c.Tag) == "com" && c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;

                    if (string.IsNullOrEmpty(comboBox.Text))
                    {
                        comboBox.Focus();
                        comboBox.BackColor = Color.Red;
                        toolTip.Show("Value cannot be empty", comboBox, 0, comboBox.Height + 5, 5000);
                        count++;
                    }
                    else
                    {
                        bool textIsValid = false;
                        foreach (object item in comboBox.Items)
                        {
                            if (comboBox.Text == item.ToString())
                            {
                                textIsValid = true;
                                break;
                            }
                        }

                        if (!textIsValid)
                        {
                            comboBox.Focus();
                            comboBox.BackColor = Color.Red;
                            toolTip.Show("Value not found in list.", comboBox, 0, comboBox.Height + 5, 5000);
                            count++;
                        }
                        else
                        {
                            comboBox.BackColor = SystemColors.Window;
                        }
                    }
                }
                else if (Convert.ToString(c.Tag) == "comtext" && c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;

                    if (string.IsNullOrEmpty(comboBox.Text))
                    {
                        comboBox.Focus();
                        comboBox.BackColor = Color.Red;
                        toolTip.Show("Value cannot be empty", comboBox, 0, comboBox.Height + 5, 5000);
                        count++;
                    }
                    else
                    {
                        comboBox.BackColor = SystemColors.Window;
                        
                    }
                }

                if (count == 0)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }
            if (f.Controls.ContainsKey("dataProduct") && f.Controls["dataProduct"] is DataGridView dataGridView)
            {
                if (dataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("Table must contain atleast 1 product.", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    count++;
                }
            }
            return isValid;
        }

        public static bool ValidationAdd(Form f)
        {
            bool isValid = false;
            int count = 0;
            toolTip = new ToolTip();

            foreach (Control c in f.Controls)
            {
                if (Convert.ToString(c.Tag) == "t2" && Convert.ToString(c.Tag) != null)
                {
                    if (c is Guna.UI2.WinForms.Guna2TextBox)
                    {
                        Guna.UI2.WinForms.Guna2TextBox t = (Guna.UI2.WinForms.Guna2TextBox)c;
                        if (t.Text.Trim() == "" || t.Text == "Invalid Input")
                        {
                            t.Focus();
                            t.BorderColor = Color.Red;
                            t.FocusedState.BorderColor = Color.Red;
                            t.HoverState.BorderColor = Color.Red;
                            toolTip.Show("Input invalid", t, 0, t.Height + 5, 5000);
                            count++;
                        }
                        else
                        {
                            t.BorderColor = Color.FromArgb(213, 218, 223);
                            t.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                            t.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                        }
                    }
                }
                else if (Convert.ToString(c.Tag) == "n2" && Convert.ToString(c.Tag) != null)
                {
                    Guna.UI2.WinForms.Guna2TextBox n = (Guna.UI2.WinForms.Guna2TextBox)c;
                    if (ValidateDecimalNumber(n.Text) == false || n.Text.Trim() == "")
                    {

                        n.BorderColor = Color.Red;
                        n.FocusedState.BorderColor = Color.Red;
                        n.HoverState.BorderColor = Color.Red;
                        toolTip.Show("Value must be a number greater than 0", n, 0, n.Height + 5, 5000);
                        count++;
                    }
                    else
                    {
                        n.BorderColor = Color.FromArgb(213, 218, 223);
                        n.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                        n.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                    }
                }
                else if (Convert.ToString(c.Tag) == "com2" && c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;

                    if (string.IsNullOrEmpty(comboBox.Text))
                    {
                        comboBox.Focus();
                        comboBox.BackColor = Color.Red;
                        toolTip.Show("Value cannot be empty", comboBox, 0, comboBox.Height + 5, 5000);
                        count++;
                    }
                    else
                    {
                        bool textIsValid = false;
                        foreach (object item in comboBox.Items)
                        {
                            if (comboBox.Text == item.ToString())
                            {
                                textIsValid = true;
                                break;
                            }
                        }

                        if (!textIsValid)
                        {
                            comboBox.Focus();
                            comboBox.BackColor = Color.Red;
                            toolTip.Show("Value not found in list.", comboBox, 0, comboBox.Height + 5, 5000);
                            count++;
                        }
                        else
                        {
                            comboBox.BackColor = SystemColors.Window;
                        }
                    }
                }


                if (count == 0)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        public static bool ValidationPass(Form f, int id)
        {
            bool isValid = false;
            int count = 0;
            toolTip = new ToolTip();

            foreach (Control c in f.Controls)
            {
                
                if (id == 0 && Convert.ToString(c.Tag) == "pass2" && c is Guna.UI2.WinForms.Guna2TextBox pass)
                {
                    if (!PasswordValidator.ValidatePassword(pass.Text) || pass.Text.Trim() == "")
                    {
                        pass.BorderColor = Color.Red;
                        pass.FocusedState.BorderColor = Color.Red;
                        pass.HoverState.BorderColor = Color.Red;
                        toolTip.IsBalloon = false;
                        toolTip.Show("Minimum length of 8 characters. \nContains at least 1 uppercase letter. \nContains at least 1 lowercase letter. \nContains at least 1 digit number. \nContains at least 1 special character.", pass, 0, pass.Height + 5, 5000);
                        count++;
                    }
                    else
                    {
                        pass.BorderColor = Color.FromArgb(213, 218, 223);
                        pass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                        pass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                    }
                }
                if (count == 0)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }
            return isValid;
        }


        private static bool IsValidTimeFormat(string input)
        {
            DateTime dummyResult;
            return DateTime.TryParseExact(input, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dummyResult);
        }

        public static bool ValidateNegativeInput(Guna2TextBox textBox)
        {
            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                if (value < 0)
                {
                    textBox.Text = "";
                    return false;
                }
            }
            else
            {
                textBox.Text = "";
                return false;
            }
            return true;
        }


        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            string pattern = @"^08\d{7,9}$";

            bool isValid = Regex.IsMatch(phoneNumber, pattern);
            return isValid;
        }

        public static bool ValidateLicesenPlate(string input)
        {
            string pattern = @"^(?i)BK \d{1,4} [A-Za-z]{1,3}$";

            return Regex.IsMatch(input, pattern);
        }

        public static bool ValidateNumber(string text)
        {
            if (int.TryParse(text, out int number) && number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateDecimalNumber(string text)
        {
            if (decimal.TryParse(text, out decimal number) && number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public class PasswordValidator
        {
            private const string UppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            private const string LowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            private const string NumericChars = "0123456789";
            private const string SpecialChars = "!@#$%^&*()-_=+[]{}|;:'\",.<>?";

            public static bool ValidatePassword(string password)
            {
                if (password.Length < 8)
                {
                    return false;
                }

                bool hasUppercase = password.Any(char.IsUpper);
                bool hasLowercase = password.Any(char.IsLower);
                bool hasDigit = password.Any(char.IsDigit);
                bool hasSpecialChar = password.Any(IsSpecialChar);

                return hasUppercase && hasLowercase && hasDigit && hasSpecialChar;
            }

            private static bool IsSpecialChar(char c)
            {
                return SpecialChars.Contains(c);
            }
        }
    }
}
