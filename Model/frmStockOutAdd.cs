using POS_SYSTEM.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POS_SYSTEM.Class.CommonMethod;
using static POS_SYSTEM.Class.DataMethod;
using static POS_SYSTEM.Class.ValidationMethod;

namespace POS_SYSTEM.Model
{
    public partial class frmStockOutAdd : SampleAdd
    {
        public int Tid = 0;
        public int SOid = 0;
        public decimal qty = 0;
        public decimal coli = 0;
        public string filePath = "";
        Byte[] imageByteArray;

        public frmStockOutAdd()
        {
            InitializeComponent();
        }

        private void frmStockOutAdd_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.return_box_color;
            if (Tid == 0)
            {
                LoadCBSupplier();
                lblHeader.Text = "Create Stock Out details";
                lblClock.Text = "Created at " + timer.ToString("HH:mm");
                txtTimeIn.Text = timer.ToString("HH:mm");
                dateIn.Value = DateTime.Now;
            }
            if (Tid > 0)
            {
                lblHeader.Text = "Update Stock In details";
                lblClock.Text = "Updated at " + timer.ToString("HH:mm");
                pictStockIn.Image = DataMethod.LoadImage("[Transaction]", Tid);
                cbConfim.Visible = true;
                comboSupplier.Enabled = false;
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation(this, Tid) == false)
            {
                return;
            }
            else
            {
                string qry1 = "";
                int record = 0;

                if (Tid == 0)
                {
                    qry1 = @"INSERT INTO [Transaction] (date, time, image, type, confirm, information)
                           VALUES (@date, @time, @image, @type, @confirm, @information)
                           SELECT SCOPE_IDENTITY()";
                }
                else
                {
                    qry1 = @"UPDATE [Transaction] SET date = @date, time = @time, image = @image, type = @type, confirm = @confirm, information = @information, date_updated = @date_updated
                           WHERE id = @id";
                }

                Image temp = new Bitmap(pictStockIn.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();

                int check = cbConfim.Checked ? 1 : 0;
                /*if (cbConfim.Checked)
                {
                    string quantityInQuery = $"SELECT quantity_in FROM Product WHERE id = (SELECT id_product FROM stock_out WHERE id_transaction  = '{Tid}')";
                    int quantityIn = Convert.ToInt32(SQLScalar(quantityInQuery));
                    string quantityOutQuery = $"SELECT quantity_out FROM Product WHERE id = (SELECT id_product FROM stock)out WHERE id_transaction  = '{Tid}')";
                    int quantityOut = Convert.ToInt32(SQLScalar(quantityOutQuery));

                    string coliInQuary = $"SELECT quantity_in FROM Product WHERE id = (SELECT id_product FROM stock_out WHERE id_transaction  = '{Tid}')";
                    int coliIn = Convert.ToInt32(SQLScalar(coliInQuary));
                    string coliOutQuery = $"SELECT quantity_out FROM Product WHERE id = (SELECT id_product FROM stock)out WHERE id_transaction  = '{Tid}')";
                    int coliOut = Convert.ToInt32(SQLScalar(coliOutQuery));

                    int enteredQuantity = Convert.ToInt32(txtQuantity.Text);
                    int enteredColi = Convert.ToInt32(txtColi.Text);

                    if (quantityOut + enteredQuantity > quantityIn || coliOut +enteredColi > coliIn)
                    {
                        MessageBox.Show("Confirming this record would make quantity or coli of the product to negative", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }
                }*/

                SqlCommand cmd1 = new SqlCommand(qry1, connection);
                cmd1.Parameters.AddWithValue("@id", Tid);
                cmd1.Parameters.AddWithValue("@date", Convert.ToDateTime(dateIn.Value));
                cmd1.Parameters.AddWithValue("@time", Convert.ToDateTime(txtTimeIn.Text));
                cmd1.Parameters.AddWithValue("@image", imageByteArray);
                cmd1.Parameters.AddWithValue("@type", "stock_out");
                cmd1.Parameters.AddWithValue("@confirm", check);
                cmd1.Parameters.AddWithValue("@information", txtInformation.Text);
                cmd1.Parameters.AddWithValue("@date_updated", timer);
                
                if (connection.State == ConnectionState.Closed) { connection.Open(); }

                if (Tid == 0)
                {
                    Tid = Convert.ToInt32(cmd1.ExecuteScalar());
                }
                else
                {
                   record += cmd1.ExecuteNonQuery();
                }

                string qry2 = "";

                if (SOid == 0)
                {
                    qry2 = @"INSERT INTO Stock_Out (id_transaction, id_supplier, id_product, quantity, coli, price, total_price, cause)
                               VALUES (@id_transaction, @id_supplier, @id_product, @quantity, @coli, @price, @total_price, @cause)";

                }
                else
                {
                    qry2 = @"UPDATE Stock_Out SET id_transaction = @id_transaction, id_supplier = @id_supplier, id_product = @id_product, 
                               quantity = @quantity, coli = @coli, price = @price, total_price = @total_price, cause = @cause
                               WHERE id = @id";
                }
                ComboboxItem selectedSupplier = (ComboboxItem)comboSupplier.SelectedItem;
                ComboboxItem selectedProduct = (ComboboxItem)comboProduct.SelectedItem;

                SqlCommand cmd2 = new SqlCommand(qry2, connection);
                cmd2.Parameters.AddWithValue("@id", SOid);
                cmd2.Parameters.AddWithValue("@id_transaction", Tid);
                cmd2.Parameters.AddWithValue("@id_supplier", selectedSupplier.Value);
                cmd2.Parameters.AddWithValue("@id_product", selectedProduct.Value);
                cmd2.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtQuantity.Text));
                cmd2.Parameters.AddWithValue("@coli", Convert.ToInt32(txtColi.Text));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                cmd2.Parameters.AddWithValue("@total_price", Convert.ToDecimal(txtTPrice.Text));
                cmd2.Parameters.AddWithValue("@cause", comboCause.Text);

