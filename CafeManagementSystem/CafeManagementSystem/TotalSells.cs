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
    public partial class TotalSells : Form
    {
        public TotalSells()
        {
            InitializeComponent();
            SetTotalSellsView();
            FillComboBox();
        }
        //
        //Fill Combo-Box
        //
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
                combo_itemName.Items.Add(reader["item_Name"].ToString());
            }
            reader.Close();
            conn.Close();
        }
        //
        //Filter Grid By Items Name 
        //
        private void FilterByItemName()
        {

            string sqlstmt = "";
            sqlstmt = "SELECT item_no as Sr, item_name as Name,item_price as Unit_Price, item_quantity as Quantity,item_totalPrice as Total_Price, item_orderDate as Date FROM OrderList where item_name='"
                      + combo_itemName.SelectedItem.ToString()
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
                grid_totalSellsList.DataSource = DTt;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        //
        //Set Total Sells View
        //
        private void SetTotalSellsView()
        {

            string sqlstmt = "";
            sqlstmt = "SELECT item_no as Sr, item_name as Name,item_price as Unit_Price, item_quantity as Quantity,item_totalPrice as Total_Price, item_orderDate as Date FROM OrderList";

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
                grid_totalSellsList.DataSource = DT;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        
        private void combo_itemName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByItemName();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            SetTotalSellsView();
        }
    }
}
