using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        //button Login
        //
        private void btn_login_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
           /* if(txt_username.Text == "Admin" && txt_password.Text == "Password")
            {
            }
            else if(txt_username.Text == "" && txt_password.Text == "")
            {
                MessageBox.Show("Enter username or password");

            }
            else
            {
                MessageBox.Show("Wrong username or password");
                txt_username.Text = "";
                txt_password.Text = "";
            }*/
        }
        //
        //Button Close
        //
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void lbl_selling_Click(object sender, EventArgs e)
        {
            Selling selling = new Selling();
            selling.Show();
            this.Hide();
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.Focus();
            }
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }
    }
}
