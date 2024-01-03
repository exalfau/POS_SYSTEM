using POS_SYSTEM.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static POS_SYSTEM.Class.CommonMethod;
using static POS_SYSTEM.Class.DataMethod;
using static POS_SYSTEM.Class.ValidationMethod;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS_SYSTEM.Model
{
    public partial class frmStockInAdd : SampleAdd
    {
        public int Tid = 0;
        public string filePath = "";
        Byte[] imageByteArray;

        public frmStockInAdd()
        {
            InitializeComponent();
        }

        private void frmStockInAdd_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.packaging_color;
            if (Tid == 0)
            {
                LoadCBSupplier();
                lblHeader.Text = "Create Stock In details";
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
                LoadStock();
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

                SqlCommand cmd1 = new SqlCommand(qry1, connection);
                cmd1.Parameters.AddWithValue("@id", Tid);
                cmd1.Parameters.AddWithValue("@date", Convert.ToDateTime(dateIn.Value));
                cmd1.Parameters.AddWithValue("@time", Convert.ToDateTime(txtTimeIn.Text));
                cmd1.Parameters.AddWithValue("@image", imageByteArray);
                cmd1.Parameters.AddWithValue("@type", "stock_in");
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
                    cmd1.ExecuteNonQuery();
                }

                foreach (DataGridViewRow row in dataProduct.Rows)
                {
                    int SIid = Convert.ToInt32(row.Cells["dgvID"].Value);
                    string qry2 = "";  // Move inside the loop

                    if (SIid == 0)
                    {
                        qry2 = @"INSERT INTO Stock_In (id_transaction, id_supplier, id_product, quantity, coli, price, total_price)
                               VALUES (@id_transaction, @id_supplier, @id_product, @quantity, @coli, @price, @total_price)";

                    }
                    else
                    {
                        qry2 = @"UPDATE Stock_In SET id_transaction = @id_transaction, id_supplier = @id_supplier, id_product = @id_product, 
                               quantity = @quantity, coli = @coli, price = @price, total_price = @total_price
                               WHERE id = @id";
                    }
                    ComboboxItem selectedSupplier = (ComboboxItem)comboSupplier.SelectedItem;

                    SqlCommand cmd2 = new SqlCommand(qry2, connection);
                    cmd2.Parameters.AddWithValue("@id", SIid);
                    cmd2.Parameters.AddWithValue("@id_transaction", Tid);
                    cmd2.Parameters.AddWithValue("@id_supplier", selectedSupplier.Value);
                    cmd2.Parameters.AddWithValue("@id_product", Convert.ToInt32(row.Cells["dgvIDProduct"].Value));
                    cmd2.Parameters.AddWithValue("@quantity", Convert.ToInt32(row.Cells["dgvQty"].Value));
                    cmd2.Parameters.AddWithValue("@coli", Convert.ToInt32(row.Cells["dgvColi"].Value));
                    cmd2.Parameters.AddWithValue("@price", Convert.ToDecimal(row.Cells["dgvNettPrice"].Value));
                    cmd2.Parameters.AddWithValue("@total_price", Convert.ToDecimal(row.Cells["dgvTotalPrice"].Value));
                    record += cmd2.ExecuteNonQuery();
                }

                if (record > 0)
                {
                    MessageBox.Show("Input Successful", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void comboProduct_TextChanged(object sender, EventArgs e)
        {
            if (comboProduct.Text != "")
            {
                txtQuantity.Text = "";
                txtColi.Text = "";
                txtPrice.Text = "";
                txtTPrice.Text = "";
                LoadCBProductPrice();
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


        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (ValidateNegativeInput(txtQuantity) || txtQuantity.Text != "")
            {
                CalculateTotal();
            }
            else
            {
                txtTPrice.Text = "Invalid Input";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidationAdd(this) == false)
            {
                return;
            }
            else
            {
                ComboboxItem selectedProduct = (ComboboxItem)comboProduct.SelectedItem;

                string pid, pname, qty, coli, price, total;
                pid = selectedProduct.Value.ToString();
                pname = comboProduct.Text;
                qty = txtQuantity.Text.TrimStart('0');
                coli = txtColi.Text.TrimStart('0');
                price = txtPrice.Text;
                total = txtTPrice.Text;

                DataGridViewRow existingRow = null;
                foreach (DataGridViewRow row in dataProduct.Rows)
                {
                    if (row.Cells["dgvIDProduct"].Value != null && row.Cells["dgvIDProduct"].Value.ToString() == pid)
                    {
                        existingRow = row;
                        break;
                    }
                }

                if (existingRow != null)
                {
                    int existingQty = Convert.ToInt32(existingRow.Cells["dgvQty"].Value);
                    int existingColi = Convert.ToInt32(existingRow.Cells["dgvColi"].Value);

                    existingRow.Cells["dgvQty"].Value = existingQty + int.Parse(qty);
                    existingRow.Cells["dgvColi"].Value = existingColi + int.Parse(coli);
                }
                else
                {
                    dataProduct.Rows.Add(0, 0, pid, pname, qty, coli, price, total);
                }
                txtQuantity.Text = "";
                txtColi.Text = "";
                comboSupplier.Enabled = false;
                comboProduct.Text = "";
            }
        }

        private void dataProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in dataProduct.Rows)
            {
                count++;
                row.Cells[0].Value = count;
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

        private void dataProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataProduct.Columns[e.ColumnIndex].Name == "dgvEdit")
            {
                btnUpdate.Visible = true;
                comboProduct.Enabled = false;
                comboProduct.Text = Convert.ToString(dataProduct.CurrentRow.Cells["dgvName"].Value);
                comboProduct_TextChanged(comboProduct, EventArgs.Empty);
                txtQuantity.Text = Convert.ToString(dataProduct.CurrentRow.Cells["dgvQty"].Value);
                txtColi.Text = Convert.ToString(dataProduct.CurrentRow.Cells["dgvColi"].Value);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboProduct.Text != "")
            {
                string pid, qty, coli, price, total;
                qty = txtQuantity.Text.TrimStart('0');
                coli = txtColi.Text.TrimStart('0');
                price = txtPrice.Text;
                total = txtTPrice.Text;

                dataProduct.CurrentRow.Cells["dgvQty"].Value = qty;
                dataProduct.CurrentRow.Cells["dgvColi"].Value = coli;
                dataProduct.CurrentRow.Cells["dgvNettPrice"].Value = price;
                dataProduct.CurrentRow.Cells["dgvTotalPrice"].Value = total;

                dataProduct.Refresh();
                btnUpdate.Visible = false;
                comboProduct.Enabled = true;
                comboProduct.Text = "";
                comboProduct_TextChanged(comboProduct, EventArgs.Empty);
                txtQuantity.Text = "";
                txtColi.Text = "";
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
            string query = "SELECT nett_price FROM product WHERE id = '" + selectedProduct.Value + "'";

            SqlCommand cmd = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtPrice.Text = reader["nett_price"].ToString();
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

        private void LoadStock()
        {
            string qry = "SELECT si.id, p.id as pid, p.name, si.quantity, si.coli, si.price, si.total_price " +
                         "FROM Stock_In si JOIN Product p ON si.id_product = p.id WHERE si.id_transaction = '"+Tid+"'";

            SqlCommand cmd = new SqlCommand(qry, connection);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                string id, pid, name, qty, coli, price, tprice;

                id = row["id"].ToString();
                pid = row["pid"].ToString();
                name = row["name"].ToString();
                qty = row["quantity"].ToString();
                coli = row["coli"].ToString();
                price = row["price"].ToString();
                tprice = row["total_price"].ToString();

                dataProduct.Rows.Add(0, id, pid, name, qty, coli, price, tprice);
            }
        }
    }
}
