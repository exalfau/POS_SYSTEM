using POS_SYSTEM.Class;
using POS_SYSTEM.Model;
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
using static POS_SYSTEM.Class.CommonMethod;
using static POS_SYSTEM.Class.DataMethod;
using Dapper;
using Microsoft.Reporting.WinForms;
using System.Globalization;
using System.ComponentModel.Composition.Primitives;
using Microsoft.ReportingServices.Interfaces;

namespace POS_SYSTEM.View
{
    public partial class frmSaleview : SampleView
    {
        int create = 0, update = 0, delete = 0, export = 0, import = 0;
        public frmSaleview()
        {
            InitializeComponent();
            btnImport.Visible = false;
        }

        private void frmSaleview_Load(object sender, EventArgs e)
        {
            ConfigData(dataSales);
            LoadData();
            Privilege();
            if (create == 0) { btnAddNew.Visible = false; }
            if (import == 0) { btnImport.Visible = false; }
        }

        private void Privilege()
        {
            string qry = @"SELECT [create], [update], [delete], [export], [import] FROM Privilege WHERE id_feature = 18 AND id_role = '" + ROLEID + "'";

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
            BlurBackground(new frmSaleAdd());
            LoadData();
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedDataSales(dataSales, "Sales_Detail", "[Transaction]");
            LoadData();
        }

        public override void btnExport_Click(object sender, EventArgs e)
        {
            Exports(dataSales, 4);
        }

        public override void btnImport_Click(object sender, EventArgs e)
        {

        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public class InvoiceData
        {
            public int ID { get; set; }
            public string InvoiceID { get; set; }
            public string Customer { get; set; }
            public string Staff { get; set; }
            public DateTime Date { get; set; }
            public TimeSpan Time { get; set; }
            public string Products { get; set; }
            public string Quantities { get; set; }
            public string Prices { get; set; }
            public decimal TotalPrice { get; set; }
            public string PaymentType { get; set; }
            public string ShippingType { get; set; }
            public string Information { get; set; }
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvInvoiceID);
            lb.Items.Add(dgvCustomer);
            lb.Items.Add(dgvStaff);
            lb.Items.Add(dgvDate);
            lb.Items.Add(dgvTime);
            lb.Items.Add(dgvProduct);
            lb.Items.Add(dgvQty);
            lb.Items.Add(dgvNettPrice);
            lb.Items.Add(dgvTotalPrice);
            lb.Items.Add(dgvPayment);
            lb.Items.Add(dgvShipping);
            lb.Items.Add(dgvInformation);

            string qry = @"SELECT t.id, t.invoice_id, c.name, s.name, 
                            CONVERT(VARCHAR(10), t.date, 103) AS formatted_date, 
                            CONVERT(VARCHAR(5), t.time, 108) AS formatted_time,  
                    STUFF((SELECT ', ' + p.name 
                           FROM Sales_Detail sd
                           JOIN Product p ON sd.id_product = p.id
                           WHERE sd.id_transaction = t.id
                           FOR XML PATH('')), 1, 2, '') AS products_name,
                    STUFF((SELECT ', ' + CONVERT(VARCHAR(10), sd.quantity)
                           FROM Sales_Detail sd
                           WHERE sd.id_transaction = t.id
                           FOR XML PATH('')), 1, 2, '') AS quantities,
                    STUFF((SELECT ', ' + CONVERT(VARCHAR(10), sd.price)
                           FROM Sales_Detail sd
                           WHERE sd.id_transaction = t.id
                           FOR XML PATH('')), 1, 2, '') AS price,
                    SUM(sd.total_price) AS total_price, t.payment_type, t.shipping_type, t.information
                FROM [Transaction] t 
                JOIN Sales_Detail sd ON sd.id_transaction = t.id
                JOIN Customer c ON sd.id_customer = c.id 
                JOIN Staff s ON sd.id_staff = s.id 
                JOIN Product p ON sd.id_product = p.id 
                WHERE t.type = 'sales' AND (s.name LIKE '%" + txtSearch.Text + "%' OR t.invoice_id LIKE '%" + txtSearch.Text + "%' OR c.name LIKE '%" + txtSearch.Text + "%'" +
                " OR CONVERT(VARCHAR(10), t.date, 103) LIKE '%" + txtSearch.Text + "%' OR CONVERT(VARCHAR(5), t.time, 108) LIKE '%" + txtSearch.Text + "%')" +
                "GROUP BY t.id, t.invoice_id, c.name, s.name, t.date, t.time, t.payment_type, t.shipping_type, t.information " +
                "ORDER BY id desc";

            DataMethod.LoadData(qry, dataSales, lb);

        }

        private void dataSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataSales.Columns[e.ColumnIndex].Name == "dgvPrint")
            {
                
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataSales.Columns[e.ColumnIndex].Name == "dgvEdit")
            {
                int id = Convert.ToInt32(dataSales.CurrentRow.Cells["dgvID"].Value);
                string  dateValue = Convert.ToString(dataSales.CurrentRow.Cells["dgvDate"].Value);
                DateTime dateSales;
                DateTime.TryParseExact(dateValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateSales);
                string timeSales = Convert.ToString(dataSales.CurrentRow.Cells["dgvTime"].Value);
                string information = Convert.ToString(dataSales.CurrentRow.Cells["dgvInformation"].Value);
                string supplier = Convert.ToString(dataSales.CurrentRow.Cells["dgvCustomer"].Value);
                int status = Convert.ToInt32(dataSales.CurrentRow.Cells["dgvConfirmValue"].Value);
                frmSaleAdd SalesAdd = new frmSaleAdd();
                SalesAdd.LoadCB();
                SalesAdd.comboCustomer.Text = supplier;
                SalesAdd.dateSales.Value = dateSales;
                SalesAdd.txtTimeSales.Text = timeSales;
                SalesAdd.Tid = id;
                SalesAdd.txtInfoTransaction.Text = information;
                if (update == 0)
                {
                    MessageBox.Show("You do not have privilege to edit this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                LoadData();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataSales.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                if (delete == 0)
                {
                    MessageBox.Show("You do not have privilege to delete this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                DeleteColumnSales(dataSales, "Sales_Detail", "[Transaction]");
                LoadData();
            }
        }

        private void dataSales_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataSales.Columns["dgvCheck"].Index)
            {
                foreach (DataGridViewRow row in dataSales.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["dgvCheck"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {
                        checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);
                    }
                }
            }
        }

        private void dataSales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool rowChecked = CheckCheckedRow(dataSales);
            btnExport.Visible = rowChecked && export == 1;
            btnDelete.Visible = rowChecked && delete == 1;
        }

        private void dataSales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataSales.Columns["dgvConfirm"].Index && e.RowIndex >= 0)
            {
                object confirmValue = dataSales.Rows[e.RowIndex].Cells["dgvConfirmValue"].Value;

                if (confirmValue != null && confirmValue.ToString() == "1")
                {
                    e.Value = true;
                }
                else
                {
                    e.Value = false;
                }

                e.FormattingApplied = true;
            }
        }
    }
}
