using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeManagementSystem
{
    public partial class Selling : Form
    {
        public Selling()
        {
            InitializeComponent();
            SetItemsView();
            FillComboBox();
        }
        //
        // Set Items View Grid
        //
        private void SetItemsView()
        {
            string sqlstmt = "";
            sqlstmt = "SELECT item_ID as ID, item_Name as Name, item_Category as Category,item_Price as Price FROM Items";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Integrated Security=true;" + // Windows Security 
                                   "Data Source='DESKTOP-MK4C3FA\\SQLEXPRESS';" + // This is the name of sql server
                                   "Initial Catalog=CafeManagementSystem;"; // This is specified the name of the database
            SqlCommand com = new SqlCommand();
            com.Connection = con;      
            com.CommandText = sqlstmt;

            SqlDataAdapter DAA = new SqlDataAdapter(); 
            DataSet Dss = new DataSet();

            try
            {
                con.Open();
                DAA.SelectCommand = com;
                DAA.Fill(Dss);          
                DataTable DT = Dss.Tables[0];
                grid_itemList.DataSource = DT;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        //
        // REFRESH BUTTON
        //
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            this.SetItemsView();
            this.table1 = new DataTable();
            load();
        }
        //
        // Fill COMBO-BOX
        //
        public void FillComboBox()
        {
            string sqlQuery = "";
            sqlQuery = "SELECT category_Name FROM Category";
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
                cb_category.Items.Add(reader["category_Name"].ToString());
            }
            reader.Close();
            conn.Close();
        }
        //
        //FILTER ITEM GRID VIEW BY CATEGORY
        //
        private void FilterByCategory()
        {
            string sqlstmt = "";
            sqlstmt = "SELECT item_ID as ID, item_Name as Name, item_Category as Category,item_Price as Price FROM Items where item_Category='"
                      + cb_category.SelectedItem.ToString()
                      + "'";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Integrated Security=true;" + // Windows Security 
                                   "Data Source='DESKTOP-MK4C3FA\\SQLEXPRESS';" + // This is the name of sql server
                                   "Initial Catalog=CafeManagementSystem;"; // This is specified the name of the database
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;      // To specify the connection will be used by command object
            comm.CommandText = sqlstmt; // To specify or assignment the sql statement that executed by the command object
            SqlDataAdapter DA = new SqlDataAdapter(); // To fill the required data into the dataset
            DataSet Ds = new DataSet(); // To store the relation or tables data 

            try
            {
                conn.Open(); // to open the connection with sql server
                DA.SelectCommand = comm; // To set the command object used by the data adapter object
                DA.Fill(Ds);           // Method to fill the dataset
                DataTable DTt = Ds.Tables[0]; // To extract the table from the datasets 
                grid_itemList.DataSource = DTt;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        //
        // Combo-Box Filter Grid By Category
        //
        private void cb_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCategory();
        }
        int itemno = 0;
        int select = 0;
        String item=null;
        int price=0, total=0, sum=0;
        DataTable table1 = new DataTable();
        //
        // Set Order ID
        //
        private void SetOrderID()
        {
            string sqlstmt = "";
            sqlstmt = "SELECT isnull(max(item_no),0)+1 FROM OrderList";
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
                itemno = Convert.ToInt32(com.ExecuteScalar()); // To retrieve the single scaler (numeric) value
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        //
        // Button Add To Bill
        //
        int totalPrice = 0;
        int price2 = 0;

        private void btn_addToBill_Click(object sender, EventArgs e)
        {
            if (txt_quantity.Text == "")
            {
                MessageBox.Show("Enter Quantity");
            }
            else if (select == 0)
            {
                MessageBox.Show("Select item");
            }
            else
            {
                SetOrderID();
                select = 1;
                total = price * Convert.ToInt32(txt_quantity.Text);
                string sqlstmt = "";

                sqlstmt = "INSERT INTO OrderList(item_no,item_name,item_price, item_quantity, item_totalPrice,item_orderDate) VALUES(" + itemno +
                                                                        ",'" + item +
                                                                        "','" + price +
                                                                        "','" + txt_quantity.Text +
                                                                        "','" + total +
                                                                        "','" + lbl_date.Text +
                                                                        "')";
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Integrated Security=true;" + // Windows Security 
                                       "Data Source='DESKTOP-MK4C3FA\\SQLEXPRESS';" + // This is the name of sql server
                                       "Initial Catalog=CafeManagementSystem;"; // This is specified the name of the database
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;      // To specify the connection will be used by command object
                comm.CommandText = sqlstmt; // To specify or assignment the sql statement that executed by the command object

                try
                {
                    conn.Open(); // to open the connection with sql server
                    comm.ExecuteNonQuery(); // to execute the specified sql query against opened connection
                    conn.Close();
                    table1.Rows.Add(itemno, item, price, txt_quantity.Text, total);
                    grid_orderBill.DataSource = table1;
                    txt_quantity.Text = "";
                    txt_quantity.Focus();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                totalChange();
            }
        }
        private void grid_itemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            item = Convert.ToString(grid_itemList.SelectedRows[0].Cells[1].Value.ToString());
            price = Convert.ToInt32(grid_itemList.SelectedRows[0].Cells[3].Value.ToString());
            txt_quantity.Focus();
            select = 1;
        }
        //
        // Button To Print Bill
        //
        private void btn_print_Click(object sender, EventArgs e)
        {
            if (grid_orderBill.Rows.Count == 0)
            {
                MessageBox.Show("Select an item");
            }
            else
            {
                var secondForm = new Reciept();
                secondForm.SetData(grid_orderBill, lbl_orderTotalPrice.Text, lbl_date.Text); // Pass the data (dataGridView1) to the second
                secondForm.Show();// Show the second form
            }
            this.table1 = new DataTable();
            load();
            lbl_orderTotalPrice.Text = "Rs.00";

            /*if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
             {
                 printDocument1.Print();
             }*/
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Cafe Bliss", new Font("Microsoft Sans Serif", 30, FontStyle.Bold), Brushes.Black, new Point(310, 20));
            Bitmap bm = new Bitmap(this.grid_orderBill.Width, this.grid_orderBill.Height);
            grid_orderBill.DrawToBitmap(bm, new Rectangle(0, 0, this.grid_orderBill.Width, this.grid_orderBill.Height));
            e.Graphics.DrawImage(bm, 1, 90);
            e.Graphics.DrawString("Total Amount = " + lbl_orderTotalPrice.Text.ToString(), new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, 30, 400);
            e.Graphics.DrawString(lbl_date.Text.ToString(), new Font("Microsoft Sans Serif", 12, FontStyle.Bold), Brushes.Black, 30, 430);

        }
        //
        // Button Login
        //
        private void lbl_login_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void txt_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if(grid_itemList.Rows.Count != 0) {
                if (e.KeyCode == Keys.Enter)
                {
                    btn_addToBill.Focus();
                }
            }
            else
            {
                MessageBox.Show("Select an item");
            }
        }
        private void lbl_orderTotalPrice_Click(object sender, EventArgs e)
        {
            int sum2 = 0;
            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in grid_orderBill.Rows)
            {
                if (row.Cells[4].Value != null)   // Get the cell value (assuming the target column is the second column with index 1)
                {
                    // Check if the value can be converted to an integer
                    if (int.TryParse(Convert.ToString(row.Cells[4].Value), out int value))
                    {
                        sum2 += value;
                    }
                }
            }
            // Display the sum on the label
            lbl_orderTotalPrice.Text = "Rs."+sum2.ToString();
        }

        private void Selling_Load(object sender, EventArgs e)
        {
            load();
            lbl_date.Text = DateTime.Now.ToString();

        }
        public delegate void OnDataTableUpdated(int editedIndex, string no1, string name1, int price1, int quantity1, int total1); // Define an event delegate with specific update data
        private void btn_editOrderItem_Click(object sender, EventArgs e)
        {
            string item_Id = "";
            item_Id = grid_orderBill[0, grid_orderBill.CurrentCell.RowIndex].Value.ToString();
            EditBillItem editItems = new EditBillItem(item_Id, table1);
            editItems.DataUpdated += EditForm_OnDataUpdated;
            editItems.ShowDialog(this);
            grid_orderBill.Refresh();

        }
        private void grid_orderBill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in grid_orderBill.Rows)
            {
                // Get the price cell (assuming the price is in the second column)
                if (row.Cells[4].EditedFormattedValue != null)
                {
                    // Price is edited, get the new value
                    price2 = Convert.ToInt32(row.Cells[4].Value);
                }
                else
                {
                    // Price is not edited, get the original value
                    price2 = Convert.ToInt32(row.Cells[4].Value);
                }

                totalPrice = totalPrice + price2;
            }
            // Display the total price
            lbl_orderTotalPrice.Text = totalPrice.ToString("Rs.00"); // Format as currency
        }

        private void EditForm_OnDataUpdated(object sender, int editedIndex, string no1, string name1, int price1, int quantity1, int total) // Event handler for updates
        {
            editedIndex = Convert.ToInt32(grid_orderBill.CurrentCell.RowIndex); 
            if (editedIndex >= 0)
            {
                table1.Rows[editedIndex]["No:"] = no1;
                table1.Rows[editedIndex]["Name"] = name1;
                table1.Rows[editedIndex]["Price"] = price1;
                table1.Rows[editedIndex]["Quantity"] = quantity1;
                table1.Rows[editedIndex]["Total"] = total;
                grid_orderBill.DataSource = table1;
                // Update UI in Form1 (if necessary)
            }
            totalChange();
        }

        private void btn_dltOrderItem_Click(object sender, EventArgs e)
        {
            int rowIndex = grid_orderBill.SelectedCells[1].RowIndex;
            string itemNo = grid_orderBill[0, grid_orderBill.CurrentCell.RowIndex].Value.ToString();
            string itemPrice = grid_orderBill[4, grid_orderBill.CurrentCell.RowIndex].Value.ToString();

            string deleteQuery = "DELETE FROM OrderList WHERE item_no =" + itemNo;

            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Integrated Security=true;" + // Windows Security 
                                   "Data Source='DESKTOP-MK4C3FA\\SQLEXPRESS';" + // This is the name of sql server
                                   "Initial Catalog=CafeManagementSystem;"; // This is specified the name of the database
            SqlCommand com = new SqlCommand();
            com.Connection = con;      // To specify the connection will be used by command object
            com.CommandText = deleteQuery; // To specify or assignment the sql statement that executed by the command object

            try
            {
                con.Open(); // to open the connection with sql server
                com.ExecuteNonQuery(); // to execute the specified sql query against opened connection
                con.Close();
                grid_orderBill.Rows.RemoveAt(rowIndex);
                int a = int.Parse(itemPrice);
                int b = int.Parse(Convert.ToString(sum));
                int c = b - a;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            totalChange();
        }

        private void totalChange()
        {
            int sum2 = 0;

            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in grid_orderBill.Rows)
            {
                // Get the cell value (assuming the target column is the second column with index 1)
                if (row.Cells[4].Value != null)
                {
                    // Check if the value can be converted to an integer
                    if (int.TryParse(Convert.ToString(row.Cells[4].Value), out int value))
                    {
                        // Add the integer value to the sum
                        sum2 += value;
                    }
                }
            }
            // Display the sum on the label
            lbl_orderTotalPrice.Text = "Rs." + sum2.ToString();
        }
        private void load()
        {
            table1.Columns.Add("No:", typeof(int));
            table1.Columns.Add("Name", typeof(string));
            table1.Columns.Add("Price", typeof(int));
            table1.Columns.Add("Quantity", typeof(int));
            table1.Columns.Add("Total", typeof(int));
            grid_orderBill.DataSource = table1;
        }
    }
}
