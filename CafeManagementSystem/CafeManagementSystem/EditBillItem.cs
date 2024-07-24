using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class EditBillItem : Form
    {

        SqlConnection conn = new SqlConnection("Integrated Security=true;" +  
                                       "Data Source='DESKTOP-MK4C3FA\\SQLEXPRESS';" + 
                                       "Initial Catalog=CafeManagementSystem;");
        SqlCommand cmd = new SqlCommand();
        private string itemId;
        private DataTable table1;
        private int editedIndex;
        public EditBillItem(string itemId, DataTable table1)
        {
            InitializeComponent();
            FillComboBox();
            UpdateItemInfo(itemId);
            this.itemId = itemId;
            this.table1 = table1;
            total();
        }
        private void EditBillItem_Load(object sender, EventArgs e)
        {
            total();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void combo_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select item_Name,item_Price from Items where item_Name='"+combo_item.Text+"'",conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                string price = (string)dr["item_Price"].ToString();
                lbl_price.Text = price;
            }
            conn.Close();
            UpdateTotalPriceLabel();
        }
        private void UpdateTotalPriceLabel()
        {
            int selectedIndex = combo_item.SelectedIndex;
            int quantity = GetQuantityValue();
            if (selectedIndex >= 0)
            {
                int totalPrice;
                using (SqlConnection con = new SqlConnection("Integrated Security=true;" +
                                       "Data Source='DESKTOP-MK4C3FA\\SQLEXPRESS';" +
                                       "Initial Catalog=CafeManagementSystem;"))
                {
                    try
                    {
                        con.Open();
                        string query = $"SELECT item_Price FROM Items WHERE item_Name = @itemName";
                        SqlCommand com = new SqlCommand(query, con);
                        com.Parameters.AddWithValue("@itemName", combo_item.Text); // Use combo_item.Text for item name
                        using (SqlDataReader reader = com.ExecuteReader())
                        {
                            if (reader.Read()) // Check if a record is found
                            {
                                int price = Convert.ToInt32(reader["item_Price"]);
                                totalPrice = price * quantity;
                            }
                            else
                            {
                                totalPrice = 0;
                                lbl_total.Text = "Price not found for selected item: " + combo_item.Text;
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error connecting to database: " + ex.Message);
                        totalPrice = 0; 
                    }
                }
                lbl_total.Text = totalPrice.ToString("0");
            }
            else
            {
                lbl_total.Text = "Please select an item.";
            }
        }
        private int GetQuantityValue()
        {
            int quantity;
            try
            {
                quantity = Convert.ToInt32(txt_quantity.Text); 
            }
            catch (FormatException)
            {
                quantity = 0; 
                txt_quantity.Text = ""; 
            }
            return quantity;
        }
        public void FillComboBox()
        {
            string sqlQuery = "";
            sqlQuery = "SELECT item_Name FROM Items";
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Integrated Security=true;" + // Windows Security 
                                   "Data Source='DESKTOP-MK4C3FA\\SQLEXPRESS';" + // This is the name of sql server
                                   "Initial Catalog=CafeManagementSystem;"; // This is specified the name of the database
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;      // To specify the connection will be used by command object
            comm.CommandText = sqlQuery;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                combo_item.Items.Add(reader["item_Name"].ToString());
            }
            reader.Close();
            conn.Close();
        }
        string a;
        private void txt_quantity_TextChanged_1(object sender, EventArgs e)
        {
            UpdateTotalPriceLabel();
        }

        private void total()
        {
            int sum2 = Convert.ToInt32(lbl_price.Text) * Convert.ToInt32(txt_quantity.Text);
            lbl_total.Text = Convert.ToString(sum2);
        }
        public void UpdateItemInfo(string itemId)
        {
            string query = "";
            query = "SELECT item_no,item_name,item_price,item_quantity,item_totalPrice from OrderList WHERE item_no=" + itemId;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Integrated Security=true;" +
                                   " Initial Catalog=CafeManagementSystem;" +
                                   " Data Source='DESKTOP-MK4C3FA\\SQLEXPRESS';";
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = query;
            SqlDataAdapter DAA = new SqlDataAdapter();
            DataSet DS = new DataSet();
            DataTable DT = new DataTable();
            DAA.SelectCommand = com;
            try
            {
                con.Open();
                DAA.Fill(DS);
                DT = DS.Tables[0];

                lbl_itemId1.Text = DT.Rows[0]["item_no"].ToString();
                combo_item.Text = DT.Rows[0]["item_name"].ToString();

                lbl_price.Text = DT.Rows[0]["item_price"].ToString();
                txt_quantity.Text = DT.Rows[0]["item_quantity"].ToString();

                a = DT.Rows[0]["item_totalPrice"].ToString();
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            total();
        }

        public delegate void OnDataUpdated(object sender, int editedIndex, string no1, string name1, int price1, int quantity1, int total1); // Define the event delegate
        public event OnDataUpdated DataUpdated; // Declare the event
        private void btn_updateItem_Click(object sender, EventArgs e)
        {
            if (combo_item.Text == "")
            {
                MessageBox.Show("Please select item");
                combo_item.Focus();
            }
            else if (txt_quantity.Text == "")
            {
                MessageBox.Show("Please enter quantity");
                txt_quantity.Focus();
            }
            else
            {
                string sqlstmt = "";
                sqlstmt = "UPDATE OrderList SET item_name = '" + combo_item.Text +
                                            "',item_price = '" + lbl_price.Text +
                                            "',item_quantity = '" + txt_quantity.Text +
                                            "',item_totalPrice= '" + lbl_total.Text +
                                            "' WHERE item_no=" + lbl_itemId1.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Integrated Security=true;" + // Windows Security 
                                       "Data Source='DESKTOP-MK4C3FA\\SQLEXPRESS';" + // This is the name of sql server
                                       "Initial Catalog=CafeManagementSystem;"; // This is specified the name of the database

                SqlCommand com = new SqlCommand();
                com.Connection = con;      // To specify the connection will be used by command object
                com.CommandText = sqlstmt; // To specify or assignment the sql statement that executed by the command object

                try
                {
                    con.Open(); // to open the connection with sql server
                    com.ExecuteNonQuery(); // to execute the specified sql query against opened connection
                    int sum2 = Convert.ToInt32(lbl_price.Text) * Convert.ToInt32(txt_quantity.Text);
                    lbl_total.Text = Convert.ToString(sum2);
                    con.Close();
                    this.Close();

                    if (editedIndex >= 0) // Check if a row is selected for editing
                    {
                        string no1 = lbl_itemId1.Text;
                        string name1 = combo_item.Text;
                        int price1 = int.Parse(lbl_price.Text);
                        int quantity1 = int.Parse(txt_quantity.Text);
                        int total1 = int.Parse(lbl_total.Text);

                        // Trigger the event with updated information
                        DataUpdated.Invoke(this, editedIndex, no1,name1, price1, quantity1, total1); // Raise the event (null-conditional operator to avoid issues if no subscribers)
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            UpdateItemInfo(itemId);

            FillComboBox();
        }
    }
}
