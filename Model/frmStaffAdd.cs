using POS_SYSTEM.Class;
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
using ToolTip = System.Windows.Forms.ToolTip;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static POS_SYSTEM.Class.DataMethod;
using static POS_SYSTEM.Class.ValidationMethod;
using static POS_SYSTEM.Class.CommonMethod;
using System.Data.SqlClient;

namespace POS_SYSTEM.Model
{
    public partial class frmStaffAdd : SampleAdd
    {
        public static ToolTip toolTip;
        string idS;
        public int id = 0;
        public int idRole = 0;
        public string gender;
        public string filePath = "";
        Byte[] imageByteArray;
        public frmStaffAdd()
        {
            InitializeComponent();
        }

        private void frmStaffAdd_Load(object sender, EventArgs e)
        {
             pictLogo.Image = Properties.Resources.team_color;
            if (id == 0)
            {
                lblHeader.Text = "Create Staff details";
                lblClock.Text = "Created at " + timer.ToString("HH:mm");
                dateJoin.Value = DateTime.Today;
                LoadCB();                

            }else
            {
                comboRole.SelectedValue = idRole;
                lblHeader.Text = "Update Staff details";
                lblClock.Text = "Updated at " + timer.ToString("HH:mm");
                idS = txtStaffID.Text.Substring(8);
                pictProfile.Image = LoadImage("Staff", id);
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation(this,id) == false)
            {
                return;
            }
            else if (!radioMale.Checked && !radioFemale.Checked)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Show("Select either option.", radioMale, 0, radioMale.Height + 5, 5000); // Display tooltip for 5 seconds
                return;
            }
            else
            {
                string qry = "";
                if (id == 0)
                {
                    qry = @"INSERT INTO Staff (staff_id, id_role, name, image, join_date, gender, phone, address, information) 
                            VALUES (@staff_id, @id_role, @name, @image, @join_date, @gender, @phone, @address, @information)";
                }
                else
                {
                    qry = @"UPDATE Staff SET staff_id = @staff_id, id_role = @id_role, name = @name, image = @image, 
                            join_date = @join_date, gender = @gender, phone = @phone, address = @address, information = @information, date_updated = @date_updated 
                            WHERE id = @id";
                }
               ComboboxItem selectedRole = (ComboboxItem)comboRole.SelectedItem;
                if (radioMale.Checked) { gender = "M"; } else { gender = "F"; }

                Image temp = new Bitmap(pictProfile.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@staff_id", txtStaffID.Text);
                ht.Add("@id_role", selectedRole.Value);
                ht.Add("@name", txtName.Text);
                ht.Add("@image", imageByteArray);
                ht.Add("@join_date", dateJoin.Value);
                ht.Add("@gender", gender);
                ht.Add("@phone", txtPhone.Text.Trim());
                ht.Add("@address", txtAddress.Text);
                ht.Add("@information", txtInformation.Text);
                ht.Add("@date_updated", timer);


                try
                {
                    int result =SQL(qry, ht);
                    if (result > 0)
                    {
                        MessageBox.Show("Input Sucessfull", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        /*if (id == 0)
                        {
                            id = 0;
                            txtStaffID.Text = "";
                            comboRole.Text = "";
                            txtName.Text = "";
                            dateJoin.Value = DateTime.Now;
                            radioFemale.Checked = false;
                            radioMale.Checked = false;
                            txtPhone.Text = "";
                            txtAddress.Text = "";
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


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "images(.jpg, .png) | *.png; *.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                pictProfile.Image = new Bitmap(filePath);
            }
        }

        private void comboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem selectedRole = (ComboboxItem)comboRole.SelectedItem;
            if (id == 0)
            {
                int roleID = Convert.ToInt32(selectedRole.Value);
                txtStaffID.Text = GenerateStaffID(roleID, comboRole.Text);
            }
            else
            {
                txtStaffID.Text = "";
                txtStaffID.Text = GetRole(comboRole.Text) + "-"  + selectedRole.Value.ToString("D3") +"-"+ idS;
            }
        }

        public void LoadCB()
        {
            string query = "SELECT ID, Name FROM Role";

            SqlCommand cmd = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["ID"];
                string value = reader["Name"].ToString();
                comboRole.Items.Add(new ComboboxItem { Text = value, Value = id });
            }
            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }
    }
}
