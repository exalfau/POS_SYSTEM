using Aspose.Words.Themes;
using Microsoft.Office.Interop.Excel;
using POS_SYSTEM.Class;
using POS_SYSTEM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static POS_SYSTEM.Class.DataMethod;
using DataTable = System.Data.DataTable;
using ListBox = System.Windows.Forms.ListBox;

namespace POS_SYSTEM.View
{
    public partial class frmDashboardView : Sample
    {
        public bool today, week, month, year, fiveYear, delivery, loan, birthday;
        public decimal order = 0, revenue1 = 0, revenue2 = 0, revenue3 = 0, revenue_total = 0, expenses = 0, profit = 0;
        public int staff = 0, customer = 0, supplier = 0;
        
        public frmDashboardView()
        {
            InitializeComponent();
        }

        private void frmDashboardView_Load(object sender, EventArgs e)
        {
            ResetButtonDatesStates();
            week = true;
            UpdateButtonDatesColors();

            DateTime end = DateTime.Now;
            DateTime start = end.AddDays(-7); // Customize the date range as needed
            LoadSumData(start, end);
            LoadCounter();

            ResetButtonNotifStates();
            delivery = true;
            UpdateButtonNotifColors();

            LoadDelivery();
            LoadLoan();
            LoadBirthDay();
            LoadUnderProduct();

            lblNotifDeliver.Text = flowDelivery.Controls.Count.ToString();
            lblNotifLoan.Text = flowLoan.Controls.Count.ToString();
            lblNotifBirhDay.Text = flowBirthDay.Controls.Count.ToString();
        }

        private void LoadUnderProduct()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvProduct);
            lb.Items.Add(dgvQuantity);

            string qry = @"SELECT id, name, quantity_total FROM [dbo].[Product] WHERE [quantity_total] < 10";

