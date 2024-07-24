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
    public partial class UpdateItems : Form
    {
        private string itemId;
        public UpdateItems(string itemId)
        {
            InitializeComponent();
            UpdateItemInfo(itemId);
            FillComboBox();
            this.itemId = itemId;
        }
        //
        //Update item Info
        //
        public void UpdateItemInfo(string itemId)
        {
            string query = "";
            query = "SELECT * FROM Items WHERE item_ID=" + itemId;

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
                lbl_itemId1.Text = DT.Rows[0]["item_ID"].ToString();
                txt_itemName.Text = DT.Rows[0]["item_Name"].ToString();
                combo_itemCategory.Text = DT.Rows[0]["item_Category"].ToString();
                txt_itemPrice.Text = DT.Rows[0]["item_Price"].ToString();
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        //
        //Button Update Item
        //
        private void btn_updateItem_Click(object sender, EventArgs e)
        {
            if (txt_itemName.Text == "")
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
                sqlstmt = "UPDATE Items SET item_Name = '" + txt_itemName.Text +
                                            "',item_Category = '" + combo_itemCategory.Text +
                                            "',item_Price = '" + txt_itemPrice.Text +
                                            "' WHERE item_ID=" + lbl_itemId1.Text;
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
                    this.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }
        //
        //Fill Combo-Box
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
            InitializeComponent();
            UpdateItemInfo(itemId);
            
            FillComboBox();
        }
        //
        //Button Close
        //
        private void btn_close_Click(object sender, EventArgs e)
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
                btn_updateItem.Focus();
            }
        }
    }
}
