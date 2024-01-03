using Aspose.Words.Fields;
using Microsoft.IdentityModel.Protocols;
using POS_SYSTEM.Class;
using POS_SYSTEM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition.Primitives;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POS_SYSTEM.Class.CommonMethod;
using static POS_SYSTEM.Class.DataMethod;

namespace POS_SYSTEM.View
{
    public partial class frmLoanView : SampleView
    {
        int create = 0, update = 0, delete = 0, export = 0, import = 0;
        int index;
        public frmLoanView()
        {
            InitializeComponent();
        }

        private void frmLoanView_Load(object sender, EventArgs e)
        {
            btnAddNew.Visible = false;
            btnDelete.Visible = false;
            btnImport.Visible = false;
            LoadData();
            Privilege();
        }
        public override void btnExport_Click(object sender, EventArgs e)
        {
            Exports(dataLoan, 3);

        }

        private void Privilege()
        {
            string qry = @"SELECT [create], [update], [delete], [export], [import] FROM Privilege WHERE id_feature = 15 AND id_role = '" + ROLEID + "'";

            SqlCommand cmd = new SqlCommand(qry, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                create = Convert.ToInt32(dt.Rows[0]["create"]);
                update = Convert.ToInt32(dt.Rows[0]["update"]);
                delete = Convert.ToInt32(dt.Rows[0]["delete"]);
                export = Convert.ToInt32(dt.Rows[0]["export"]);
                import = Convert.ToInt32(dt.Rows[0]["import"]);
            }
        }

        private void dataLoan_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataLoan.Columns["dgvCheck"].Index)
            {
                foreach (DataGridViewRow row in dataLoan.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["dgvCheck"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {
                        checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);
                    }
                }
            }
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvInvoiceID);
            lb.Items.Add(dgvCustomer);
            lb.Items.Add(dgvAmount);
            lb.Items.Add(dgvDue);
            lb.Items.Add(dgvDatePaid);
            lb.Items.Add(dgvInstalment);
            lb.Items.Add(dgvStatus);
            string qry = @"SELECT cc.id, t.invoice_id, c.name, cc.amount, 
                           CONVERT(NVARCHAR(10), cc.due, 103) AS due,  CONVERT(NVARCHAR(10), cc.date_paid, 103) AS date_paid, cc.instalment, cc.status
                           FROM Customer_Credit cc 
                           JOIN [Transaction] t ON cc.id_transaction = t.id
                           JOIN Customer c ON cc.id_customer = c.id
                           WHERE c.name LIKE '%" + txtSearch.Text + "%' OR cc.status LIKE '%" + txtSearch.Text + "%' " +
                           "OR t.invoice_id LIKE '%" + txtSearch.Text + "%' OR CONVERT(NVARCHAR(10), cc.due, 103) LIKE '%" + txtSearch.Text + "%' OR CONVERT(NVARCHAR(10), cc.date_paid, 103) LIKE '%" + txtSearch.Text + "%'" +
                           "ORDER BY id ASC";


            DataMethod.LoadData(qry, dataLoan, lb);
        }

        private void dataLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataLoan.Columns[e.ColumnIndex].Name == "dgvPay")
            {
                int id = Convert.ToInt32(dataLoan.CurrentRow.Cells["dgvID"].Value);
                string invoiceID = Convert.ToString(dataLoan.CurrentRow.Cells["dgvInvoiceID"].Value);
                string customerID = Convert.ToString(dataLoan.CurrentRow.Cells["dgvCustomer"].Value);
                string dueDate = Convert.ToString(dataLoan.CurrentRow.Cells["dgvDue"].Value);
                decimal amount = Convert.ToDecimal(dataLoan.CurrentRow.Cells["dgvAmount"].Value);
                string instalment = Convert.ToString(dataLoan.CurrentRow.Cells["dgvInstalment"].Value);
                string status = Convert.ToString( dataLoan.CurrentRow.Cells["dgvStatus"].Value);
                frmLoanPay loanPay = new frmLoanPay();
                loanPay.id = id;
                loanPay.txtInvoiceID.Text = invoiceID;
                loanPay.txtCustomer.Text = customerID;
                loanPay.txtAmount.Text = amount.ToString();
                loanPay.txtDue.Text = dueDate;
                loanPay.txtInstalment.Text = instalment;
                if (update == 0)
                {
                    MessageBox.Show("You do not have privilege to edit this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if (status.Contains("paid"))
                {
                    index = 0;
                }
                else if (status.Contains("pending"))
                {
                    index = 1;
                }
                loanPay.comboStatus.SelectedIndex = index;                
                BlurBackground(loanPay);
                LoadData();
            }
        }

        private void dataLoan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool rowChecked = CheckCheckedRow(dataLoan);
            btnExport.Visible = rowChecked && export == 1;
        }
    }
}
