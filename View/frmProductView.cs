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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POS_SYSTEM.Class.CommonMethod;
using static POS_SYSTEM.Class.DataMethod;

namespace POS_SYSTEM.View
{
    public partial class frmProductView : SampleView
    {
        int create = 0, update = 0, delete = 0, export = 0, import = 0;
        public frmProductView()
        {
            InitializeComponent();
        }

        private void frmProductView_Load(object sender, EventArgs e)
        {
            ConfigData(dataProduct);
            LoadData();
            Privilege();
            if (create == 0) { btnAddNew.Visible = false; }
            if (import == 0) { btnImport.Visible = false; }
        }

        private void Privilege()
        {
            string qry = @"SELECT [create], [update], [delete], [export], [import] FROM Privilege WHERE id_feature = 10 AND id_role = '" + ROLEID + "'";

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
            BlurBackground(new frmProductAdd());
            LoadData();
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedData(dataProduct, "Product");
            LoadData();
        }

        public override void btnExport_Click(object sender, EventArgs e)
        {
            Exports(dataProduct,4);
        }

        public override void btnImport_Click(object sender, EventArgs e)
        {
            BlurBackground(new frmProductImport());
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
            lb.Items.Add(dgvCode);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvUnit);
            lb.Items.Add(dgvCategory);
            lb.Items.Add(dgvSupplier);
            lb.Items.Add(dgvQty);
            lb.Items.Add(dgvColi);
            lb.Items.Add(dgvNettPrice);
            lb.Items.Add(dgvMargin);
            lb.Items.Add(dgvTax);
            lb.Items.Add(dgvDiscount);
            lb.Items.Add(dgvSellPrice);
            lb.Items.Add(dgvInformation);
            string qry = @"SELECT p.id, p.product_code, p.name, u.unit_code, c.name, s.name, p.quantity_total, p.coli_total,
                            p.nett_price, p.margin, p.tax, p.discount, p.sell_price, p.information
                            FROM Product p JOIN Unit u ON p.id_unit = u.id JOIN Category c ON p.id_category = c.id 
                            JOIN Supplier s ON p.id_supplier = s.id WHERE p.product_code LIKE '%" + txtSearch.Text + "%'OR " +
                            "p.name LIKE'%" + txtSearch.Text + "%' OR u.unit_code LIKE'%" + txtSearch.Text + "%' OR c.name LIKE'%" + txtSearch.Text + "%' " +
                            "OR s.name LIKE'%" + txtSearch.Text + "%' ORDER BY id desc";

            DataMethod.LoadData(qry, dataProduct, lb);
        }

        private void dataProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int qty = Convert.ToInt32(dataProduct.CurrentRow.Cells["dgvQty"].Value);
            int coli = Convert.ToInt32(dataProduct.CurrentRow.Cells["dgvColi"].Value);

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataProduct.Columns[e.ColumnIndex].Name == "dgvEdit")
            {
                int id = Convert.ToInt32(dataProduct.CurrentRow.Cells["dgvID"].Value);
                string productCode = Convert.ToString(dataProduct.CurrentRow.Cells["dgvCode"].Value);
                string name = Convert.ToString(dataProduct.CurrentRow.Cells["dgvName"].Value);
                string unit = Convert.ToString(dataProduct.CurrentRow.Cells["dgvUnit"].Value);
                string category = Convert.ToString(dataProduct.CurrentRow.Cells["dgvCategory"].Value);
                string supplier = Convert.ToString(dataProduct.CurrentRow.Cells["dgvSupplier"].Value);
                decimal nPrice = Convert.ToDecimal(dataProduct.CurrentRow.Cells["dgvNettPrice"].Value);
                decimal margin = Convert.ToDecimal(dataProduct.CurrentRow.Cells["dgvMargin"].Value);
                decimal tax = Convert.ToDecimal(dataProduct.CurrentRow.Cells["dgvTax"].Value);
                decimal discount = Convert.ToDecimal(dataProduct.CurrentRow.Cells["dgvDiscount"].Value);
                decimal sPrice = Convert.ToDecimal(dataProduct.CurrentRow.Cells["dgvSellPrice"].Value);
                string information = Convert.ToString(dataProduct.CurrentRow.Cells["dgvInformation"].Value);

                frmProductAdd ProductAdd = new frmProductAdd();
                ProductAdd.LoadCBU();
                ProductAdd.LoadCBC();
                ProductAdd.LoadCBS();
                ProductAdd.id = id;
                ProductAdd.txtProductCode.Text = productCode;
                ProductAdd.txtName.Text = name;
                ProductAdd.comboUnit.Text = unit;
                ProductAdd.comboCategory.Text = category;
                ProductAdd.comboSupplier.Text = supplier;
                ProductAdd.txtNettPrice.Text = nPrice.ToString();
                ProductAdd.txtMargin.Text = margin.ToString();
                ProductAdd.txtTax.Text = tax.ToString();
                ProductAdd.txtDiscount.Text = discount.ToString();
                ProductAdd.txtSellPrice.Text = sPrice.ToString();
                ProductAdd.txtInformation.Text = information;
                if (update == 0)
                {
                    MessageBox.Show("You do not have privilege to update this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                BlurBackground(ProductAdd);
                LoadData();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataProduct.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                if (delete == 0)
                {
                    MessageBox.Show("You do not have privilege to delete this table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                if (qty > 0 | coli > 0)
                {
                    MessageBox.Show("You cannot delete product that still have stock", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                DataMethod.DeleteColumn(dataProduct, "Product");
                LoadData();
            }
        }

        private void dataProduct_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataProduct.Columns["dgvCheck"].Index)
            {
                foreach (DataGridViewRow row in dataProduct.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["dgvCheck"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {
                        checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);
                    }
                }
            }
        }

        private void dataProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool rowChecked = CheckCheckedRow(dataProduct);

            btnExport.Visible = rowChecked && export == 1;
            btnDelete.Visible = rowChecked && delete == 1;
        }
    }
}
