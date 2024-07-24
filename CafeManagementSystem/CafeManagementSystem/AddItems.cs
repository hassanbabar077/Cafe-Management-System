
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeManagementSystem
{
    public partial class AddItems : Form
    {
        public AddItems()
        {
            InitializeComponent();
            SetItemID();
            FillComboBox();
        }
        //
        //Set Item Id
        //
        private void SetItemID()
        {
            int itemID = 0;
            string sqlstmt = "";
            sqlstmt = "SELECT isnull(max(item_Id),0)+1 FROM Items";

            // This is  type (class) used to establish connection with sql server 
            SqlConnection con = new SqlConnection();

            // To set the property of connection object, ConnectionString 
            con.ConnectionString = "Integrated Security=true;" + // Windows Security 
                                   "Data Source='DESKTOP-MK4C3FA\\SQLEXPRESS';" + // This is the name of sql server
                                   "Initial Catalog=CafeManagementSystem;"; // This is specified the name of the database

            // To execute the sql statement against an opened connection 
            SqlCommand com = new SqlCommand();
            com.Connection = con;      // To specify the connection will be used by command object
            com.CommandText = sqlstmt; // To specify or assignment the sql statement that executed by the command object

            try
            {
                con.Open(); // to open the connection with sql server                
                itemID = Convert.ToInt32(com.ExecuteScalar()); // To retrieve the single scaler (numeric) value
                con.Close();

                lbl_itemId1.Text = itemID.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        //
        //Button Add Item
        //
        private void btn_addItem_Click(object sender, EventArgs e)
        {
                if (txt_itemName.Text=="")
                {
                    MessageBox.Show("Please enter name of item");
                    txt_itemName.Focus();
                }
                else if (combo_itemCategory.Text == "")
                {
                    MessageBox.Show("Please enter name of item");
                    combo_itemCategory.Focus();
                }
                else if (txt_itemPrice.Text == "")
                    {
                        MessageBox.Show("Please enter name of item");
                        txt_itemPrice.Focus();
                    }
                else
                    {
                    string sqlstmt = "";
                    sqlstmt = "INSERT INTO Items( item_Id,item_Name,item_Category,item_Price) VALUES(" + lbl_itemId1.Text +
                                                                           ",'" + txt_itemName.Text +
                                                                            "','" + combo_itemCategory.Text +
                                                                            "','" + txt_itemPrice.Text +
                                                                            "')";

                    // This is  type (class) used to establish connection with sql server 
                    SqlConnection con = new SqlConnection();

                    // To set the property of connection object, ConnectionString 
                    con.ConnectionString = "Integrated Security=true;" + // Windows Security 
                                           "Data Source='DESKTOP-MK4C3FA\\SQLEXPRESS';" + // This is the name of sql server
                                           "Initial Catalog=CafeManagementSystem;"; // This is specified the name of the database

                    // To execute the sql statement against an opened connection 
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;      // To specify the connection will be used by command object
                    com.CommandText = sqlstmt; // To specify or assignment the sql statement that executed by the command object

                    try
                    {
                        con.Open(); // to open the connection with sql server
                        com.ExecuteNonQuery(); // to execute the specified sql query against opened connection
                        con.Close();
                        SetItemID();
                        txt_itemName.Text = "";
                        combo_itemCategory.Text = "";
                        txt_itemPrice.Text = "";
                        txt_itemName.Focus();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                }
        }
        //
        //Fill Combo Box
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
        //Button Clear
        //
        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            this.SetItemID();
            this.FillComboBox();
        }
        //
        //Button Close
        //
        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_itemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                combo_itemCategory.Focus();
            }
        }

        private void combo_itemCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_itemPrice.Focus();
            }
        }

        private void txt_itemPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_addItem.Focus();
            }
        }
    }
}
