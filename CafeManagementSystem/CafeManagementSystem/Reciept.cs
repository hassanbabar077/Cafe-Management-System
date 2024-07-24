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
    public partial class Reciept : Form
    {
        public Reciept()
        {
            InitializeComponent();

        }

        public void SetData(DataGridView dataSource,string total,String date)
        {
            grid_reciept.DataSource = dataSource.DataSource;
            lbl_totalP.Text = total.ToString();
            lbl_date.Text = date.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Selling selling = new Selling();
            selling.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
