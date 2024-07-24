namespace CafeManagementSystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btn_selling = new System.Windows.Forms.Button();
            this.btn_items = new System.Windows.Forms.Button();
            this.pnl_dashboard = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_selling
            // 
            this.btn_selling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_selling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_selling.FlatAppearance.BorderSize = 0;
            this.btn_selling.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_selling.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_selling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_selling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selling.ForeColor = System.Drawing.Color.White;
            this.btn_selling.Location = new System.Drawing.Point(3, 307);
            this.btn_selling.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btn_selling.Name = "btn_selling";
            this.btn_selling.Size = new System.Drawing.Size(188, 47);
            this.btn_selling.TabIndex = 1;
            this.btn_selling.Text = "TOTAL SELLS";
            this.btn_selling.UseVisualStyleBackColor = false;
            this.btn_selling.Click += new System.EventHandler(this.btn_selling_Click);
            // 
            // btn_items
            // 
            this.btn_items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_items.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_items.FlatAppearance.BorderSize = 0;
            this.btn_items.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_items.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_items.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_items.ForeColor = System.Drawing.Color.White;
            this.btn_items.Location = new System.Drawing.Point(3, 227);
            this.btn_items.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btn_items.Name = "btn_items";
            this.btn_items.Size = new System.Drawing.Size(188, 47);
            this.btn_items.TabIndex = 0;
            this.btn_items.Text = "ITEMS";
            this.btn_items.UseVisualStyleBackColor = false;
            this.btn_items.Click += new System.EventHandler(this.btn_items_Click);
            // 
            // pnl_dashboard
            // 
            this.pnl_dashboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_dashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_dashboard.Location = new System.Drawing.Point(202, 40);
            this.pnl_dashboard.Name = "pnl_dashboard";
            this.pnl_dashboard.Size = new System.Drawing.Size(1390, 787);
            this.pnl_dashboard.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(202, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1402, 34);
            this.panel1.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.btn_items);
            this.flowLayoutPanel1.Controls.Add(this.btn_selling);
            this.flowLayoutPanel1.Controls.Add(this.lbl_logout);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, -2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(196, 845);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 191);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(88, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "BLISS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(23, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "CAFE";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CafeManagementSystem.Properties.Resources.Untitled_design__7__fotor_bg_remover_20240721101529;
            this.pictureBox3.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(196, 191);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_logout.Location = new System.Drawing.Point(60, 797);
            this.lbl_logout.Margin = new System.Windows.Forms.Padding(60, 440, 3, 0);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(82, 20);
            this.lbl_logout.TabIndex = 2;
            this.lbl_logout.Text = "LOGOUT";
            this.lbl_logout.Click += new System.EventHandler(this.lbl_logout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1604, 839);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_dashboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_selling;
        private System.Windows.Forms.Button btn_items;
        private System.Windows.Forms.Panel pnl_dashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_logout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}