                record += cmd2.ExecuteNonQuery();

                if (record > 0)
                {
                    MessageBox.Show("Input Sucessfull", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }


        public override void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void comboSupplier_TextChanged(object sender, EventArgs e)
        {

            if (comboSupplier.Text != "")
            {
                comboProduct.Items.Clear();
                LoadCBProduct();
                if (comboProduct.Items.Count > 0)
                {
                    comboProduct.Enabled = true;
                }
                else
                {
                    comboProduct.Enabled = false;

                }
                txtQuantity.Text = "";
                txtColi.Text = "";
                comboProduct.Text = "";
            }
            else
            {
                txtQuantity.Text = "";
                txtColi.Text = "";
                comboProduct.Text = "";
                comboProduct.Enabled = false;
            }
        }

        public void comboProduct_TextChanged(object sender, EventArgs e)
        {
            if (comboProduct.Text != "")
            {
                txtQuantity.Text = "";
                txtColi.Text = "";
                txtPrice.Text = "";
                txtTPrice.Text = "";
                LoadCBProductPrice();
                txtQuantityT.Text = qty.ToString();
                txtColiT.Text = coli.ToString();
                if (txtPrice.Text == "Invalid Input")
                {
                    txtQuantity.Enabled = false;
                    txtColi.Enabled = false;
                }
                else
                {
                    txtQuantity.Enabled = true;
                    txtColi.Enabled = true;
                }
            }
            else
            {
                txtPrice.Text = "";
                txtTPrice.Text = "";
                txtQuantity.Enabled = false;
                txtColi.Enabled = false;
            }
        }

        public void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (ValidateNegativeInput(txtQuantity) || txtQuantity.Text != "")
            {
                CalculateTotal();
                CalculateTotal(Convert.ToDecimal(txtQuantity.Text), Convert.ToDecimal(qty), txtQuantity, txtQuantityT, "Quantity");
            }
            else
            {
                txtTPrice.Text = "Invalid Input";
                txtQuantityT.Text = "";
                txtQuantityT.Text = qty.ToString();
            }
        }

        public void txtColi_TextChanged(object sender, EventArgs e)
        {
            if (ValidateNegativeInput(txtColi) || txtColi.Text != "")
            {
                CalculateTotal(Convert.ToDecimal(txtColi.Text), Convert.ToDecimal(coli), txtColi, txtColiT, "Coli");
            }
            else
            {
                txtColiT.Text = "";
                txtColiT.Text = coli.ToString();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "images(.jpg, .png) | *.png; *.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                pictStockIn.Image = new Bitmap(filePath);
            }
        }

        public void LoadCBSupplier()
        {
            string query = "SELECT id, name FROM Supplier";

            SqlCommand cmd = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["ID"];
                string value = reader["name"].ToString();
                comboSupplier.Items.Add(new CommonMethod.ComboboxItem { Text = value, Value = id });
            }
            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        public void LoadCBProduct()
        {
            if (comboSupplier.SelectedItem != null)
            {
                ComboboxItem selectedSupplier = (ComboboxItem)comboSupplier.SelectedItem;

                string query = "SELECT id, name FROM product WHERE id_supplier = '" + selectedSupplier.Value + "'";

                SqlCommand cmd = new SqlCommand(query, connection);
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string value = reader["name"].ToString();
                    comboProduct.Items.Add(new CommonMethod.ComboboxItem { Text = value, Value = id });
                }
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
        }

        public void LoadCBProductPrice()
        {
            ComboboxItem selectedProduct = (ComboboxItem)comboProduct.SelectedItem;
            if (selectedProduct == null)
            {
                txtPrice.Text = "Invalid Input";
                return;
            }
            string query = "SELECT nett_price, quantity_total, coli_total FROM product WHERE id = '" + selectedProduct.Value + "'";

            SqlCommand cmd = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtPrice.Text = reader["nett_price"].ToString();
                qty =Convert.ToDecimal( reader["quantity_total"]);
                coli = Convert.ToDecimal(reader["coli_total"]);
            }
            else
            {
                txtPrice.Text = "Invalid Input";
            }
            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        public void CalculateTotal()
        {
            if (txtQuantity.Text != "" || txtPrice.Text != "")
            {
                decimal qty = Convert.ToDecimal(txtQuantity.Text), price = Convert.ToDecimal(txtPrice.Text);
                decimal total = qty * price;
                txtTPrice.Text = total.ToString();
            }
        }

        public void CalculateTotal(decimal inputValue, decimal totalValue, Guna.UI2.WinForms.Guna2TextBox inputTextBox, Guna.UI2.WinForms.Guna2TextBox totalTextBox, string itemName)
        {
            if (inputTextBox.Text != "" || txtPrice.Text != "")
            {
                decimal outValue = Convert.ToDecimal(inputTextBox.Text);
                decimal total = totalValue - outValue;
                if (total < 0)
                {
                    inputTextBox.Text = "0";
                    totalTextBox.Text = totalValue.ToString();
                }
            }
        }
        
    }
}
