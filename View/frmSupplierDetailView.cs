using Microsoft.Office.Interop.Excel;
using Microsoft.SqlServer.Management.Smo;
using POS_SYSTEM.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListBox = System.Windows.Forms.ListBox;

namespace POS_SYSTEM.View
{
    public partial class frmSupplierDetailView : SampleDetailView
    {
        public string name;
        public bool custom, today, week, month, year, fiveYear, allData;

        public frmSupplierDetailView()
        {
            InitializeComponent();
        }

        private void frmSupplierDetailView_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.inventory_color;
            lblHeader.Text = name + "'s History";
            ResetButtonDatesStates();
            allData = true;
            UpdateButtonDatesColors();
            LoadData();
        }

        private void UpdateButtonDatesColors()
        {
            Color selectedBackgroundColor = Color.FromArgb(20, 77, 166);
            Color deselectedBackgroundColor = Color.FromArgb(216, 236, 253);
            Color selectedForeColor = Color.White;  // White forecolor for selected buttons
            Color deselectedForeColor = SystemColors.ControlText;  // Default forecolor

            btn5YearDate.BackColor = fiveYear ? selectedBackgroundColor : deselectedBackgroundColor;
            btn5YearDate.ForeColor = fiveYear ? selectedForeColor : deselectedForeColor;

            btnYearDate.BackColor = year ? selectedBackgroundColor : deselectedBackgroundColor;
            btnYearDate.ForeColor = year ? selectedForeColor : deselectedForeColor;

            btnMonthDate.BackColor = month ? selectedBackgroundColor : deselectedBackgroundColor;
            btnMonthDate.ForeColor = month ? selectedForeColor : deselectedForeColor;

            btnWeekDate.BackColor = week ? selectedBackgroundColor : deselectedBackgroundColor;
            btnWeekDate.ForeColor = week ? selectedForeColor : deselectedForeColor;

            btnTodayDate.BackColor = today ? selectedBackgroundColor : deselectedBackgroundColor;
            btnTodayDate.ForeColor = today ? selectedForeColor : deselectedForeColor;

            btnAll.BackColor = allData ? selectedBackgroundColor : deselectedBackgroundColor;
            btnAll.ForeColor = allData ? selectedForeColor : deselectedForeColor;
        }

        private void ResetButtonDatesStates()
        {
            custom = false;
            today = false;
            week = false;
            month = false;
            year = false;
            fiveYear = false;
            allData = false;
        }

        private void btn5YearDate_Click(object sender, EventArgs e)
        {
            ResetButtonDatesStates();
            fiveYear = true;
            UpdateButtonDatesColors();
            LoadDataWithDateRange("YEAR", 5);
        }

        private void btnYearDate_Click(object sender, EventArgs e)
        {
            ResetButtonDatesStates();
            year = true;
            UpdateButtonDatesColors();
            LoadDataWithDateRange("YEAR", 1);
        }

        private void btnMonthDate_Click(object sender, EventArgs e)
        {
            ResetButtonDatesStates();
            month = true;
            UpdateButtonDatesColors();
            LoadDataWithDateRange("MONTH", 1);
        }

        private void btnWeekDate_Click(object sender, EventArgs e)
        {
            ResetButtonDatesStates();
            week = true;
            UpdateButtonDatesColors();
            LoadDataWithDateRange("DAY", 7);
        }

        private void btnTodayDate_Click(object sender, EventArgs e)
        {
            ResetButtonDatesStates();
            today = true;
            UpdateButtonDatesColors();
            LoadDataWithDateRange("DAY", 1);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ResetButtonDatesStates();
            allData = true;
            UpdateButtonDatesColors();
            LoadData();
        }

        private void LoadDataWithDateRange(string datePart, int range)
        {
            string dateFilter = $"AND t.date >= DATEADD({datePart}, -{range}, GETDATE())";

            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvProduct);
            lb.Items.Add(dgvQty);
            lb.Items.Add(dgvColi);
            lb.Items.Add(dgvDate);
            lb.Items.Add(dgvTIme);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvTotalPrice);
            string qry = @"SELECT si.id, p.name, si.quantity, si.coli, t.date, t.time, si.price, si.total_price
                            FROM Stock_In si 
                            JOIN Product p ON si.id_product = p.id
                            JOIN [Transaction] t ON si.id_transaction = t.id
                            JOIN Supplier s ON si.id_supplier = s.id 
                            WHERE s.name = '" + name + "' AND (p.name LIKE '%" + txtSearch.Text + "%' OR t.date LIKE '%" + txtSearch.Text + "%' " +
                            "OR si.price LIKE '%" + txtSearch.Text + "%' OR si.total_price LIKE '%" + txtSearch.Text + "%')" +
                            dateFilter +
                            "ORDER BY si.id desc";


            DataMethod.LoadData(qry, dataCustomer, lb);
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvProduct);
            lb.Items.Add(dgvQty);
            lb.Items.Add(dgvColi);
            lb.Items.Add(dgvDate);
            lb.Items.Add(dgvTIme);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvTotalPrice);
            string qry = @"SELECT si.id, p.name, si.quantity, si.coli, t.date, t.time, si.price, si.total_price
                            FROM Stock_In si 
                            JOIN Product p ON si.id_product = p.id
                            JOIN [Transaction] t ON si.id_transaction = t.id
                            JOIN Supplier s ON si.id_supplier = s.id 
                            WHERE s.name = '" + name + "' AND (p.name LIKE '%" + txtSearch.Text + "%' OR t.date LIKE '%" + txtSearch.Text + "%' " +
                            "OR si.price LIKE '%" + txtSearch.Text + "%' OR si.total_price LIKE '%" + txtSearch.Text + "%')" +
                            "ORDER BY si.id desc";


            DataMethod.LoadData(qry, dataCustomer, lb);
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
