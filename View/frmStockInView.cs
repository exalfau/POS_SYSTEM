using Microsoft.SqlServer.Management.Sdk.Sfc;
using POS_SYSTEM.Class;
using POS_SYSTEM.Model;
using POS_SYSTEM.ModelImport;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition.Primitives;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static POS_SYSTEM.Class.CommonMethod;
using static POS_SYSTEM.Class.DataMethod;

namespace POS_SYSTEM.View
{
    public partial class frmStockInView : SampleView
    {
        int create = 0, update = 0, delete = 0, export = 0, import = 0;
        public frmStockInView()
        {
            InitializeComponent();
        }

        private void frmStockInView_Load(object sender, EventArgs e)
        {
            ConfigData(dataStockIn);
            LoadData();
            Privilege();
            if (create == 0) { btnAddNew.Visible = false; }
            if (import == 0) { btnImport.Visible = false; }
        }

        private void Privilege()
        {
            string qry = @"SELECT [create], [update], [delete], [export], [import] FROM Privilege WHERE id_feature = 11 AND id_role = '" + ROLEID + "'";

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
            BlurBackground(new frmStockInAdd());
            LoadData();
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedStockInData(dataStockIn, "Stock_In","[Transaction]");
            LoadData();
        }

        public override void btnExport_Click(object sender, EventArgs e)
        {
            Exports(dataStockIn,6);
        }

        public override void btnImport_Click(object sender, EventArgs e)
        {
            BlurBackground(new frmStockInImport());
            LoadData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvConfirmValue);
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvSupplier);
            lb.Items.Add(dgvDate);
            lb.Items.Add(dgvTime);
            lb.Items.Add(dgvProduct);
            lb.Items.Add(dgvQty);
            lb.Items.Add(dgvColi);
            lb.Items.Add(dgvNettPrice);
            lb.Items.Add(dgvTotalPrice);
            lb.Items.Add(dgvInformation);

            string qry = @"SELECT t.confirm, t.id, s.name as supplier_name, 
                        CONVERT(VARCHAR(10), t.date, 103) AS formatted_date, 
                        CONVERT(VARCHAR(5), t.time, 108) AS formatted_time,  
                        STUFF((SELECT ', ' + p.name
                               FROM Stock_In si
                               JOIN Product p ON si.id_product = p.id
                               WHERE si.id_transaction = t.id
                               FOR XML PATH('')), 1, 2, '') AS products_name,
                        STUFF((SELECT ', ' + CONVERT(VARCHAR(10), si.quantity)
                               FROM Stock_In si
                               WHERE si.id_transaction = t.id
                               FOR XML PATH('')), 1, 2, '') AS quantities,
                        STUFF((SELECT ', ' + CONVERT(VARCHAR(10), si.coli)
                               FROM Stock_In si
                               WHERE si.id_transaction = t.id
                               FOR XML PATH('')), 1, 2, '') AS coli,
                        STUFF((SELECT ', ' + CONVERT(VARCHAR(10), si.price)
                               FROM Stock_In si
                               WHERE si.id_transaction = t.id
                               FOR XML PATH('')), 1, 2, '') AS prices,
                        SUM(si.total_price) AS total_price, t.information
                        FROM [Transaction] t 
                        JOIN Stock_In si ON si.id_transaction = t.id
                        JOIN Supplier s ON si.id_supplier = s.id 
                        JOIN Product p ON si.id_product = p.id 
                        WHERE t.type = 'stock_In' AND (s.name LIKE '%" + txtSearch.Text + "%' OR p.name LIKE '%" + txtSearch.Text + "%'" +
                        " OR CONVERT(VARCHAR(10), t.date, 103) LIKE '%" + txtSearch.Text + "%' OR CONVERT(VARCHAR(5), t.time, 108) LIKE '%" + txtSearch.Text + "%') " +
                        "GROUP BY t.confirm, t.id, s.name, t.date, t.time, t.information " +
                        "ORDER BY id desc";

            DataMethod.LoadData(qry, dataStockIn, lb);
        }

        private void dataStockIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataStockIn.Columns[e.ColumnIndex].Name == "dgvEdit")
            {
                int id = Convert.ToInt32(dataStockIn.CurrentRow.Cells["dgvID"].Value);
                string supplier = Convert.ToString(dataStockIn.CurrentRow.Cells["dgvSupplier"].Value);
                string dateValue = Convert.ToString(dataStockIn.CurrentRow.Cells["dgvDate"].Value);
                DateTime dateIn;
                DateTime.TryParseExact(dateValue, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateIn);
                string timein = Convert.ToString(dataStockIn.CurrentRow.Cells["dgvTime"].Value);
                string information = Convert.ToString(dataStockIn.CurrentRow.Cells["dgvInformation"].Value);
                int status = Convert.ToInt32(dataStockIn.CurrentRow.Cells["dgvConfirmValue"].Value);
                frmStockInAdd stockInAdd = new frmStockInAdd();
                stockInAdd.LoadCBSupplier();
                stockInAdd.comboSupplier.Text = supplier;
                stockInAdd.comboSupplier_TextChanged(stockInAdd.comboSupplier, EventArgs.Empty);
                stockInAdd.dateIn.Value = dateIn;
                stockInAdd.txtTimeIn.Text = timein;
                stockInAdd.Tid = id;
                stockInAdd.txtInformation.Text = information;
                if (update == 0)
                {
                    MessageBox.Show("You do not have privilege to update this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if(status == 1)
                {
                    MessageBox.Show("Confirmed data cannot be updated", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BlurBackground(stockInAdd);
                LoadData();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataStockIn.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                if (delete == 0)
                {
                    MessageBox.Show("You do not have privilege to delete this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                DataMethod.DeleteColumnStockIn(dataStockIn, "Stock_In", "[Transaction]");

                LoadData();
            }
        }


        private void dataStockIn_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataStockIn.Columns["dgvCheck"].Index)
            {
                foreach (DataGridViewRow row in dataStockIn.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["dgvCheck"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {
                        checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);
                    }
                }
            }
        }

        private void dataStockIn_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool rowChecked = CheckCheckedRow(dataStockIn);

            btnExport.Visible = rowChecked && export == 1;
            btnDelete.Visible = rowChecked && delete == 1;
        }

        private void dataStockIn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataStockIn.Columns["dgvConfirm"].Index && e.RowIndex >= 0)
            {
                object confirmValue = dataStockIn.Rows[e.RowIndex].Cells["dgvConfirmValue"].Value;

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
