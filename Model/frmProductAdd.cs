using POS_SYSTEM.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POS_SYSTEM.Class.DataMethod;
using static POS_SYSTEM.Class.ValidationMethod;
using static POS_SYSTEM.Class.CommonMethod;
using System.Collections;
using System.IO;
using System.Data.SqlClient;

namespace POS_SYSTEM.Model
{
    public partial class frmProductAdd : SampleAdd
    {
        public int id = 0;
        public int idRole = 0;
        public string gender;
        public string filePath = "";
        Byte[] imageByteArray;
        bool itsOkay;

        public frmProductAdd()
        {
            InitializeComponent();
        }

        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.product1;
            if (id == 0)
            {
                lblHeader.Text = "Create Product details";
                lblClock.Text = "Created at " + timer.ToString("HH:mm");
                LoadCBU();
                LoadCBC();
                LoadCBS();
            }
            else
            {
                lblHeader.Text = "Update Product details";
                lblClock.Text = "Updated at " + timer.ToString("HH:mm");
                pictProduct.Image = DataMethod.LoadImage("Product", id);
              
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation(this, id) == false)
            {
                return;
            }
            else
            {
                string qry = "";
                if (id == 0)
                {
                    qry = @"INSERT INTO Product (id_unit, id_category, id_supplier, product_code, name, image, quantity_in, quantity_out, coli_in, coli_out,
                            nett_price, margin, tax, discount, sell_price, information) 
                            VALUES (@id_unit, @id_category, @id_supplier, @product_code, @name, @image, @quantity_in, @quantity_out, @coli_in, @coli_out,
                            @nett_price, @margin, @tax, @discount, @sell_price, @information)";
                }
                else
                {
                    qry = @"UPDATE Product SET id_unit = @id_unit, id_category = @id_category, id_supplier = @id_supplier,  
                           product_code = @product_code, name = @name, image = @image, nett_price = @nett_price, margin = @margin,
                           tax = @tax, discount = @discount, sell_price = @sell_price, information = @information, date_updated = @date_updated 
                           WHERE id = @id";
                }
                ComboboxItem selectedUnit = (ComboboxItem)comboUnit.SelectedItem;
                ComboboxItem selectedCategory = (ComboboxItem)comboCategory.SelectedItem;
                ComboboxItem selectedSupplier = (ComboboxItem)comboSupplier.SelectedItem;

                Image temp = new Bitmap(pictProduct.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@id_unit", selectedUnit.Value);
                ht.Add("@id_category", selectedCategory.Value);
                ht.Add("@id_supplier", selectedSupplier.Value);
                ht.Add("@product_code", txtProductCode.Text);
                ht.Add("@name", txtName.Text);
                ht.Add("@image", imageByteArray);
                ht.Add("@quantity_in", 0);
                ht.Add("@quantity_out", 0);
                ht.Add("@coli_in", 0);
                ht.Add("@coli_out", 0);
                ht.Add("@nett_price", Convert.ToDecimal(txtNettPrice.Text));
                ht.Add("@margin", Convert.ToDecimal(txtMargin.Text));
                ht.Add("@tax", Convert.ToDecimal(txtTax.Text));
                ht.Add("@discount", Convert.ToDecimal(txtDiscount.Text));
                ht.Add("@sell_price", Convert.ToDecimal(txtSellPrice.Text));
                ht.Add("@information", txtInformation.Text);
                ht.Add("@date_updated", timer);


                try
                {
                    int result = SQL(qry, ht);
                    if (result > 0)
                    {
                        MessageBox.Show("Input Sucessfull", "POS System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        /*if (id == 0)
                        {
                            id = 0;
                            comboUnit.Text = "";
                            comboCategory.Text = "";
                            comboSupplier.Text = "";
                            txtProductCode.Text = "";
                            txtName.Text = "";
                            txtNettPrice.Text = "";
                            txtMargin.Text = "";
                            txtTax.Text = "";
                            txtDiscount.Text = "";
                            txtSellPrice.Text = "";
                            txtInformation.Text = "";
                            pictProduct.Image = Properties.Resources.product1;

                        }
                        else
                        {*/
                            this.Close();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "POS System", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
        }

        public override void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "images(.jpg, .png, .jpeg) | *.png; *.jpg; *.jpeg;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                pictProduct.Image = new Bitmap(filePath);
            }
        }

        public void LoadCBU()
        {
            string query = "SELECT ID, unit_code FROM Unit";

            SqlCommand cmd = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["ID"];
                string value = reader["unit_code"].ToString();
                comboUnit.Items.Add(new ComboboxItem { Text = value, Value = id });
            }
            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        public void LoadCBC()
        {
            string query = "SELECT ID, Name FROM Category";

            SqlCommand cmd = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["ID"];
                string value = reader["Name"].ToString();
                comboCategory.Items.Add(new ComboboxItem { Text = value, Value = id });
            }
            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        public void LoadCBS()
        {
            string query = "SELECT ID, Name FROM Supplier";

            SqlCommand cmd = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["ID"];
                string value = reader["Name"].ToString();
                comboSupplier.Items.Add(new ComboboxItem { Text = value, Value = id });
            }
            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (ValidateNegativeInput(txtDiscount))
            {
                Calculate();
            }
        }

        private void txtMargin_TextChanged(object sender, EventArgs e)
        {
            if (ValidateNegativeInput(txtMargin))
            {
                Calculate();
            }
        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            if (ValidateNegativeInput(txtTax))
            {
                Calculate();
            }
        }

        private void txtNettPrice_TextChanged(object sender, EventArgs e)
        {
            if (ValidateNegativeInput(txtNettPrice))
            {
                Calculate();
            }
        }

        private void Calculate()
        {
            if (decimal.TryParse(txtNettPrice.Text, out decimal nPrice) && nPrice > 0  &&
                decimal.TryParse(txtMargin.Text, out decimal margin) &&
                decimal.TryParse(txtTax.Text, out decimal tax) &&
                decimal.TryParse(txtDiscount.Text, out decimal discount))
            {
                decimal total = ((nPrice * (100 + margin) / 100) * (100 + tax) / 100) * (100 - discount) / 100;
                decimal diff = total - nPrice;

                if (diff < 0 && !itsOkay)
                {
                    DialogResult result = MessageBox.Show("You will lose " + diff.ToString("N2") + ". Are you sure?", "POS System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        itsOkay = true;
                        txtSellPrice.Text = total.ToString("N2");
                    }
                    else
                    {
                        txtDiscount.Text = "0";
                        decimal total2 = ((nPrice * (100 + margin) / 100) * (100 + tax) / 100);
                        txtSellPrice.Text = total2.ToString("N2");
                    }
                }
                else
                {
                    txtSellPrice.Text = total.ToString("N2");
                }

                if (total < 0)
                {
                    DialogResult result = MessageBox.Show("You cannot have a negative sell price.", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK || result == DialogResult.Cancel)
                    {
                        txtNettPrice.Text = "0";
                        txtMargin.Text = "0";
                        txtTax.Text = "0";
                        txtDiscount.Text = "0";
                        decimal total3 = 0;
                        txtSellPrice.Text = total3.ToString("N2");
                    }
                }

            }
            else
            {
                txtSellPrice.Text = "Invalid Input";
            }
        }

        private void lblSPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtSellPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUnit_Click(object sender, EventArgs e)
        {

        }

        private void comboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
