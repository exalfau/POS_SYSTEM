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

namespace POS_SYSTEM.Model
{
    public partial class frmCategoryAdd : SampleAdd
    {
        public int id = 0;

        public frmCategoryAdd()
        {
            InitializeComponent();
        }

        private void frmCategoryAdd_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.package_color;
            if (id == 0)
            {
                lblHeader.Text = "Create Category details";
                lblClock.Text = "Created at " + timer.ToString("HH:mm");
            }
            if (id > 0)
            {
                lblHeader.Text = "Update Category details";
                lblClock.Text = "Updated at " + timer.ToString("HH:mm");
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation(this,id) == false)
            {
                return;
            }
            else
            {
                string qry = "";
                if (id == 0)
                {
                    qry = @"INSERT INTO Category ( name, category_code, information) VALUES (@name, @Category_code, @information)";
                }
                else
                {
                    qry = @"UPDATE Category SET name = @name, category_code = @category_code, information = @information, date_updated = @date_updated WHERE id = @id";
                }

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@name", txtName.Text);
                ht.Add("@Category_code", txtCode.Text);
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
                            txtName.Text = "";
                            txtCode.Text = "";
                            txtInformation.Text = "";
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

    }
}
