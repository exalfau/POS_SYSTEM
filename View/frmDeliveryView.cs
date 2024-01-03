using Microsoft.ReportingServices.Diagnostics.Internal;
using Microsoft.SqlServer.Management.Smo;
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
using System.Web.Security;
using System.Windows.Forms;
using static POS_SYSTEM.Class.CommonMethod;
using static POS_SYSTEM.Class.DataMethod;

namespace POS_SYSTEM.View
{
    public partial class frmDeliveryView : SampleView
    {
        int create = 0, update = 0, delete = 0, export = 0, import = 0;
        public frmDeliveryView()
        {
            InitializeComponent();
        }

        private void frmDeliveryView_Load(object sender, EventArgs e)
        {
            btnAddNew.Visible = false;
            btnDelete.Visible = false;
            btnImport.Visible = false;
            Privilege();
            LoadData();
        }

        private void Privilege()
        {
            string qry = @"SELECT [create], [update], [delete], [export], [import] FROM Privilege WHERE id_feature = 19 AND id_role = '" + ROLEID + "'";

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
            LoadData();
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public override void btnExport_Click(object sender, EventArgs e)
        {

        }

        public override void btnImport_Click(object sender, EventArgs e)
        {

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
            lb.Items.Add(dgvCourier);
            lb.Items.Add(dgvAddress);
            lb.Items.Add(dgvCost);
            lb.Items.Add(dgvDateDelivered);
            lb.Items.Add(dgvTimeDelivered);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvInformation);
            string qry = @"SELECT d.id, t.invoice_id, cs.name, s.name, d.address, d.cost, CONVERT(VARCHAR(10), d.date_delivered, 103) AS formatted_date, CONVERT(VARCHAR(5), d.time_delivered, 108) AS formatted_time, d.status, d.information
                            FROM Delivery d 
                            JOIN Customer cs ON d.id_customer = cs.id
                            JOIN Courier c ON d.id_courier = c.id
                            JOIN Staff s ON c.id_staff = s.id
                            JOIN [Transaction] t ON d.id_transaction = t.id    
                            WHERE cs.name LIKE '%" + txtSearch.Text + "%' OR d.status LIKE '%" + txtSearch.Text + "%' " +
                            "OR t.invoice_id LIKE '%" + txtSearch.Text + "%' OR s.name LIKE '%" + txtSearch.Text + "%'" +
                            "ORDER BY d.id desc";


            DataMethod.LoadData(qry, dataDelivery, lb);
        }

        private void dataDelivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataDelivery.Columns[e.ColumnIndex].Name == "dgvEdit")
            {
                int id = Convert.ToInt32(dataDelivery.CurrentRow.Cells["dgvID"].Value);
                string invoiceID = Convert.ToString(dataDelivery.CurrentRow.Cells["dgvInvoiceID"].Value);
                string cost = Convert.ToString(dataDelivery.CurrentRow.Cells["dgvCost"].Value);
                string customer = Convert.ToString(dataDelivery.CurrentRow.Cells["dgvCustomer"].Value);
                string courier = Convert.ToString(dataDelivery.CurrentRow.Cells["dgvCourier"].Value);
                string dateValue = Convert.ToString(dataDelivery.CurrentRow.Cells["dgvDateDelivered"].Value);
                DateTime dateDelivered;
                if (DateTime.TryParseExact(dateValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateDelivered) == false)
                {
                    dateDelivered = DateTime.Today;
                }
                string timeDelivered = Convert.ToString(dataDelivery.CurrentRow.Cells["dgvTimeDelivered"].Value);
                if (string.IsNullOrEmpty(timeDelivered))
                {
                    timeDelivered = DateTime.Now.ToString("HH:mm");
                }
                string status = Convert.ToString(dataDelivery.CurrentRow.Cells["dgvStatus"].Value);
                string information = Convert.ToString(dataDelivery.CurrentRow.Cells["dgvInformation"].Value);


                frmDeliveryAdd deliveryAdd = new frmDeliveryAdd();
                deliveryAdd.id = id;
                deliveryAdd.txtInvoiceID.Text = invoiceID;
                deliveryAdd.txtCustomer.Text = customer;
                deliveryAdd.txtCourier.Text = courier;
                deliveryAdd.txtCost.Text = cost;
                deliveryAdd.dateDelivered.Value = dateDelivered;
                deliveryAdd.txtTimeDelivered.Text = timeDelivered;
                deliveryAdd.txtInfo.Text = information;

                if (update == 0)
                {
                    MessageBox.Show("You do not have privilege to edit this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                BlurBackground(deliveryAdd);
                LoadData();
            }

        }
    }
}
