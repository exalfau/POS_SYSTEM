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
    public partial class frmCustomerDetailView : SampleDetailView
    {
        public string name;
        public bool custom, today, week, month, year, fiveYear, allData;

        public frmCustomerDetailView()
        {
            InitializeComponent();
        }

        private void frmCustomerDetailView_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.community_color;
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
            // Update this part of the query to filter based on the date range
            string dateFilter = $"AND t.date >= DATEADD({datePart}, -{range}, GETDATE())";

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
            //... (your existing code remains the same)
            string qry = @"SELECT sd.id, t.invoice_id, t.date, s.name, c.name, p.name, sd.quantity, sd.price, sd.total_price, t.information
                    FROM Sales_Detail sd 
                    JOIN [Transaction] t ON sd.id_transaction = t.id
                    JOIN Staff s ON sd.id_staff = s.id
                    JOIN Customer c ON sd.id_customer = c.id
                    JOIN Product p ON sd.id_product = p.id
                    WHERE c.name = '" + name + "' AND (s.name LIKE '%" + txtSearch.Text + "%' OR p.name LIKE '%" + txtSearch.Text + "%' " +
                            "OR t.invoice_id LIKE '%" + txtSearch.Text + "%' OR t.date LIKE '%" + txtSearch.Text + "%')" +
                            dateFilter + // Add the date filter condition
                            "ORDER BY sd.id desc";

            DataMethod.LoadData(qry, dataCustomer, lb);
        }

        private void LoadData()
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
                            WHERE c.name = '" + name + "' AND (s.name LIKE '%" + txtSearch.Text + "%' OR p.name LIKE '%" + txtSearch.Text + "%' " +
                            "OR t.invoice_id LIKE '%" + txtSearch.Text + "%' OR t.date LIKE '%" + txtSearch.Text + "%')" +
                            "ORDER BY sd.id desc";


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
