using Microsoft.SqlServer.Management.Assessment.Probes;
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
using System.Data.SqlClient;
using System.Collections;
using System.IO;
using System.Xml.Linq;

namespace POS_SYSTEM.Model
{
    public partial class frmDepositAdd : SampleAdd
    {
        public int id = 0;
        public frmDepositAdd()
        {
            InitializeComponent();
        }

        private void frmDepositAdd_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.deposit_color;
            if (id == 0)
            {
                lblHeader.Text = "Create Deposit details";
                lblClock.Text = "Created at " + timer.ToString("HH:mm");
                dateDeposit.Value = DateTime.Today;
                LoadCB();

            }
            else
            {
                lblHeader.Text = "Update Deposit details";
                lblClock.Text = "Updated at " + timer.ToString("HH:mm");
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            ComboboxItem selectedCustomer = (ComboboxItem)comboCustomerID.SelectedItem;

            if (Validation(this, id) == false)
            {
                return;
            }

            if (selectedCustomer.Value == 1 )
            {
                MessageBox.Show("General Customers cannot make deposit", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string qry = "";
            if (id == 0)
            {
                qry = @"INSERT INTO Customer_Deposit ( id_customer, date, amount, type, information) 
                            VALUES ( @id_customer, @date, @amount, @type, @information)";
            }
            else
            {
                qry = @"UPDATE Customer_Deposit SET id_customer = @id_customer, date = @date, 
                            amount = @amount, type = @type, information = @information, date_updated = @date_updated 
                            WHERE id = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@id_customer", selectedCustomer.Value);
            ht.Add("@date", dateDeposit.Value);
            ht.Add("@amount", Convert.ToDecimal(txtAmount.Text));
            ht.Add("@type", "deposit");
            ht.Add("@information", txtInformation.Text);
            ht.Add("@date_updated", timer);


            try
            {
                int result = SQL(qry, ht);
                if (result > 0)
                {
                    MessageBox.Show("Input Sucessfull", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    /*if (id == 0)
                    {
                        id = 0;
                        comboCustomerID.Text = "";
                        txtName.Text = "";
                        dateDeposit.Value = DateTime.Now;
                        txtAmount.Text = "";
                        txtInformation.Text = "";
                    }
                    else
                    {*/
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "POS System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void comboCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCustomerID.SelectedIndex != -1)
            {
                LoadData();
            }
        }


        private void LoadData()
        {
            string qry = @"SELECT name FROM Customer WHERE customer_id = '" + comboCustomerID.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["name"].ToString();
            }
        }

        public void LoadCB()
        {
            string query = "SELECT ID, customer_id FROM Customer";

            SqlCommand cmd = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["ID"];
                string value = reader["customer_id"].ToString();
                comboCustomerID.Items.Add(new ComboboxItem { Text = value, Value = id });
            }
            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            ValidateNegativeInput(txtAmount);
        }
    }
}
