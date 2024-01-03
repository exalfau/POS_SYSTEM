using POS_SYSTEM.Class;
using POS_SYSTEM.Model;
using POS_SYSTEM.ModelImport;
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
    public partial class frmStockOutView : SampleView
    {
        int create = 0, update = 0, delete = 0, export = 0, import = 0;
        public frmStockOutView()
        {
            InitializeComponent();
        }

        private void frmStockOutView_Load(object sender, EventArgs e)
        {

            ConfigData(dataStockOut);
            LoadData();
            Privilege();
            if (create == 0) { btnAddNew.Visible = false; }
            if (import == 0) { btnImport.Visible = false; }
        }

        private void Privilege()
        {
            string qry = @"SELECT [create], [update], [delete], [export], [import] FROM Privilege WHERE id_feature = 12 AND id_role = '" + ROLEID + "'";

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
            BlurBackground(new frmStockOutAdd());
            LoadData();
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedDataOut(dataStockOut, "Stock_Out", "[Transaction]");
            LoadData();
        }

        public override void btnExport_Click(object sender, EventArgs e)
        {
            Exports(dataStockOut, 7);
        }

        public override void btnImport_Click(object sender, EventArgs e)
        {
            BlurBackground(new frmStockOutImport());
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
            lb.Items.Add(dgvIDStockOut);
            lb.Items.Add(dgvConfirmValue);
            lb.Items.Add(dgvSupplier);
            lb.Items.Add(dgvDate);
            lb.Items.Add(dgvTime);
            lb.Items.Add(dgvProduct);
            lb.Items.Add(dgvQty);
            lb.Items.Add(dgvColi);
            lb.Items.Add(dgvNettPrice);
            lb.Items.Add(dgvTotalPrice);
            lb.Items.Add(dgvCause);
            lb.Items.Add(dgvInformation);
            string qry = @"SELECT t.id, so.id as SOID, t.confirm, s.name,  CONVERT(VARCHAR(10),t.date, 103) AS date, CONVERT(VARCHAR(5), t.time, 108) AS time, p.name, so.quantity, so.coli, so.price, 
                            so.total_price, so.cause, t.information
                            FROM [Transaction] t 
                            JOIN Stock_Out so ON so.id_transaction = t.id
                            JOIN Supplier s ON so.id_supplier = s.id 
                            JOIN Product p ON so.id_product = p.id 
                            WHERE t.type = 'stock_Out'AND (s.name LIKE '%" + txtSearch.Text + "%' OR p.name LIKE'%" + txtSearch.Text + "%' " +
                            "OR CONVERT(VARCHAR(10),t.date, 103) LIKE '%"+txtSearch.Text+ "%' or CONVERT(VARCHAR(5), t.time, 108) LIKE '%"+txtSearch.Text+ "%') " +
                           "ORDER BY id desc";
            DataMethod.LoadData(qry, dataStockOut, lb);
        }

        private void dataStockOut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataStockOut.Columns[e.ColumnIndex].Name == "dgvEdit")
            {
                int id = Convert.ToInt32(dataStockOut.CurrentRow.Cells["dgvID"].Value);
                int SOid = Convert.ToInt32(dataStockOut.CurrentRow.Cells["dgvID"].Value);
                string supplier = Convert.ToString(dataStockOut.CurrentRow.Cells["dgvSupplier"].Value);
                string product = Convert.ToString(dataStockOut.CurrentRow.Cells["dgvProduct"].Value);
                string dateValue = Convert.ToString(dataStockOut.CurrentRow.Cells["dgvDate"].Value);
                DateTime dateOut;
                DateTime.TryParseExact(dateValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOut);
                string timein = Convert.ToString(dataStockOut.CurrentRow.Cells["dgvTime"].Value);
                string cause = Convert.ToString(dataStockOut.CurrentRow.Cells["dgvCause"].Value);
                decimal qty = Convert.ToDecimal(dataStockOut.CurrentRow.Cells["dgvQty"].Value);
                decimal coli = Convert.ToDecimal(dataStockOut.CurrentRow.Cells["dgvColi"].Value);
                string information = Convert.ToString(dataStockOut.CurrentRow.Cells["dgvInformation"].Value);
                int status = Convert.ToInt32(dataStockOut.CurrentRow.Cells["dgvConfirmValue"].Value);

                frmStockOutAdd stockOut = new frmStockOutAdd();
                stockOut.LoadCBSupplier();
                stockOut.LoadCBProduct();
                stockOut.LoadCBProductPrice();
                stockOut.comboSupplier.Text = supplier;
                stockOut.comboSupplier_TextChanged(stockOut.comboSupplier, EventArgs.Empty);
                stockOut.dateIn.Value = dateOut;
                stockOut.txtTimeIn.Text = timein;
                stockOut.Tid = id;
                stockOut.SOid = SOid;
                stockOut.comboProduct.Text = product;
                stockOut.comboProduct_TextChanged(stockOut.comboProduct, EventArgs.Empty);
                stockOut.txtQuantity.Text = qty.ToString();
                stockOut.txtColi.Text = coli.ToString();
                stockOut.comboCause.Text = cause;
                stockOut.txtInformation.Text = information;

                if (update == 0)
                {
                    MessageBox.Show("You do not have privilege to update this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }

                if (status == 1)
                {
                    MessageBox.Show("Confirmed data cannot be updated", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (stockOut.qty < qty || stockOut.coli < coli)
                {
                    MessageBox.Show($"Product does not have enough stock", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                BlurBackground(stockOut);

                LoadData();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataStockOut.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                if (delete == 0)
                {
                    MessageBox.Show("You do not have privilege to delete this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                DeleteColumnOut(dataStockOut, "Stock_Out", "[Transaction]");
                LoadData();
            }
        }

        private void dataStockOut_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataStockOut.Columns["dgvCheck"].Index)
            {
                foreach (DataGridViewRow row in dataStockOut.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["dgvCheck"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {
                        checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);
                    }
                }
            }
        }

        private void dataStockOut_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool rowChecked = CheckCheckedRow(dataStockOut);

            btnExport.Visible = rowChecked && export == 1;
            btnDelete.Visible = rowChecked && delete == 1;
        }

        private void dataStockOut_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataStockOut.Columns["dgvConfirm"].Index && e.RowIndex >= 0)
            {
                object confirmValue = dataStockOut.Rows[e.RowIndex].Cells["dgvConfirmValue"].Value;

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
