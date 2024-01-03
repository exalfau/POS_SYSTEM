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
    public partial class frmSupplierAdd : SampleAdd
    {
        public static ToolTip toolTip;
        string idS;
        public int id = 0;
        public int idRole = 0;
        public string gender;
        public string filePath = "";
        Byte[] imageByteArray;

        public frmSupplierAdd()
        {
            InitializeComponent();
        }

        private void frmSupplierAdd_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.inventory_color;
            if (id == 0)
            {
                lblHeader.Text = "Create Supplier details";
                lblClock.Text = "Created at " + timer.ToString("HH:mm");
                dateJoin.Value = DateTime.Today;
                txtSupplierID.Text = GenerateSupplierID();
            }
            else
            {
                lblHeader.Text = "Update Supplier details";
                lblClock.Text = "Updated at " + timer.ToString("HH:mm");
                pictProfile.Image = DataMethod.LoadImage("Supplier", id);
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
                    qry = @"INSERT INTO Supplier (supplier_id, name, image, join_date, phone, address, information) 
                            VALUES (@supplier_id, @name, @image, @join_date, @phone, @address, @information)";
                }
                else
                {
                    qry = @"UPDATE Supplier SET supplier_id = @supplier_id, name = @name, image = @image, 
                            phone = @phone, address = @address, information = @information, date_updated = @date_updated 
                            WHERE id = @id";
                }

                Image temp = new Bitmap(pictProfile.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@supplier_id", txtSupplierID.Text);
                ht.Add("@name", txtName.Text);
                ht.Add("@image", imageByteArray);
                ht.Add("@join_date", dateJoin.Value);
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
                            txtSupplierID.Text = "";
                            txtName.Text = "";
                            dateJoin.Value = DateTime.Now;
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
