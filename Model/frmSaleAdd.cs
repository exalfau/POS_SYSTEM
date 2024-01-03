using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POS_SYSTEM.Class.DataMethod;
using static POS_SYSTEM.Class.ValidationMethod;
using static POS_SYSTEM.Class.CommonMethod;
using System.Diagnostics;
using System.Security.Cryptography;
using POS_SYSTEM.Class;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Web.UI.WebControls;
using Image = System.Drawing.Image;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace POS_SYSTEM.Model
{
    public partial class frmSaleAdd : Sample
    {
        string payment, shipping, cusID, staffID;
        public int instalment;
        public decimal amount, deposit;
        public int Tid = 0;
        public int Sid = 0;
        public frmSaleAdd()
        {
            InitializeComponent();
        }

        private void frmSaleAdd_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.shopping_basket_color;
            if (Tid == 0)
            {
                LoadProduct();
                LoadCB();
                lblHeader.Text = "Create Sale details";
                lblClock.Text = "Created at " + timer.ToString();
                txtTimeSales.Text = timer.ToString("HH:mm");
                dateSales.Value = DateTime.Now;
            }
            if (Tid > 0)
            {
                lblHeader.Text = "Update Stock In details";
                lblClock.Text = "Updated at " + timer.ToString("HH:mm");
                cbConfim.Visible = true;
                btnNext.Visible = false;
                btnOrder.Visible = true;
                btnOrder.Text = "UPDATE ORDER";
            }
        }

        public void AddItems(string id, string name, string price, string stock, Image image)
        {
            var productControl = new ucProduct()
            {
                ID = Convert.ToInt32(id),
                NAME = name,
                STOCK = Convert.ToInt32(stock),
                PRICE = price,
                IMAGE = image,
            };

            flowMenu.Controls.Add(productControl);

            productControl.onSelect += (ss, ee) =>
            {
                var selectedProduct = (ucProduct)ss;

                // Check if there's already a ucProductAdd with the same ID in flowShopingCart
                var existingProductAdd = flowShopingCart.Controls.OfType<ucProductAdd>().FirstOrDefault(p => p.ID == selectedProduct.ID);

                if (existingProductAdd != null)
                {
                    // If exists, increment the quantity by 1
                    int currentQty = Convert.ToInt32(existingProductAdd.QTY);
                    int stockAll = Convert.ToInt32(existingProductAdd.STOCK);

                    if (currentQty < stockAll)
                    {
                        existingProductAdd.QTY = (currentQty + 1).ToString("D2");
                        existingProductAdd.TPRICE = (Convert.ToDouble(existingProductAdd.PRICE) * Convert.ToInt32(existingProductAdd.QTY)).ToString("N2");
                        GrandTotal();
                    }
                }
                else
                {
                    // If not exists, create a new ucProductAdd
                    var productAddControl = new ucProductAdd()
                    {
                        ID = selectedProduct.ID,
                        NAME = selectedProduct.NAME,
                        STOCK = Convert.ToString(selectedProduct.STOCK),
                        PRICE = selectedProduct.PRICE,
                        QTY = "01", // Default quantity
                        TPRICE = (Convert.ToDouble(selectedProduct.PRICE) * 1).ToString("N2"),
                        IMAGE = selectedProduct.IMAGE,
                    };

                    productAddControl.onSelect += (ff, gg) =>
                    {
                        flowShopingCart.Controls.Remove(productAddControl);
                        GrandTotal();
                    };

                    productAddControl.btnPlus.Click += (ff, gg) =>
                    {
                        int currentQty = string.IsNullOrEmpty(productAddControl.QTY) ? 0 : Convert.ToInt32(productAddControl.QTY);
                        int stockAll = Convert.ToInt32(productAddControl.STOCK);

                        if (currentQty < stockAll)
                        {
                            productAddControl.QTY = (currentQty + 1).ToString("D2");
                            productAddControl.TPRICE = (Convert.ToDouble(productAddControl.PRICE) * Convert.ToInt32(productAddControl.QTY)).ToString("N2");
                            GrandTotal();
                        }
                    };

                    productAddControl.btnMin.Click += (ff, gg) =>
                    {
                        int newQty = Convert.ToInt32(productAddControl.QTY) - 1;
                        if (newQty >= 0)
                        {
                            productAddControl.QTY = newQty.ToString("D2");
                            productAddControl.TPRICE = (Convert.ToDouble(productAddControl.PRICE) * newQty).ToString("N2");
                            GrandTotal();
                        }
                    };

                    productAddControl.txtQTY.TextChanged += (ff, gg) =>
                    {
                        if (string.IsNullOrEmpty(productAddControl.txtQTY.Text))
                        {
                            productAddControl.TPRICE = 0.ToString("N2");
                            GrandTotal();
                            return;
                        }

                        if (int.TryParse(productAddControl.txtQTY.Text, out int newQty))
                        {
                            int stockAll = Convert.ToInt32(productAddControl.STOCK);

                            if (newQty >= 0)
                            {
                                newQty = Math.Min(newQty, stockAll);

                                productAddControl.QTY = newQty.ToString("D2");
                                productAddControl.TPRICE = (Convert.ToDouble(productAddControl.PRICE) * newQty).ToString("N2");
                                GrandTotal();
                            }
                        }
                    };

                    flowShopingCart.Controls.Add(productAddControl);
                    GrandTotal();
                }
            };
        }


        public void GrandTotal()
        {
            decimal total = 0;

            // Calculate the total from the products in flowPanel
            foreach (Control item in flowShopingCart.Controls)
            {
                if (item is ucProductAdd productAddControl)
                {
                    total += Convert.ToDecimal(productAddControl.TPRICE);
                }
            }

            // Add the value from txtCost to the total
            if (decimal.TryParse(txtCost.Text, out decimal costValue))
            {
                total += costValue;
            }

            lblTotal.Text = total.ToString("N2");
        }

        private void LoadProduct()
        {
            string qry = "SELECT * FROM Product WHERE quantity_total > 0"; // Only select products with quantity_total > 0
            SqlCommand cmd = new SqlCommand(qry, connection);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    byte[] imageArray = (byte[])row["image"];
                    AddItems(row["id"].ToString(), row["name"].ToString(), row["sell_price"].ToString(), row["quantity_total"].ToString(),
                        Image.FromStream(new MemoryStream(imageArray)));
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPrevious.Visible = true;
            btnOrder.Visible = true;
            btnNext.Visible = false;
            flowShopingCart.Visible = false;
            flowCheckOut.Visible = true;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            btnPrevious.Visible=false;
            btnOrder.Visible=false;
            btnNext.Visible=true;
            flowShopingCart.Visible=true;
            flowCheckOut.Visible=false;
        }

        private void radioLoan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLoan.Checked == true)
            {
                panelLoan.Visible = true;
            }
            else
            {
                panelLoan.Visible = false;
            }
        }

        private void radioDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDeposit.Checked == true)
            {
                panelDeposit.Visible = true;
                txtBalance.Text = "";
                txtBalance.Text = deposit.ToString();
            }
            else
            {
                panelDeposit.Visible = false;
            }
        }

        private void radioDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDelivery.Checked == true)
            {
                panelDelivery.Visible = true;
                LoadCBCourier();
            }
            else
            {
                panelDelivery.Visible=false;
                comboCourier.Items.Clear();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowMenu.Controls)
            {
                var product = (ucProduct)item;
                product.Visible = product.NAME.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }

        private void comboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            deposit = 0;
            LoadDeposit();
            txtBalance.Text = deposit.ToString();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ComboboxItem selectedCustomer = (ComboboxItem)comboCustomer.SelectedItem;
            ComboboxItem selectedCourier = (ComboboxItem)comboCourier.SelectedItem;

            decimal total;
            decimal.TryParse(lblTotal.Text, out total);

            if (total == 0)
            {
                MessageBox.Show("Pick atleast 1 product ", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Validation(this, Tid) == false)
            {
                return;
            }
            
            if (!radioCash.Checked && !radioLoan.Checked && !radioDeposit.Checked)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Select one of the option.", radioDeposit, 0, radioDeposit.Height + 5, 5000); // Display tooltip for 5 seconds
                return;
            }
            if (radioLoan.Checked == true && !radio3X.Checked && !radio6X.Checked && !radio12X.Checked)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Select one of the option.", radio3X, 0, radio3X.Height + 5, 5000); // Display tooltip for 5 seconds
                return;
            }
            if (radioLoan.Checked == true && total < 30000)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Total amount is not enough for a loan.", radioLoan, 0, radioLoan.Height + 5, 5000); // Display tooltip for 5 seconds
                return;
            }
            if (!radioSelfPick.Checked && !radioDelivery.Checked)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Select either option.", radioSelfPick, 0, radioSelfPick.Height + 5, 5000); // Display tooltip for 5 seconds
                return; 
            }
            if (panelDeposit.Visible == true && Convert.ToDecimal(lblTotal.Text) > deposit)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("insufficient balance.", txtBalance, 0, txtBalance.Height + 5, 5000); // Display tooltip for 5 seconds
                return; 
            }

            if (radioDelivery.Checked)
            {
                if (radioDelivery.Checked == true && string.IsNullOrEmpty(comboCourier.Text))
                {
                    comboCourier.Focus();
                    comboCourier.BackColor = Color.Red;
                    toolTip.Show("Value cannot be empty", comboCourier, 0, comboCourier.Height + 5, 5000);
                    return;
                }
                else
                {
                    bool textIsValid = false;
                    foreach (object item in comboCourier.Items)
                    {
                        if (comboCourier.Text == item.ToString())
                        {
                            textIsValid = true;
                            break;
                        }
                    }

                    if (!textIsValid)
                    {
                        comboCourier.Focus();
                        comboCourier.BackColor = Color.Red;
                        toolTip.Show("Value not found in list.", comboCourier, 0, comboCourier.Height + 5, 5000);
                        return;
                    }
                    else
                    {
                        comboCourier.BackColor = SystemColors.Window;
                    }
                }

                if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    ToolTip toolTip = new ToolTip();
                    txtAddress.Focus();
                    txtAddress.BorderColor = Color.Red;
                    txtAddress.FocusedState.BorderColor = Color.Red;
                    txtAddress.HoverState.BorderColor = Color.Red;
                    toolTip.Show("Input invalid", txtAddress, 0, txtAddress.Height + 5, 5000);
                    return;
                }
                else
                {
                    txtAddress.BorderColor = Color.FromArgb(213, 218, 223);
                    txtAddress.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                    txtAddress.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                }

                if (string.IsNullOrEmpty(txtCost.Text))
                {
                    ToolTip toolTip = new ToolTip();
                    txtCost.Focus();
                    txtCost.BorderColor = Color.Red;
                    txtCost.FocusedState.BorderColor = Color.Red;
                    txtCost.HoverState.BorderColor = Color.Red;
                    toolTip.Show("Input invalid", txtCost, 0, txtCost.Height + 5, 5000);
                    return;

                }
                else
                {
                    txtCost.BorderColor = Color.FromArgb(213, 218, 223);
                    txtCost.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                    txtCost.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
                }
            }
           
            string invoice = GenerateInvoice();

            if (radioCash.Checked == true) { payment = "cash"; }
            else if (radio3X.Checked == true) { payment = "credit 3x"; }
            else if (radio6X.Checked == true) { payment = "credit 6x"; }
            else if (radio12X.Checked == true) { payment = "credit 12x"; } 
            else if (radioDeposit.Checked == true) { payment = "deposit"; }

            if (radioSelfPick.Checked == true) { shipping = "self-pickup"; } else if (radioDelivery.Checked == true) { shipping = "delivery"; }

            string qry1 = "";
            int record = 0;

            if (Tid == 0)
            {
                qry1 = @"INSERT INTO [Transaction] (invoice_id, date, time, type, confirm, payment_type, shipping_type, information)
                           VALUES (@invoice_id, @date, @time, @type, @confirm, @payment_type, @shipping_type, @information)
                           SELECT SCOPE_IDENTITY()";
            }
            else
            {
                qry1 = @"UPDATE [Transaction] SET date = @date, time = @time, type = @type, confirm = @confirm,
                           information = @information, date_updated = @date_updated 
                           WHERE id = @id";
            }

            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            SqlCommand cmd1 = new SqlCommand(qry1, connection);
            cmd1.Parameters.AddWithValue("@id", Tid);
            cmd1.Parameters.AddWithValue("@invoice_id", Convert.ToString(invoice));
            cmd1.Parameters.AddWithValue("@date", Convert.ToDateTime(dateSales.Value));
            cmd1.Parameters.AddWithValue("@time", Convert.ToDateTime(txtTimeSales.Text));
            cmd1.Parameters.AddWithValue("@type", "sales");
            cmd1.Parameters.AddWithValue("@confirm", 1);
            cmd1.Parameters.AddWithValue("@information", txtInfoTransaction.Text);
            cmd1.Parameters.AddWithValue("@payment_type", payment);
            cmd1.Parameters.AddWithValue("@shipping_type", shipping);
            cmd1.Parameters.AddWithValue("@date_updated", timer);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }

            if (Tid == 0)
            {
                Tid = Convert.ToInt32(cmd1.ExecuteScalar());
            }
            else
            {
                cmd1.ExecuteNonQuery();
            }

            if (radioLoan.Checked == true)
            {
                string qryLoan = "";
                if (radio3X.Checked == true) { instalment = 3; amount = total / 3; }
                else if (radio6X.Checked == true) { instalment = 6; amount = total / 6; }
                else if (radio12X.Checked == true) { instalment = 12; amount = total / 12; }
                for (int i = 0; i < instalment; i++)
                {
                    qryLoan = @"INSERT INTO Customer_Credit (id_transaction, id_customer, amount, due, instalment, status)
                                    VALUES (@id_transaction, @id_customer, @amount, @due, @instalment, @status)";
                    if (connection.State == ConnectionState.Closed) { connection.Open(); }
                    SqlCommand cmd3 = new SqlCommand(qryLoan, connection);
                    cmd3.Parameters.AddWithValue("@id_transaction", Tid);
                    cmd3.Parameters.AddWithValue("@id_customer", selectedCustomer.Value);
                    cmd3.Parameters.AddWithValue("@amount", amount);
                    DateTime dueDate = dateSales.Value.AddMonths(i + 1);
                    cmd3.Parameters.AddWithValue("@due", dueDate);
                    cmd3.Parameters.AddWithValue("@instalment", i + 1);
                    cmd3.Parameters.AddWithValue("@status", "pending");
                    cmd3.ExecuteNonQuery();
                    if (connection.State == ConnectionState.Closed) { connection.Open(); }
                }
            }

            if (radioDeposit.Checked == true)
            {
                string qryDeposit = "";
                qryDeposit = @"INSERT INTO Customer_Deposit (id_transaction, id_customer, date, amount, type) 
                            VALUES (@id_transaction, @id_customer, @date, @amount, @type)";
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                SqlCommand cmd4 = new SqlCommand(qryDeposit, connection);
                cmd4.Parameters.AddWithValue("@id_transaction", Tid);
                cmd4.Parameters.AddWithValue("@id_customer", selectedCustomer.Value);
                cmd4.Parameters.AddWithValue("@date", Convert.ToDateTime(dateSales.Value));
                cmd4.Parameters.AddWithValue("@amount", total);
                cmd4.Parameters.AddWithValue("@type", "payment");

                cmd4.ExecuteNonQuery();
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
            }

            if (radioDelivery.Checked == true)
            {
                string qryDeposit = "";
                qryDeposit = @"INSERT INTO Delivery (id_transaction, id_customer, id_courier, address, cost, status, information) 
                            VALUES (@id_transaction, @id_customer, @id_courier, @address, @cost, @status, @information)";
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                SqlCommand cmd5 = new SqlCommand(qryDeposit, connection);
                cmd5.Parameters.AddWithValue("@id_transaction", Tid);
                cmd5.Parameters.AddWithValue("@id_customer", selectedCustomer.Value);
                cmd5.Parameters.AddWithValue("@id_courier", selectedCourier.Value);
                cmd5.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd5.Parameters.AddWithValue("@cost", Convert.ToDecimal(txtCost.Text));
                cmd5.Parameters.AddWithValue("@status", "on process");
                cmd5.Parameters.AddWithValue("@information", txtInfoDelivery.Text);

                cmd5.ExecuteNonQuery();
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
            }

            var controlsCopy = new List<Control>(flowShopingCart.Controls.Cast<Control>());
            for (int i = 0; i < controlsCopy.Count; i++)
            {
                var item = controlsCopy[i];
                var productAdd = (ucProductAdd)item;
                string qry2 = "";  // Move inside the loop

                if (Sid == 0)
                {
                    qry2 = @"INSERT INTO Sales_Detail (id_transaction, id_customer, id_staff, id_product, quantity, price, total_price)
                               VALUES (@id_transaction, @id_customer, @id_staff, @id_product, @quantity, @price, @total_price)";

                }
                else
                {
                    qry2 = @"UPDATE Sales_Detail SET id_transaction = @id_transaction, id_customer = @id_customer, id_staff = @id_staff, id_product = @id_product,
                               quantity = @quantity, price = @price, total_price = @total_price
                               WHERE id = @id";

                }

                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                SqlCommand cmd2 = new SqlCommand(qry2, connection);
                cmd2.Parameters.AddWithValue("@id", Sid);
                cmd2.Parameters.AddWithValue("@id_transaction", Tid);
                cmd2.Parameters.AddWithValue("@id_customer", selectedCustomer.Value);
                cmd2.Parameters.AddWithValue("@id_staff",Convert.ToInt32(ID));
                cmd2.Parameters.AddWithValue("@id_product", Convert.ToInt32(productAdd.ID));
                cmd2.Parameters.AddWithValue("@quantity", Convert.ToInt32(productAdd.QTY));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDecimal(productAdd.PRICE));
                cmd2.Parameters.AddWithValue("@total_price",Convert.ToDecimal( productAdd.TPRICE));
                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                record += cmd2.ExecuteNonQuery();
            }

            if (record > 0)
            {
                MessageBox.Show("Order Sucessfull, Invoice = " + invoice, "POS System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        public void LoadCB()
        {
            string query = "SELECT id, name FROM Customer";

            SqlCommand cmd = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["ID"];
                string value = reader["name"].ToString();
                comboCustomer.Items.Add(new CommonMethod.ComboboxItem { Text = value, Value = id });
            }
            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        public void LoadCBCourier()
        {
            string query = "SELECT c.id, s.name FROM Courier c JOIN Staff s ON c.id_staff = s.id";

            SqlCommand cmd = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["ID"];
                string value = reader["name"].ToString();
                comboCourier.Items.Add(new CommonMethod.ComboboxItem { Text = value, Value = id });
            }
            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        public void LoadCustomerID()
        {
            ComboboxItem selectedCustomer = (ComboboxItem)comboCustomer.SelectedItem;
            string query = "SELECT customer_id FROM Customer WHERE id = '" + selectedCustomer.Value + "'";

            SqlCommand cmd = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cusID = reader["customer_id"].ToString();
            }

            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        public decimal previousCost;

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            ValidateNegativeInput(txtCost);

            GrandTotal();

        }

        public void LoadStaffID()
        {
            string query = "SELECT staff_id FROM Staff WHERE id = '" + ID + "'";

            SqlCommand cmd = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                staffID = reader["staff_id"].ToString();
            }

            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        public static int GetTransID()
        {
            int lastTrans = 0;
            string query = "SELECT TOP 1 id FROM [Transaction] ORDER BY id DESC";
            SqlCommand command = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            object result = command.ExecuteScalar();
            if (connection.State == ConnectionState.Open) { connection.Close(); }

            return lastTrans = Convert.ToInt32(result) + 1;
        }

        public void LoadDeposit()
        {
            ComboboxItem selectedCustomer = (ComboboxItem)comboCustomer.SelectedItem;
            string query = "SELECT total FROM Customer_Deposit WHERE id_customer = '" + selectedCustomer.Value + "' ORDER BY id DESC";

            SqlCommand cmd = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                deposit =Convert.ToDecimal( reader["total"]);
            }

            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        private string GenerateInvoice()
        {
            LoadCustomerID();
            LoadStaffID();
            DateTime date = dateSales.Value;
            string datePart = date.ToString("ddMMyy");
            string transCount = GetTransID().ToString("D3");
            string customerPart = cusID.Substring(9);
            string staffPart = staffID.Substring(14);

            return $"{datePart}{transCount}-{customerPart}-{staffPart}";
        }
    }
}
