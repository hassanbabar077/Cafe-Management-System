using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
            SetItemsView();
            FillComboBox();
        }
        //
        // Add Category
        //
        private void AddCategory()
        {
            string sqlstmt = "";
            sqlstmt = "INSERT INTO Category(category_Name) VALUES('" + txt_categoryName.Text +
                                                                    "')";
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
                    con.Close();
                    MessageBox.Show("Category Added");
                    txt_categoryName.Text = "";
                    txt_categoryName.Focus();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        //
        // Button Add Category
        //
        private void btn_addCategory_Click(object sender, EventArgs e)
        {
            if(txt_categoryName.Text != "")
            {
                AddCategory();
            }
            else
            {
                MessageBox.Show("Write name of Category to add");
                txt_categoryName.Focus();
            }
            this.combo_itemCategory.Items.Clear();
            FillComboBox();
        }
        //
        // Fill Combo-Box
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
                combo_itemCategory.Items.Add(reader["category_Name"].ToString());
            }
            reader.Close();
            conn.Close();
        }
        //
        // Filter Grid By Category
        //
        private void FilterByCategory()
        {
            string sqlstmt = "";
            sqlstmt = "SELECT item_ID as ID, item_Name as Name, item_Category as Category,item_Price as Price FROM Items where item_Category='"
                      + combo_itemCategory.SelectedItem.ToString()
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
                grid_itemsList.DataSource = DTt;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        //
        // Fill Category Combo-Box
        //
        private void combo_itemCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCategory();
        }
        //
        // Button Add Item
        //
        private void btn_addItem_Click(object sender, EventArgs e)
        {
            AddItems addItems = new AddItems();
            addItems.ShowDialog();
        }
        //
        // Button Edit Item
        //
        private void btn_editItem_Click(object sender, EventArgs e)
        {
            string item_Id = "";
            item_Id = grid_itemsList[0, grid_itemsList.CurrentCell.RowIndex].Value.ToString();
            UpdateItems updateItems = new UpdateItems(item_Id);    
            updateItems.ShowDialog();
        }
        //
        // Button Delete Item
        //
        private void btn_deleteItem_Click(object sender, EventArgs e)
        {
            string itemID;
            itemID = grid_itemsList[0, grid_itemsList.CurrentCell.RowIndex].Value.ToString();

            string sqlstmt = "";
            sqlstmt = "DELETE FROM Items WHERE item_ID = " + itemID;
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
                con.Close();

                SetItemsView();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        //
        // Set grid Items View
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
            com.Connection = con;      // To specify the connection will be used by command object
            com.CommandText = sqlstmt; // To specify or assignment the sql statement that executed by the command object

            SqlDataAdapter DAA = new SqlDataAdapter(); // To fill the required data into the dataset
            DataSet Dss = new DataSet(); // To store the relation or tables data 

            try
            {
                con.Open(); // to open the connection with sql server
                DAA.SelectCommand = com; // To set the command object used by the data adapter object
                DAA.Fill(Dss);           // Method to fill the dataset
                DataTable DT = Dss.Tables[0]; // To extract the table from the datasets 
                grid_itemsList.DataSource = DT;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        //
        // Button Refresh
        //
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            SetItemsView();
        }

        private void txt_categoryName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_addCategory.Focus();
            }
        }

        private void btn_addCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_addItem.Focus();
            }
        }

        private void btn_addItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_editItem.Focus();
            }
        }

        private void btn_editItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_deleteItem.Focus();
            }
        }

        private void btn_deleteItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_refresh.Focus();
            }
        }
    }
}
