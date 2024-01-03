using POS_SYSTEM.Class;
using System;
using System.Collections;
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
using static POS_SYSTEM.Class.CommonMethod;
using static POS_SYSTEM.Class.DataMethod;
using static POS_SYSTEM.Class.ValidationMethod;


namespace POS_SYSTEM.Model
{
    public partial class frmUserAdd : SampleAdd
    {
        public int id = 0;
        public string originalUsername;

        public frmUserAdd()
        {
            InitializeComponent();
        }

        private void frmUserAdd_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.user_color;
            if (id == 0)
            {
                lblHeader.Text = "Create User details";
                lblClock.Text = "Created at " +  timer.ToString("HH:mm");
                LoadCB();
            }
            if (id > 0)
            {
                if (txtNewPassword.Visible == true)
                {
                    txtPassword.Enabled = true;
                }
                else
                {
                    txtPassword.Enabled = false;
                    txtPassword.Tag = "";
                }
                originalUsername = txtUsername.Text;
                lblHeader.Text = "Update User details";
                lblClock.Text = "Updated at " + timer.ToString("HH:mm");
                comboStaffID.Enabled = false;
                btnGP.Visible = false;
                LoadData();
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            ComboboxItem selectedStaffID = (ComboboxItem)comboStaffID.SelectedItem;
            string hashedPassword1 = ComputeSHA384Hash(txtPassword.Text);
            string hashedPassword2 = ComputeSHA384Hash(txtNewPassword.Text);

            if (Validation(this, id) == false)
            {
                return;
            }
            else
            {
                string qry = "";
                if (id == 0)
                {

                    string checkUserQuery1 = "SELECT COUNT(*) FROM Account WHERE id_staff  = '" + selectedStaffID.Value + "'";
                    int rowCount1 = Convert.ToInt32(SQLScalar(checkUserQuery1));

                    if (rowCount1 > 0)
                    {
                        MessageBox.Show("Account already exists. Please choose a different Staff ID.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string checkUserQuery2 = "SELECT COUNT(*) FROM Account WHERE username  = '" + txtUsername.Text + "'";
                    int rowCount2 = Convert.ToInt32(SQLScalar(checkUserQuery2));

                    if (rowCount2 > 0)
                    {
                        MessageBox.Show("Account already exists. Please choose a different username.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    qry = @"INSERT INTO Account (id_staff, username, password, information) VALUES (@id_staff, @username, @password, @information)";
                }
                else
                {
                    if (txtUsername.Text != originalUsername) // Assuming originalUsername is the current username in the database
                    {
                        string checkUserQuery2 = "SELECT COUNT(*) FROM Account WHERE username  = '" + txtUsername.Text + "'";
                        int rowCount2 = Convert.ToInt32(SQLScalar(checkUserQuery2));

                        if (rowCount2 > 0)
                        {
                            MessageBox.Show("Account already exists. Please choose a different username.", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (txtNewPassword.Visible == true)
                    {
                        string checkUserQuery = "SELECT COUNT(*) FROM Account WHERE password  = '" + hashedPassword1 + "'";
                        int rowCount = Convert.ToInt32(SQLScalar(checkUserQuery));
                        if (rowCount == 0)
                        {
                            MessageBox.Show("Old password does not match, please try again", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    qry = @"UPDATE Account SET username = @username, information = @information,  date_updated = @date_updated ";

                    if (txtNewPassword.Visible == true)
                    {
                        qry += ", password = @password";
                    }

                    qry += " WHERE id = @id";

                }

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@id_staff", selectedStaffID.Value);
                ht.Add("@username", txtUsername.Text);
                if (txtNewPassword.Visible == true )
                {
                    ht.Add("@password", hashedPassword2);
                }else if (id == 0)
                {
                    ht.Add("@password", hashedPassword1);
                }
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
                            txtUsername.Text = "";
                            txtName.Text = "";
                            txtPassword.Text = "";
                            txtInformation.Text = "";
                            pictProfile.Image = Properties.Resources.businessman_color;

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

        private void pictShow_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            txtPassword.Focus();
            pictHide.Visible = true;
            pictShow.Visible = false;
        }

        private void pictHide_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●';
            txtPassword.Focus();
            pictHide.Visible = false;
            pictShow.Visible = true;
        }

        private void pictShowNew_Click(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = '\0';
            txtNewPassword.Focus();
            pictHideNew.Visible = true;
            pictShowNew.Visible = false;
        }

        private void pictHideNew_Click(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = '●';
            txtNewPassword.Focus();
            pictHideNew.Visible = false;
            pictShowNew.Visible = true;
        }

        public void LoadCB()
        {
            string query = "SELECT id, staff_id FROM Staff";

            SqlCommand cmd = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["ID"];
                string value = reader["staff_id"].ToString();
                comboStaffID.Items.Add(new CommonMethod.ComboboxItem { Text = value, Value = id });
            }
            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        private void btnGP_Click(object sender, EventArgs e)
        {
            txtPassword.Text = PasswordGenerator.GeneratePassword(10);
        }

        private void btnGenerateNewPassword_Click(object sender, EventArgs e)
        {
            txtNewPassword.Text = PasswordGenerator.GeneratePassword(10);
        }

        public void comboStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboStaffID.SelectedIndex != -1)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            string qry = @"SELECT name, image FROM Staff WHERE staff_id = '" + comboStaffID.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Byte[] imageArray = (byte[])dt.Rows[0]["image"];
                byte[] imageByteArray = imageArray;
                pictProfile.Image = Image.FromStream(new MemoryStream(imageArray));
                txtName.Text = dt.Rows[0]["name"].ToString();
            }
        }

    }
}
