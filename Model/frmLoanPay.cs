using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POS_SYSTEM.Class.DataMethod;
using static POS_SYSTEM.Class.ValidationMethod;
using static POS_SYSTEM.Class.CommonMethod;
using System.Collections;
using System.Xml.Linq;

namespace POS_SYSTEM.Model
{
    public partial class frmLoanPay : SampleAdd
    {
        public int id = 0;
        public frmLoanPay()
        {
            InitializeComponent();
        }

        private void frmLoanPay_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.funding_color;
            lblHeader.Text = "Update Instalment details";
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

                string qry = @"UPDATE Customer_Credit  SET status = @status, date_paid = @date_paid, information = @information, date_updated = @date_updated 
                            WHERE id = @id";

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@status", comboStatus.Text);
                ht.Add("@date_paid", datePaid.Value);
                ht.Add("@information", txtInfo.Text);
                ht.Add("@date_updated", timer);

                try
                {
                    int result = SQL(qry, ht);
                    if (result > 0)
                    {
                        MessageBox.Show("Payment Successful", "POS System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
