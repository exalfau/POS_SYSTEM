using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POS_SYSTEM.Class.CommonMethod;
using static POS_SYSTEM.Class.DataMethod;
using static POS_SYSTEM.Class.ValidationMethod;

namespace POS_SYSTEM.Model
{
    public partial class frmCourierAdd : SampleAdd
    {
        public int id = 0;

        public frmCourierAdd()
        {
            InitializeComponent();
        }

        private void frmCourierAdd_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.delivery_courier_color;
            if (id == 0)
            {
                lblHeader.Text = "Create Courier details";
                lblClock.Text = "Created at " + timer.ToString("HH:mm");
                LoadCB();
            }
            if (id > 0)
            {
                lblHeader.Text = "Update Courier details";
                lblClock.Text = "Updated at " + timer.ToString("HH:mm");
                LoadData();
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            ComboboxItem selectedStaffID = (ComboboxItem)comboStaffID.SelectedItem;

            if (Validation(this,id) == false)
            {
                return;
            }
            else
            {
                string qry = "";
                if (id == 0)
                {
                    string checkUserQuery = "SELECT COUNT(*) FROM Courier WHERE id_staff = '" + selectedStaffID.Value + "'";
                    int rowCount = Convert.ToInt32(SQLScalar(checkUserQuery));
                    if (rowCount > 0)
                    {
                        MessageBox.Show("Courier already exists. Please choose a different Staff ID.", "Input Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        qry = @"INSERT INTO Courier (id_staff, license_plate, information) VALUES (@id_staff, @license_plate, @information)";
                    }
                }
                else
                {
                    qry = @"UPDATE Courier SET id_staff = @id_staff, license_plate = @license_plate, information = @information, date_updated = @date_updated WHERE id = @id";
                }


                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@id_staff", selectedStaffID.Value);
                ht.Add("@license_plate", txtLicensePlate.Text.ToUpper());
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
                            comboStaffID.Text = "";
                            txtName.Text = "";
                            txtInformation.Text = "";
                            txtLicensePlate.Text = "";
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

        public void LoadCB()
        {

            string query = "SELECT id, staff_id FROM Staff";

            SqlCommand cmd = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["id"];
                string value = reader["staff_id"].ToString();
                comboStaffID.Items.Add(new  ComboboxItem { Text = value, Value = id });
            }
            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        private void comboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboStaffID.SelectedIndex != -1)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            string qry = @"SELECT name FROM Staff WHERE staff_id = '" + comboStaffID.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["name"].ToString();
            }
        }
    }
}
