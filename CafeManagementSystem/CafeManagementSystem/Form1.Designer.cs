namespace CafeManagementSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_selling = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_username.Location = new System.Drawing.Point(48, 99);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(83, 20);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.Location = new System.Drawing.Point(52, 122);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(239, 26);
            this.txt_username.TabIndex = 0;
            this.txt_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_username_KeyDown);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.Location = new System.Drawing.Point(52, 181);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(239, 26);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_password.Location = new System.Drawing.Point(48, 158);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(78, 20);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(52, 246);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(239, 28);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.Enter += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_selling
            // 
            this.lbl_selling.AutoSize = true;
            this.lbl_selling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_selling.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_selling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selling.ForeColor = System.Drawing.Color.Red;
            this.lbl_selling.Location = new System.Drawing.Point(129, 326);
            this.lbl_selling.Name = "lbl_selling";
            this.lbl_selling.Size = new System.Drawing.Size(78, 20);
            this.lbl_selling.TabIndex = 3;
            this.lbl_selling.Text = "SELLING";
            this.lbl_selling.Click += new System.EventHandler(this.lbl_selling_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CafeManagementSystem.Properties.Resources.Untitled_design__7__fotor_bg_remover_20240721101529;
            this.pictureBox3.Location = new System.Drawing.Point(347, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(216, 207);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = global::CafeManagementSystem.Properties.Resources.close;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(602, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(20, 18);
            this.btn_close.TabIndex = 4;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(353, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "CAFE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(444, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "BLISS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(634, 384);
            this.ControlBox = false;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_selling);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_selling;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

