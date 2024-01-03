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

namespace POS_SYSTEM.View
{
    public partial class frmCourierDetailView : SampleDetailView
    {
        public string name;
        public bool custom, today, week, month, year, fiveYear, allData;

        public frmCourierDetailView()
        {
            InitializeComponent();
        }

        private void frmCourierDetailView_Load(object sender, EventArgs e)
        {
            pictLogo.Image = Properties.Resources.delivery_courier_color;
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
            lb.Items.Add(dgvInvoiceID);
            lb.Items.Add(dgvCustomer);
            lb.Items.Add(dgvCourier);
            lb.Items.Add(dgvAddress);
            lb.Items.Add(dgvDateSent);
            lb.Items.Add(dgvTimeSent);
            lb.Items.Add(dgvCost);
            lb.Items.Add(dgvDateDelivered);
            lb.Items.Add(dgvTimeDelivered);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvInformation);
            string qry = @"SELECT d.id, t.invoice_id, cs.name, s.name, d.address, d.date_sent, d.time_sent, d.cost, d.date_delivered, d.time_delivered, d.status, d.information
                            FROM Delivery d 
                            JOIN Customer cs ON d.id_customer = cs.id
                            JOIN Courier c ON d.id_courier = c.id
                            JOIN Staff s ON c.id_staff = s.id
                            JOIN [Transaction] t ON d.id_transaction = t.id    
                            WHERE s.name = '" + name + "' AND (cs.name LIKE '%" + txtSearch.Text + "%' OR d.status LIKE '%" + txtSearch.Text + "%' " +
                            "OR t.invoice_id LIKE '%" + txtSearch.Text + "%' OR s.name LIKE '%" + txtSearch.Text + "%')" +
                            dateFilter +
                            "ORDER BY d.id desc";


            DataMethod.LoadData(qry, dataDelivery, lb);
        }
        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvInvoiceID);
            lb.Items.Add(dgvCustomer);
            lb.Items.Add(dgvCourier);
            lb.Items.Add(dgvAddress);
            lb.Items.Add(dgvDateSent);
            lb.Items.Add(dgvTimeSent);
            lb.Items.Add(dgvCost);
            lb.Items.Add(dgvDateDelivered);
            lb.Items.Add(dgvTimeDelivered);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvInformation);
            string qry = @"SELECT d.id, t.invoice_id, cs.name, s.name, d.address, d.date_sent, d.time_sent, d.cost, d.date_delivered, d.time_delivered, d.status, d.information
                            FROM Delivery d 
                            JOIN Customer cs ON d.id_customer = cs.id
                            JOIN Courier c ON d.id_courier = c.id
                            JOIN Staff s ON c.id_staff = s.id
                            JOIN [Transaction] t ON d.id_transaction = t.id    
                            WHERE s.name = '" + name + "' AND (cs.name LIKE '%" + txtSearch.Text + "%' OR d.status LIKE '%" + txtSearch.Text + "%' " +
                            "OR t.invoice_id LIKE '%" + txtSearch.Text + "%' OR s.name LIKE '%" + txtSearch.Text + "%')" +
                            "ORDER BY d.id desc";


            DataMethod.LoadData(qry, dataDelivery, lb);
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
