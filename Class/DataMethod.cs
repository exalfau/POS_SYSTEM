using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Configuration;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO;
using System.Data.Common;
using Dapper;

namespace POS_SYSTEM.Class
{
    internal class DataMethod
    {
        public static string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        public static SqlConnection connection = new SqlConnection(cs);
        public static string id;
        public static string ID { get { return id; } private set { id = value; } }
        public static string user;
        public static string USER { get { return user; } private set { user = value; } }
        public static string roleid;
        public static string ROLEID { get { return roleid; } private set { roleid = value; } }
        public static string role;
        public static string ROLE { get { return role; } private set { role = value; } }
        public static string username;
        public static string USERNAME { get { return username; } private set { username = value; } }
        public static Image profile;
        public static Image PROFILE { get { return profile; } private set { profile = value; } }

        public static bool ValidateUser(string username, string password)
        {
            bool isValid = false;

            string qry = @"SELECT s.name, s.id AS IDSTAFF, r.id as ROLEID, r.name as ROLE, s.image, a.username FROM Account a
               INNER JOIN Staff s ON a.id_staff = s.id 
               INNER JOIN Role r ON s.id_role = r.id
               WHERE a.username COLLATE Latin1_General_CS_AS = @username AND a.password = @password";

            SqlCommand cmd = new SqlCommand(qry, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);



            if (dt.Rows.Count > 0)
            {
                isValid = true;
                USERNAME = dt.Rows[0]["username"].ToString();
                ID = dt.Rows[0]["IDSTAFF"].ToString();
                USER = dt.Rows[0]["name"].ToString();
                ROLEID = dt.Rows[0]["ROLEID"].ToString();
                ROLE = dt.Rows[0]["ROLE"].ToString();
                Byte[] imageArray = (byte[])dt.Rows[0]["image"];
                byte[] imageByteArray = imageArray;
                PROFILE = Image.FromStream(new MemoryStream(imageArray));
            }
            return isValid;
        }

