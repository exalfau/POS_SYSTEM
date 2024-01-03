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

namespace POS_SYSTEM.Model
{
    public partial class frmCustomerAdd : SampleAdd
    {
        public static ToolTip toolTip;
        public int id = 0;
        public int idRole = 0;
        public string gender;
        public string filePath = "";
        Byte[] imageByteArray;

        public frmCustomerAdd()
        {
            InitializeComponent();
        }

        private void frmCustomerAdd_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.community_color;
            if (id == 0)
            {
                lblHeader.Text = "Create Customer details";
                lblClock.Text = "Created at " + timer.ToString("HH:mm");
                dateJoin.Value = DateTime.Today;
                dateBirth.Value = DateTime.Today;
                txtCustomerID.Text = GenerateCusomerID();
            }
            else
            {
                lblHeader.Text = "Update Customer details";
                lblClock.Text = "Updated at " + timer.ToString("HH:mm");
                pictProfile.Image = DataMethod.LoadImage("Customer", id);
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation(this, id) == false)
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
                    qry = @"INSERT INTO Customer (customer_id, name, image, join_date, birth_date, gender, phone, address, information) 
                            VALUES (@customer_id, @name, @image, @join_date, @birth_date, @gender, @phone, @address, @information)";
                }
                else
                {
                    qry = @"UPDATE Customer SET customer_id = @customer_id, name = @name, image = @image, 
                            join_date = @join_date, birth_date = @birth_date, gender = @gender, phone = @phone, address = @address, information = @information, date_updated = @date_updated 
                            WHERE id = @id";
                }
                if (radioMale.Checked) { gender = "M"; } else { gender = "F"; }

                Image temp = new Bitmap(pictProfile.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@customer_id", txtCustomerID.Text);
                ht.Add("@name", txtName.Text);
                ht.Add("@image", imageByteArray);
                ht.Add("@join_date", dateJoin.Value);
                ht.Add("@birth_date", dateJoin.Value);
                ht.Add("@gender", gender);
                ht.Add("@phone", txtPhone.Text.Trim());
                ht.Add("@address", txtAddress.Text);
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
                            txtCustomerID.Text = "";
                            txtName.Text = "";
                            dateJoin.Value = DateTime.Now;
                            dateBirth.Value = DateTime.Now;
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
    }
}
