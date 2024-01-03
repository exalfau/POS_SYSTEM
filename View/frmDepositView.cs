using POS_SYSTEM.Class;
using POS_SYSTEM.Model;
using POS_SYSTEM.ModelImport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class frmDepositView : SampleView
    {
        int create = 0, update = 0, delete = 0, export = 0, import = 0;
        public frmDepositView()
        {
            InitializeComponent();
        }

        private void frmDepositView_Load(object sender, EventArgs e)
        {
            ConfigData(dataDeposit);
            LoadData();
            Privilege();
            if (create == 0) { btnAddNew.Visible = false; }
            if (import == 0) { btnImport.Visible = false; }
        }

        private void Privilege()
        {
            string qry = @"SELECT [create], [update], [delete], [export], [import] FROM Privilege WHERE id_feature = 16 AND id_role = '" + ROLEID + "'";

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

        public override void btnAddNew_Click(object sender, EventArgs e)
        {
            BlurBackground(new frmDepositAdd());
            LoadData();
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedData(dataDeposit, "Customer_Deposit");
            LoadData();
        }

        public override void btnExport_Click(object sender, EventArgs e)
        {
            Exports(dataDeposit, 3);
        }

        public override void btnImport_Click(object sender, EventArgs e)
        {
            BlurBackground(new frmDepositImport());
            LoadData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvCustomerID);
            lb.Items.Add(dgvCustomer);
            lb.Items.Add(dgvDate);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvInvoiceID);
            lb.Items.Add(dgvAmount);
            lb.Items.Add(dgvTotal);
            lb.Items.Add(dgvInformation);
            string qry = @"SELECT cd.id, c.customer_id, c.name, CONVERT(VARCHAR(10),cd.date, 103) AS date, cd.type, t.invoice_id, cd.amount, cd.total, cd.information
                            FROM Customer_Deposit cd 
                            JOIN Customer c ON cd.id_customer = c.id
                            LEFT JOIN [Transaction] t ON cd.id_transaction = t.id    
                            WHERE c.name LIKE '%" + txtSearch.Text + "%' OR cd.type LIKE '%" + txtSearch.Text + "%' " +
                            "OR t.invoice_id LIKE '%" + txtSearch.Text + "%' OR CONVERT(VARCHAR(10),cd.date, 103) LIKE '%" + txtSearch.Text + "%'" +
                            "ORDER BY id desc";


            DataMethod.LoadData(qry, dataDeposit, lb);
        }

        private void dataDeposit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string type = Convert.ToString(dataDeposit.CurrentRow.Cells["dgvType"].Value);

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataDeposit.Columns[e.ColumnIndex].Name == "dgvEdit")
            {
                int id = Convert.ToInt32(dataDeposit.CurrentRow.Cells["dgvID"].Value);
                string CustomerID = Convert.ToString(dataDeposit.CurrentRow.Cells["dgvCustomerID"].Value);
                string  dateValue = Convert.ToString(dataDeposit.CurrentRow.Cells["dgvDate"].Value);
                DateTime depositDate;
                DateTime.TryParseExact(dateValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out depositDate);
                int amount = Convert.ToInt32(dataDeposit.CurrentRow.Cells["dgvAmount"].Value);
                string information = Convert.ToString(dataDeposit.CurrentRow.Cells["dgvInformation"].Value);

                frmDepositAdd depositAdd = new frmDepositAdd();
                depositAdd.id = id;
                depositAdd.LoadCB();
                depositAdd.comboCustomerID.Text = CustomerID;
                depositAdd.dateDeposit.Value = depositDate;
                depositAdd.txtAmount.Text = amount.ToString();
                depositAdd.txtInformation.Text = information;
                if (update == 0)
                {
                    MessageBox.Show("You do not have privilege to edit this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                BlurBackground(depositAdd);
                LoadData();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataDeposit.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                if (delete == 0)
                {
                    MessageBox.Show("You do not have privilege to delete this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if (type.Contains("payment"))
                {
                    MessageBox.Show("Data payment can not manually be deleted", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataMethod.DeleteColumn(dataDeposit, "Customer_Deposit");
                LoadData();
            }
        }

        private void dataDeposit_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataDeposit.Columns["dgvCheck"].Index)
            {
                foreach (DataGridViewRow row in dataDeposit.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["dgvCheck"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {
                        checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);
                    }
                }
            }
        }

        private void dataDeposit_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool rowChecked = CheckCheckedRow(dataDeposit);
            btnExport.Visible = rowChecked && export == 1;
            btnDelete.Visible = rowChecked && delete == 1;
        }
    }
}
