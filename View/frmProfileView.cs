using Microsoft.Office.Interop.Excel;
using Microsoft.SqlServer.Management.Smo;
using POS_SYSTEM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POS_SYSTEM.Class.DataMethod;
using static POS_SYSTEM.Class.CommonMethod;
using DataTable = System.Data.DataTable;
using static POS_SYSTEM.Class.ValidationMethod;
using System.Collections;
using POS_SYSTEM.Class;
using ListBox = System.Windows.Forms.ListBox;

namespace POS_SYSTEM.View
{
    public partial class frmProfileView : Sample
    {
        public string name;
        public int sId;
        public int aId;
        public string gender;
        public DateTime joinDate;
        public frmProfileView()
        {
            InitializeComponent();
        }

        private void frmProfileView_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataSale();
        }

        public void LoadData()
        {
            string qry = @"SELECT s.id, s.staff_id, r.name as ROLE, s.name, s.image, s.join_date, s.gender, s.phone, s.address, s.information,
                           a.id AS ACCOUNTID, a.username, a.information as INFOACCOUNT
                           FROM Staff s
                           INNER JOIN Role r ON s.id_role = r.id
                           INNER JOIN Account a ON s.id = a.id_staff
                           WHERE s.id = '" + ID + "'";

            SqlCommand cmd = new SqlCommand(qry, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                sId = Convert.ToInt32( dt.Rows[0]["id"]);
                aId = Convert.ToInt32(dt.Rows[0]["ACCOUNTID"]);
                lblStaffIDText.Text = dt.Rows[0]["staff_id"].ToString();
                lblRoleText.Text = dt.Rows[0]["ROLE"].ToString();
                lblNameText.Text = dt.Rows[0]["name"].ToString();
                Byte[] imageArray = (byte[])dt.Rows[0]["image"];
                byte[] imageByteArray = imageArray;
                pictProfile.Image = Image.FromStream(new MemoryStream(imageArray));
                joinDate = Convert.ToDateTime( dt.Rows[0]["join_date"]);
                lblJoinDateText.Text = joinDate.ToString("MM/dd/yy");
                if (dt.Rows[0]["gender"].ToString() == "M")
                {
                    gender = "Male";
                } else if (dt.Rows[0]["gender"].ToString() == "F")
                {
                    gender = "Female";
                }
                lblGenderText.Text = gender;
                lblPhoneText.Text = dt.Rows[0]["phone"].ToString();
                lblAddressText.Text = dt.Rows[0]["address"].ToString();
                lblInfoText.Text = dt.Rows[0]["information"].ToString();
                lblUsernameText.Text = dt.Rows[0]["username"].ToString();
                lblInfoAcountText.Text = dt.Rows[0]["INFOACCOUNT"].ToString();
            }
        }

        private void LoadDataSale()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvInvoiceID);
            lb.Items.Add(dgvDateSale);
            lb.Items.Add(dgvStaff);
            lb.Items.Add(dgvCustomer);
            lb.Items.Add(dgvProduct);
            lb.Items.Add(dgvQty);
            lb.Items.Add(dgvUnitPrice);
            lb.Items.Add(dgvTotalPrice);
            lb.Items.Add(dgvInformation);
            string qry = @"SELECT sd.id, t.invoice_id, t.date,  s.name, c.name,  p.name, sd.quantity, sd.price, sd.total_price, t.information
                            FROM Sales_Detail sd 
                            JOIN [Transaction] t ON sd.id_transaction = t.id
                            JOIN Staff s ON sd.id_staff = s.id
                            JOIN Customer c ON sd.id_customer = c.id
                            JOIN Product p ON sd.id_product = p.id
                            JOIN Account a ON s.id = a.id_staff
                            WHERE a.username = '" + USERNAME + "' AND (c.name LIKE '%" + txtSearch.Text + "%' OR p.name LIKE '%" + txtSearch.Text + "%' " +
                           "OR t.invoice_id LIKE '%" + txtSearch.Text + "%' OR t.date LIKE '%" + txtSearch.Text + "%')" +
                           "ORDER BY sd.id desc";


            DataMethod.LoadData(qry, dataStaff, lb);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmStaffAdd staffAdd = new frmStaffAdd();
            staffAdd.LoadCB();
            staffAdd.comboRole.Text = role;
            staffAdd.comboRole.Enabled = false;
            staffAdd.id = sId;
            staffAdd.txtStaffID.Text = lblStaffIDText.Text;
            if (gender == "Male") { staffAdd.radioMale.Checked = true; } else { staffAdd.radioFemale.Checked = true; }
            staffAdd.txtName.Text = lblNameText.Text;
            staffAdd.dateJoin.Value = joinDate;
            staffAdd.dateJoin.Enabled = false;
            staffAdd.txtPhone.Text = lblPhoneText.Text.TrimEnd();
            staffAdd.txtAddress.Text = lblAddressText.Text;
            staffAdd.txtInformation.Text = lblInfoText.Text;
            BlurBackground(staffAdd);
            LoadData();
        }

        private void btnEditAcount_Click(object sender, EventArgs e)
        {
            frmUserAdd userAdd = new frmUserAdd();
            userAdd.LoadCB();
            userAdd.id = aId;
            userAdd.comboStaffID.Text = lblStaffIDText.Text;
            userAdd.txtUsername.Text = lblUsernameText.Text;
            userAdd.txtInformation.Text = lblInfoAcountText.Text;
            userAdd.btnGP.Visible = false;
            userAdd.btnGenerateNewPassword.Visible = true;
            userAdd.lblPassword.Text = "Old Password";
            userAdd.txtNewPassword.Visible = true;
            userAdd.lblNewPassword.Visible = true;
            userAdd.pictShowNew.Visible = true;
            userAdd.comboStaffID.Enabled = false;
            userAdd.comboStaffID.Tag = "";
            userAdd.txtNewPassword.Tag = "pass";

            BlurBackground(userAdd);
            LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnEditAcount.Visible = true;
            btnPrevious.Visible = true;
            btnNext.Visible = false;
            panelGT.Visible = false;
            panelAccount.Visible = true;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnEditAcount.Visible = false;
            btnPrevious.Visible = false;
            btnNext.Visible = true;
            panelGT.Visible = true;
            panelAccount.Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataSale();
        }
    }
}
