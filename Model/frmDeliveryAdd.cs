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
    public partial class frmDeliveryAdd : SampleAdd
    {
        public int id = 0;
        public frmDeliveryAdd()
        {
            InitializeComponent();
        }

        private void frmDeliveryAdd_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.delivery_color;
            lblHeader.Text = "Update Delivery details";
            lblClock.Text = "Updated at " + timer.ToString("HH:mm");
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation(this, id) == false)
            {
                return;
            }
            else
            {

                string qry = @"UPDATE Delivery SET date_delivered = @date_delivered, time_delivered = @time_delivered, status = @status, information = @information
                            WHERE id = @id";

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@date_delivered", dateDelivered.Value);
                ht.Add("@time_delivered", Convert.ToDateTime(txtTimeDelivered.Text));
                ht.Add("@status", comboStatus.Text);
                ht.Add("@information", txtInfo.Text);

                try
                {
                    int result = SQL(qry, ht);
                    if (result > 0)
                    {
                        MessageBox.Show("Update Successful", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void dateDelivered_ValueChanged(object sender, EventArgs e)
        {
           /* DateTime selectedDateDelivered = dateDelivered.Value;
            DateTime date = dateSent.Value; // Assuming you have a dateSent control

            if (selectedDateDelivered < date)
            {
                ToolTip toolTip = new ToolTip();
                int yOffset = -toolTip.GetToolTip(dateDelivered).Length; // Adjust Y-coordinate based on tooltip length
                toolTip.Show("Date Delivered cannot be set before Date Sent.", dateDelivered, 0, yOffset, 5000); // Display tooltip for 5 seconds
                dateDelivered.Value = date;
            }*/
        }
    }
}
