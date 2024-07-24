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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void loadDashboard(object Form)
        {
            if(this.pnl_dashboard.Controls.Count > 0)
            {
                this.pnl_dashboard.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnl_dashboard.Controls.Add(f);
            this.pnl_dashboard.Tag = f;
            f.Show();
        }
        //
        //Button Selling Form
        //
        private void btn_selling_Click(object sender, EventArgs e)
        {
            loadDashboard(new TotalSells());
        }
        //
        //Button Items Form
        //
        private void btn_items_Click(object sender, EventArgs e)
        {
            loadDashboard(new Items());
        }
        //
        //Button Logout
        //
        private void lbl_logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