            DataMethod.LoadData(qry, dataUnderStock, lb);
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
        }

        private void UpdateButtonNotifColors()
        {
            Color selectedBackgroundColor = Color.FromArgb(20, 77, 166);
            Color deselectedBackgroundColor = Color.FromArgb(216, 236, 253);
            Color selectedForeColor = Color.White;  // White forecolor for selected buttons
            Color deselectedForeColor = SystemColors.ControlText;  // Default forecolor

            btnDelivery.FillColor = delivery ? selectedBackgroundColor : deselectedBackgroundColor;
            btnDelivery.ForeColor = delivery ? selectedForeColor : deselectedForeColor;
            flowDelivery.Visible = delivery ;

            btnLoan.FillColor = loan ? selectedBackgroundColor : deselectedBackgroundColor;
            btnLoan.ForeColor = loan ? selectedForeColor : deselectedForeColor;
            flowLoan.Visible = loan ;

            btnBirthDay.FillColor = birthday ? selectedBackgroundColor : deselectedBackgroundColor;
            btnBirthDay.ForeColor = birthday ? selectedForeColor : deselectedForeColor;
            flowBirthDay.Visible = birthday;
        }

        private void ResetButtonDatesStates()
        {
            today = false;
            week = false;
            month = false;
            year = false;
            fiveYear = false;
        }

        private void ResetButtonNotifStates()
        {
            delivery = false;
            loan = false;
            birthday = false;
        }

        private void AddDelivery(string id, string name, string info, Bitmap image)
        {
            var deliveryControl = new ucNotification()
            {
                ID = Convert.ToInt32(id),
                NAME = name,
                INFO = info,
                IMAGE = image,
            };

            flowDelivery.Controls.Add(deliveryControl);
        }

        private void LoadDelivery()
        {
            string qry = "SELECT d.id, cs.name as customer, d.status, s.name AS courier_name " +
                         "FROM Delivery d " +
                         "INNER JOIN Courier c ON d.id_courier = c.id " +
                         "INNER JOIN Customer cs ON d.id_customer = cs.id " +
                         "INNER JOIN Staff s ON c.id_staff = s.id " +
                         "WHERE d.status IN ('on process', 'sent')";

            SqlCommand cmd = new SqlCommand(qry, connection);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Bitmap courierImage = Properties.Resources.delivery_color;
                    string courierName = "Courier : " + row["courier_name"].ToString();
                    string status = "On process delivery to " + row["customer"].ToString();
                    AddDelivery(row["id"].ToString(), courierName, status, courierImage);
                }
            }
        }

        private void AddLoan(string id, string name, string info, Bitmap image)
        {
            var loanControl = new ucNotification()
            {
                ID = Convert.ToInt32(id),
                NAME = name,
                INFO = info,
                IMAGE = image,
            };

            flowLoan.Controls.Add(loanControl);
        }

        private void LoadLoan()
        {
            string qry = "SELECT c.[name] AS customer,COUNT(cc.[id]) AS credit" +
                " FROM [dbo].[Customer] c " +
                "JOIN [dbo].[Customer_Credit] cc ON c.[id] = cc.[id_customer] " +
                "WHERE cc.[status] = 'pending' GROUP BY c.[name] ORDER BY c.[name]; ";

            SqlCommand cmd = new SqlCommand(qry, connection);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Bitmap courierImage = Properties.Resources.funding_color;
                    string courierName = "Customer: " + row["customer"].ToString();
                    string status = "Has " + row["credit"] + " pending loan ";
                    AddLoan("0", courierName, status, courierImage);
                }
            }
        }

        private void AddBirthday(string id, string name, string info, Bitmap image)
        {
            var loanControl = new ucNotification()
            {
                ID = Convert.ToInt32(id),
                NAME = name,
                INFO = info,
                IMAGE = image,
            };

            flowBirthDay.Controls.Add(loanControl);
        }

        private void LoadBirthDay()
        {
            string qry = "SELECT [id], [customer_id], [name], [birth_date] " +
                "FROM[dbo].[Customer] " +
                "WHERE MONTH([birth_date]) = MONTH(GETDATE()) AND DAY([birth_date]) = DAY(GETDATE()); ";

            SqlCommand cmd = new SqlCommand(qry, connection);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Bitmap courierImage = Properties.Resources.birthday_color;
                    string courierName = "Customer: " + row["name"].ToString();
                    string status = "Birthday today ";
                    AddBirthday("0", courierName, status, courierImage);
                }
            }
        }

        private void LoadCounter()
        {
            if (connection.State == ConnectionState.Closed) { connection.Open(); }

            string qry1 = "SELECT COUNT(id) AS Staff_Count FROM Staff";

            SqlCommand command1 = new SqlCommand(qry1, connection);
            SqlDataReader reader1 = command1.ExecuteReader();

            if (reader1.Read() && !reader1.IsDBNull(reader1.GetOrdinal("Staff_Count")))
            {
                staff = Convert.ToInt32(reader1["Staff_Count"]);
            }

            reader1.Close();

            string qry2 = "SELECT COUNT(id) AS Customer_Count FROM Customer";

            SqlCommand command2 = new SqlCommand(qry2, connection);
            SqlDataReader reader2 = command2.ExecuteReader();

            if (reader2.Read() && !reader2.IsDBNull(reader2.GetOrdinal("Customer_Count")))
            {
                customer = Convert.ToInt32(reader2["Customer_Count"]);
            }

            reader2.Close();

            string qry3 = "SELECT COUNT(id) AS Supplier_Count FROM Supplier";

            SqlCommand command3 = new SqlCommand(qry3, connection);
            SqlDataReader reader3 = command3.ExecuteReader();

            if (reader3.Read() && !reader3.IsDBNull(reader3.GetOrdinal("Supplier_Count")))
            {
                supplier = Convert.ToInt32(reader3["Supplier_Count"]);
            }

            reader3.Close();

            lblNumStaff.Text = staff.ToString();
            lblNumCustomer.Text = customer.ToString();
            lblNumSupplier.Text = supplier.ToString();
            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        private void LoadSumData(DateTime start, DateTime end)
        {
            if (connection.State == ConnectionState.Closed) { connection.Open(); }

            // Calculate order count
            string qry1 = "SELECT COUNT(t.id) as order_count " +
                          "FROM Sales_Detail sd " +
                          "JOIN [Transaction] t ON sd.id_transaction = t.id " +
                          "WHERE t.type = 'sales' AND t.date >= @startDate AND t.date <= @endDate";

            SqlCommand command1 = new SqlCommand(qry1, connection);
            command1.Parameters.AddWithValue("@startDate", start.Date);
            command1.Parameters.AddWithValue("@endDate", end.Date);

            SqlDataReader reader1 = command1.ExecuteReader();

            if (reader1.Read() && !reader1.IsDBNull(reader1.GetOrdinal("order_count")))
            {
                order = Convert.ToDecimal(reader1["order_count"]);
            }

            reader1.Close();

            // Calculate revenue
            string qry2 = "SELECT SUM(sd.total_price) as revenue " +
               "FROM Sales_Detail sd " +
               "JOIN [Transaction] t ON sd.id_transaction = t.id " +
               "WHERE t.type = 'sales' AND (t.payment_type = 'cash' OR t.payment_type = 'deposit') " +
               "AND t.date >= @startDate AND t.date <= @endDate ";

            SqlCommand command2 = new SqlCommand(qry2, connection);
            command2.Parameters.AddWithValue("@startDate", start.Date);
            command2.Parameters.AddWithValue("@endDate", end.Date);

            SqlDataReader reader2 = command2.ExecuteReader();

            if (reader2.Read() && !reader2.IsDBNull(reader2.GetOrdinal("revenue")))
            {
                revenue1 = Convert.ToDecimal(reader2["revenue"]);
            }

            reader2.Close();

            string qry3 = "SELECT SUM(cc.amount) as revenue2 " +
                "FROM Customer_Credit cc " +
                "JOIN [Transaction] t ON cc.id_transaction = t.id " +
                "WHERE cc.status = 'paid' " +
                "AND t.date >= @startDate AND t.date <= @endDate";

            SqlCommand command3 = new SqlCommand(qry3, connection);
            command3.Parameters.AddWithValue("@startDate", start.Date);
            command3.Parameters.AddWithValue("@endDate", end.Date);

            SqlDataReader reader3 = command3.ExecuteReader();

            if (reader3.Read() && !reader3.IsDBNull(reader3.GetOrdinal("revenue2")))
            {
                revenue2 = Convert.ToDecimal(reader3["revenue2"]);
            }
            reader3.Close();


            string qry4 = "SELECT SUM(cost) AS revenue3 " +
                "FROM [dbo].[Delivery] " +
                "WHERE date_added >= @startDate AND date_added <= @endDate ";

            SqlCommand command4 = new SqlCommand(qry4, connection);
            command4.Parameters.AddWithValue("@startDate", start.Date);
            command4.Parameters.AddWithValue("@endDate", end.Date);

            SqlDataReader reader4 = command4.ExecuteReader();

            if (reader4.Read() && !reader4.IsDBNull(reader4.GetOrdinal("revenue3")))
            {
                revenue3 = Convert.ToDecimal(reader4["revenue3"]);
            }
            reader4.Close();

            // Calculate expenses
            string qry5 = "SELECT SUM(si.total_price) as total_expenses " +
                          "FROM Stock_In si " +
                          "JOIN [Transaction] t ON si.id_transaction = t.id " +
                          "WHERE t.type = 'stock_in' AND t.confirm = 1 " +
                          "AND t.date >= @startDate AND t.date <= @endDate";

            SqlCommand command5 = new SqlCommand(qry5, connection);
            command5.Parameters.AddWithValue("@startDate", start.Date);
            command5.Parameters.AddWithValue("@endDate", end.Date);

            SqlDataReader reader5 = command5.ExecuteReader();

            if (reader5.Read() && !reader5.IsDBNull(reader5.GetOrdinal("total_expenses")))
            {
                expenses = Convert.ToDecimal(reader5["total_expenses"]);
            }

            reader5.Close();

            revenue_total = revenue1 + revenue2 + revenue3;
            profit = revenue_total - expenses;
            lblNumTotalOrder.Text = order.ToString();
            lblNumTotalRevenues.Text = revenue_total.ToString();
            lblNumTotalExpenses.Text = expenses.ToString();
            lblNumTotalProfits.Text = profit.ToString();

            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        private void LoadChart(DateTime start, DateTime end)
        {
      
            // Replace this query with your actual database query
            string qry = "SELECT t.date, t.time, SUM(sd.total_price) AS gross_income " +
                         "FROM Sales_Detail sd " +
                         "JOIN [Transaction] t ON sd.id_transaction = t.id " +
                         "WHERE (t.date = @startDate AND t.time >= @startTime) " +
                         "OR (t.date = @endDate AND t.time <= @endTime) " +
                         "OR (t.date > @startDate AND t.date < @endDate) " +
                         "GROUP BY t.date, t.time " +
                         "ORDER BY t.date, t.time";

            SqlCommand command = new SqlCommand(qry, connection);

            command.Parameters.AddWithValue("@startDate", start.Date);
            command.Parameters.AddWithValue("@endDate", end.Date);
            command.Parameters.AddWithValue("@startTime", start.TimeOfDay);
            command.Parameters.AddWithValue("@endTime", end.TimeOfDay);

            if (connection.State == ConnectionState.Closed) { connection.Open(); }

            SqlDataReader reader = command.ExecuteReader();
            chartSales.Series["GrossIncome"].Points.Clear();

            while (reader.Read())
            {
                DateTime date = reader.GetDateTime(0) + reader.GetTimeSpan(1);
                decimal income = reader.GetDecimal(2);
                chartSales.Series["GrossIncome"].Points.AddXY(date, income);
            }

            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        private void UpdateChartXAxis(DateTime start, DateTime end)
        {
            TimeSpan timeSpan = end - start;

            if (timeSpan.TotalDays >= 1825) // 5 years or more
            {
                chartSales.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
                chartSales.ChartAreas[0].AxisX.Interval = 6;
            }
            else if (timeSpan.TotalDays >= 365) // 1 year or more
            {
                chartSales.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
                chartSales.ChartAreas[0].AxisX.Interval = 1;
            }
            else if (timeSpan.TotalDays >= 30) // 30 days or more
            {
                chartSales.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                chartSales.ChartAreas[0].AxisX.Interval = 7;
            }
            else if (timeSpan.TotalDays >= 7) // 7 days or more
            {
                chartSales.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                chartSales.ChartAreas[0].AxisX.Interval = 1;
            }
        
        }

        private void btn5YearDate_Click(object sender, EventArgs e)
        {
            ResetButtonDatesStates();
            fiveYear = true;
            UpdateButtonDatesColors();

            DateTime end = DateTime.Now;
            DateTime start = end.AddYears(-5); // Customize the date range as needed
            LoadSumData(start,end);
            UpdateChartXAxis(start, end);
            LoadChart(start, end);
        }
        
        private void btnYearDate_Click(object sender, EventArgs e)
        {
            ResetButtonDatesStates();
            year = true;
            UpdateButtonDatesColors();

            DateTime end = DateTime.Now;
            DateTime start = end.AddYears(-1); // Customize the date range as needed
            LoadSumData(start, end);
            UpdateChartXAxis(start, end);
            LoadChart(start, end);

        }

        private void btnMonthDate_Click(object sender, EventArgs e)
        {
            ResetButtonDatesStates();
            month = true;
            UpdateButtonDatesColors();

            DateTime end = DateTime.Now;
            DateTime start = end.AddMonths(-1); // Customize the date range as needed
            LoadSumData(start, end);
            UpdateChartXAxis(start, end);
            LoadChart(start, end);
        }

        private void btnWeekDate_Click(object sender, EventArgs e)
        {
            ResetButtonDatesStates();
            week = true;
            UpdateButtonDatesColors();

            DateTime end = DateTime.Now;
            DateTime start = end.AddDays(-7); // Customize the date range as needed
            LoadSumData(start, end);
            UpdateChartXAxis(start, end);
            LoadChart(start, end);
        }

        private void btnTodayDate_Click(object sender, EventArgs e)
        {
            ResetButtonDatesStates();
            today = true;
            UpdateButtonDatesColors();
            DateTime end = DateTime.Now;
            DateTime start = end.AddDays(-1); // Customize the date range to 24 hours
            LoadSumData(start, end);
            UpdateChartXAxis(start, end);
            LoadChart(start, end);
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            ResetButtonNotifStates();
            delivery = true;
            UpdateButtonNotifColors();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            ResetButtonNotifStates();
            loan = true;
            UpdateButtonNotifColors();
        }

        private void btnBirthDay_Click(object sender, EventArgs e)
        {
            ResetButtonNotifStates();
            birthday = true;
            UpdateButtonNotifColors();
        }
    }
}