        public static List<T> FetchData<T>(string query)
        {
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            return connection.Query<T>(query).ToList();
            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }

        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(qry, connection);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colName = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colName].DataPropertyName = dt.Columns[i].ToString();
                }
                gv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                connection.Close();
            }

        }

        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;
            bool exceptionShown = false; // Initialize a flag to track if the exception has been shown

            try
            {
                SqlCommand cmd = new SqlCommand(qry, connection);
                cmd.CommandType = CommandType.Text;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                res = cmd.ExecuteNonQuery();
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Check if it's a foreign key constraint violation
                {
                    if (!exceptionShown)
                    {
                        MessageBox.Show("Data already been used in other table", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        exceptionShown = true; // Set the flag to true
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message, "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    exceptionShown = true; // Set the flag to true
                }
            }


            return res;
        }


        public static int SQLScalar(string query)
        {
            int rowCount = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                if (connection.State == ConnectionState.Closed) { connection.Open(); }
                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    rowCount = Convert.ToInt32(result);
                }
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return rowCount;
        }


        public static DataTable SQLQuery(string query)
        {
            DataTable dataTable = new DataTable();
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            adapter.Fill(dataTable);
            return dataTable;
        }

        public static bool DeleteSelectedData(DataGridView dataGridView, string tableName)
        {
            bool message = false;
            int selectedRowCount = dataGridView.Rows.Cast<DataGridViewRow>()
                                   .Count(row => row.Cells["dgvCheck"] is DataGridViewCheckBoxCell &&
                                           Convert.ToBoolean(row.Cells["dgvCheck"].Value));

            if (selectedRowCount > 1)
            {
                DialogResult result = MessageBox.Show("You are going to delete multiple data", "POS SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DialogResult confirm = MessageBox.Show("Are you sure?", "POS SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow item in dataGridView.Rows)
                        {
                            DataGridViewCheckBoxCell checkBoxCell = item.Cells["dgvCheck"] as DataGridViewCheckBoxCell;

                            if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                            {
                                if (item.Cells["dgvID"] != null && item.Cells["dgvID"].Value != null)
                                {
                                    int id = Convert.ToInt32(item.Cells["dgvID"].Value);
                                    string qry = $"DELETE FROM {tableName} WHERE id = @id";
                                    Hashtable ht = new Hashtable();
                                    ht.Add("@id", id);
                                    if (SQL(qry, ht) > 0)
                                    {
                                        message = true;
                                    }
                                }
                                else
                                {
                                    message = false;
                                }
                            }
                        }
                        ResetID(tableName);
                    }
                }
            }
            else
            {
                DeleteColumn(dataGridView, tableName);
            }
            return message;
        }


        public static void DeleteColumn(DataGridView dataGridView, string tableName)
        {
            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["dgvID"].Value);
            string qry = $"DELETE FROM {tableName} WHERE id = '" + id + "'";
            Hashtable ht = new Hashtable();
            DialogResult result = MessageBox.Show("You are going to delete a data", "POS SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Data has been deleted", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetID(tableName);
                }
            }
        }

        public static void DeleteSelectedDataOut(DataGridView dataGridView, string tableName1, string tableName2)
        {
            bool showMessage = true; // Initialize the flag

            int selectedRowCount = dataGridView.Rows.Cast<DataGridViewRow>()
                .Count(row => row.Cells["dgvCheck"] is DataGridViewCheckBoxCell &&
                              Convert.ToBoolean(row.Cells["dgvCheck"].Value));

            // Reset the showMessage flag here to allow showing a message again in the next method call
            showMessage = true;

            if (selectedRowCount > 1)
            {
                DialogResult result = MessageBox.Show("You are going to delete multiple data", "POS SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DialogResult confirm = MessageBox.Show("Are you sure?", "POS SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow item in dataGridView.Rows)
                        {
                            DataGridViewCheckBoxCell checkBoxCell = item.Cells["dgvCheck"] as DataGridViewCheckBoxCell;

                            if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                            {
                                if (item.Cells["dgvID"] != null && item.Cells["dgvID"].Value != null)
                                {
                                    int id = Convert.ToInt32(item.Cells["dgvID"].Value);
                                    string qry1 = $"DELETE FROM {tableName1} WHERE id_transaction = @id";
                                    string qry2 = $"DELETE FROM {tableName2} WHERE id = @id";
                                    Hashtable ht = new Hashtable();
                                    ht.Add("@id", id);
                                    if (SQL(qry1, ht) > 0 && SQL(qry2, ht) > 0)
                                    {
                                        if (showMessage == true)
                                        {
                                            MessageBox.Show("Data has been deleted", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            showMessage = false; // Set the flag to false after showing the message
                                        }
                                        ResetID(tableName1);
                                        ResetID(tableName2);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                DeleteColumnOut(dataGridView, tableName1, tableName2);
            }
        }

        public static void DeleteColumnOut(DataGridView dataGridView, string tableName1, string tableName2)
        {
            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["dgvID"].Value);
            string qry1 = $"DELETE FROM {tableName1} WHERE id_transaction = '" + id + "'";
            string qry2 = $"DELETE FROM {tableName2} WHERE id = '" + id + "'";

            Hashtable ht = new Hashtable();
            DialogResult result = MessageBox.Show("You are going to delete a data", "POS SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (SQL(qry1, ht) > 0 && SQL(qry2, ht) > 0)
                {
                    MessageBox.Show("Data has been deleted", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetID(tableName1);
                    ResetID(tableName2);
                }
            }
        }


        public static void DeleteSelectedDataSales(DataGridView dataGridView, string tableName1, string tableName2)
        {
            bool showMessage = true; // Flag to control showing the message only once

            int selectedRowCount = dataGridView.Rows.Cast<DataGridViewRow>()
                .Count(row => row.Cells["dgvCheck"] is DataGridViewCheckBoxCell &&
                              Convert.ToBoolean(row.Cells["dgvCheck"].Value));

            if (selectedRowCount > 1)
            {
                DialogResult result = MessageBox.Show("You are going to delete multiple data", "POS SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DialogResult confirm = MessageBox.Show("Are you sure?", "POS SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow item in dataGridView.Rows)
                        {
                            DataGridViewCheckBoxCell checkBoxCell = item.Cells["dgvCheck"] as DataGridViewCheckBoxCell;

                            if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                            {
                                if (item.Cells["dgvID"] != null && item.Cells["dgvID"].Value != null)
                                {
                                    int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["dgvID"].Value);
                                    string qry1 = $"DELETE FROM Sales_Detail WHERE id_transaction = '" + id + "'";
                                    string qry2 = $"DELETE FROM [Transaction] WHERE id = '" + id + "'";
                                    string qry3 = $"DELETE FROM Customer_Credit WHERE id_transaction = '" + id + "'";
                                    string qry4 = $"DELETE FROM Customer_Deposit WHERE id_transaction = '" + id + "'";
                                    string qry5 = $"DELETE FROM Delivery WHERE id_transaction = '" + id + "'";
                                    Hashtable ht = new Hashtable();
                                    try
                                    {
                                        if (SQL(qry3, ht) > 0 || SQL(qry4, ht) > 0 || SQL(qry5, ht) > 0 || SQL(qry1, ht) > 0 && SQL(qry2, ht) > 0)
                                        {
                                            if (showMessage)
                                            {
                                                MessageBox.Show("Data has been deleted", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                showMessage = false; // Set the flag to false after showing the message
                                            }
                                            ResetID(tableName1);
                                            ResetID(tableName2);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        if (showMessage)
                                        {
                                            MessageBox.Show(ex.Message, "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            showMessage = false; // Set the flag to false after showing the message
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                DeleteColumnSales(dataGridView, tableName1, tableName2);
            }
        }

        public static void DeleteColumnSales(DataGridView dataGridView, string tableName1, string tableName2)
        {
            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["dgvID"].Value);
            string qry1 = $"DELETE FROM Sales_Detail WHERE id_transaction = '" + id + "'";
            string qry2 = $"DELETE FROM [Transaction] WHERE id = '" + id + "'";
            string qry3 = $"DELETE FROM Customer_Credit WHERE id_transaction = '" + id + "'";
            string qry4 = $"DELETE FROM Customer_Deposit WHERE id_transaction = '" + id + "'";
            string qry5 = $"DELETE FROM Delivery WHERE id_transaction = '" + id + "'";

            Hashtable ht = new Hashtable();
            DialogResult result = MessageBox.Show("You are going to delete a data", "POS SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SQL(qry3, ht); SQL(qry4, ht);  SQL(qry5, ht);
                if ( SQL(qry1, ht) > 0 && SQL(qry2, ht) > 0)
                {
                    MessageBox.Show("Data has been deleted", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetID(tableName1);
                    ResetID(tableName2);
                }
            }
        }

        public static void DeleteSelectedStockInData(DataGridView dataGridView, string tableName1, string tableName2)
        {
            bool showMessage = true; // Flag to control showing the message only once

            int selectedRowCount = dataGridView.Rows.Cast<DataGridViewRow>()
                .Count(row => row.Cells["dgvCheck"] is DataGridViewCheckBoxCell &&
                              Convert.ToBoolean(row.Cells["dgvCheck"].Value));

            if (selectedRowCount > 1)
            {
                DialogResult result = MessageBox.Show("You are going to delete multiple data", "POS SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DialogResult confirm = MessageBox.Show("Are you sure?", "POS SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow item in dataGridView.Rows)
                        {
                            DataGridViewCheckBoxCell checkBoxCell = item.Cells["dgvCheck"] as DataGridViewCheckBoxCell;

                            if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                            {
                                if (item.Cells["dgvID"] != null && item.Cells["dgvID"].Value != null)
                                {
                                    int id = Convert.ToInt32(item.Cells["dgvID"].Value);
                                    string qry1 = $"DELETE FROM {tableName1} WHERE id_transaction = @id";
                                    string qry2 = $"DELETE FROM {tableName2} WHERE id = @id";
                                    Hashtable ht = new Hashtable();
                                    ht.Add("@id", id);
                                    try
                                    {
                                        string stockInProductQuery = $"SELECT id_product, quantity, coli FROM Stock_In WHERE id_transaction = '{id}'";
                                        string confirmedQuery = $"SELECT confirm FROM [Transaction] WHERE id = '{id}'";
                                        int confirmed = Convert.ToInt32(SQLScalar(confirmedQuery));

                                        // Fetch all products associated with the transaction
                                        DataTable productData = SQLQuery(stockInProductQuery);

                                        foreach (DataRow row in productData.Rows)
                                        {
                                            int productId = Convert.ToInt32(row["id_product"]);
                                            int stockInQuantity = Convert.ToInt32(row["quantity"]);
                                            int stockInColi = Convert.ToInt32(row["coli"]);

                                            string quantityInQuery = $"SELECT quantity_in FROM Product WHERE id = '{productId}'";
                                            int quantityIn = Convert.ToInt32(SQLScalar(quantityInQuery));

                                            string coliInQuery = $"SELECT coli_in FROM Product WHERE id = '{productId}'";
                                            int coliIn = Convert.ToInt32(SQLScalar(coliInQuery));

                                            string quantityOutQuery = $"SELECT quantity_out FROM Product WHERE id = '{productId}'";
                                            int quantityOut = Convert.ToInt32(SQLScalar(quantityOutQuery));

                                            string coliOutQuery = $"SELECT coli_out FROM Product WHERE id = '{productId}'";
                                            int coliOut = Convert.ToInt32(SQLScalar(coliOutQuery));

                                            if (((quantityIn - stockInQuantity) < quantityOut || (coliIn - stockInColi) < coliOut) && confirmed == 1)
                                            {
                                                MessageBox.Show("Deleting this record would make quantity or coli of the product(s) negative", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                return;
                                            }
                                        }

                                        if (SQL(qry1, ht) > 0 && SQL(qry2, ht) > 0)
                                        {
                                            if (showMessage)
                                            {
                                                MessageBox.Show("Data has been deleted", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                showMessage = false; // Set the flag to false after showing the message
                                            }
                                            ResetID(tableName1);
                                            ResetID(tableName2);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        if (showMessage)
                                        {
                                            MessageBox.Show(ex.Message, "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            showMessage = false; // Set the flag to false after showing the message
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                DeleteColumnStockIn(dataGridView, tableName1, tableName2);
            }
        }


        public static void DeleteColumnStockIn(DataGridView dataGridView, string tableName1, string tableName2)
        {
            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["dgvID"].Value);

            string qry1 = $"DELETE FROM Stock_In WHERE id_transaction = '{id}'";
            string qry2 = $"DELETE FROM [Transaction] WHERE id = '{id}'";

            Hashtable ht = new Hashtable();
            DialogResult result = MessageBox.Show("You are going to delete a data", "POS SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string stockInProductQuery = $"SELECT id_product, quantity, coli FROM Stock_In WHERE id_transaction = '{id}'";
                string confirmedQuery = $"SELECT confirm FROM [Transaction] WHERE id = '{id}'";
                int confirm = Convert.ToInt32(SQLScalar(confirmedQuery));

                // Fetch all products associated with the transaction
                DataTable productData = SQLQuery(stockInProductQuery);

                foreach (DataRow row in productData.Rows)
                {
                    int productId = Convert.ToInt32(row["id_product"]);
                    int stockInQuantity = Convert.ToInt32(row["quantity"]);
                    int stockInColi = Convert.ToInt32(row["coli"]);

                    string quantityInQuery = $"SELECT quantity_in FROM Product WHERE id = '{productId}'";
                    int quantityIn = Convert.ToInt32(SQLScalar(quantityInQuery));

                    string coliInQuery = $"SELECT coli_in FROM Product WHERE id = '{productId}'";
                    int coliIn = Convert.ToInt32(SQLScalar(coliInQuery));

                    string quantityOutQuery = $"SELECT quantity_out FROM Product WHERE id = '{productId}'";
                    int quantityOut = Convert.ToInt32(SQLScalar(quantityOutQuery));

                    string coliOutQuery = $"SELECT coli_out FROM Product WHERE id = '{productId}'";
                    int coliOut = Convert.ToInt32(SQLScalar(coliOutQuery));

                    if (((quantityIn - stockInQuantity) < quantityOut || (coliIn - stockInColi) < coliOut) && confirm == 1)
                    {
                        MessageBox.Show("Deleting this record would make quantity or coli of the product(s) negative", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (SQL(qry1, ht) > 0 && SQL(qry2, ht) > 0)
                {
                    MessageBox.Show("Data has been deleted", "POS SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetID(tableName1);
                    ResetID(tableName2);
                }
            }
        }




        public static void ResetID(string tabelName)
        {

            string checkEmptyQuery = $"SELECT COUNT(*) FROM {tabelName} ";
            int rowCount = Convert.ToInt32(SQLScalar(checkEmptyQuery));

            if (rowCount == 0)
            {
                string reseedQuery = $"DBCC CHECKIDENT ('{tabelName}', RESEED, 0)";
                SQL(reseedQuery, new Hashtable());
            }
        }

        public static void CBFill(string qry, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry, connection);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }

        public static Image LoadImage(string columnName, int id)
        {
            string qry = $"SELECT image FROM {columnName} WHERE id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(qry, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Byte[] imageArray = (byte[])dt.Rows[0]["image"];
                byte[] imageByteArray = imageArray;
                return Image.FromStream(new MemoryStream(imageArray));
            }
            return null;
        }

        public static int GetStaffId()
        {
            int lastStaffID = 0;
            string query = "SELECT TOP 1 id FROM Staff ORDER BY id DESC";
            SqlCommand command = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            object result = command.ExecuteScalar();
            if (connection.State == ConnectionState.Open) { connection.Close(); }

            return lastStaffID = Convert.ToInt32(result) + 1;
        }

        public static int GetCustomerID()
        {
            int lastStaffID = 0;
            string query = "SELECT TOP 1 id FROM Customer ORDER BY id DESC";
            SqlCommand command = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            object result = command.ExecuteScalar();
            if (connection.State == ConnectionState.Open) { connection.Close(); }

            return lastStaffID = Convert.ToInt32(result) + 1;
        }
        public static int GetSupplierID()
        {
            int lastStaffID = 0;
            string query = "SELECT TOP 1 id FROM Supplier ORDER BY id DESC";
            SqlCommand command = new SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            object result = command.ExecuteScalar();
            if (connection.State == ConnectionState.Open) { connection.Close(); }

            return lastStaffID = Convert.ToInt32(result) + 1;
        }

    }
}
