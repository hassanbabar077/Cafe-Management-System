namespace CafeManagementSystem
{
    partial class TotalSells
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_totalSelling = new System.Windows.Forms.Label();
            this.combo_itemName = new System.Windows.Forms.ComboBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.grid_totalSellsList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_totalSellsList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_totalSelling
            // 
            this.lbl_totalSelling.AutoSize = true;
            this.lbl_totalSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalSelling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_totalSelling.Location = new System.Drawing.Point(594, 56);
            this.lbl_totalSelling.Name = "lbl_totalSelling";
            this.lbl_totalSelling.Size = new System.Drawing.Size(206, 37);
            this.lbl_totalSelling.TabIndex = 7;
            this.lbl_totalSelling.Text = "Total Selling";
            // 
            // combo_itemName
            // 
            this.combo_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_itemName.FormattingEnabled = true;
            this.combo_itemName.Location = new System.Drawing.Point(45, 69);
            this.combo_itemName.Name = "combo_itemName";
            this.combo_itemName.Size = new System.Drawing.Size(223, 32);
            this.combo_itemName.TabIndex = 0;
            this.combo_itemName.SelectionChangeCommitted += new System.EventHandler(this.combo_itemName_SelectionChangeCommitted);
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_item.Location = new System.Drawing.Point(41, 42);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(50, 24);
            this.lbl_item.TabIndex = 59;
            this.lbl_item.Text = "Item:";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_refresh.CausesValidation = false;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(274, 69);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(134, 31);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // grid_totalSellsList
            // 
            this.grid_totalSellsList.AllowUserToAddRows = false;
            this.grid_totalSellsList.AllowUserToDeleteRows = false;
            this.grid_totalSellsList.AllowUserToResizeRows = false;
            this.grid_totalSellsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_totalSellsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_totalSellsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grid_totalSellsList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_totalSellsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_totalSellsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_totalSellsList.ColumnHeadersHeight = 40;
            this.grid_totalSellsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_totalSellsList.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_totalSellsList.EnableHeadersVisualStyles = false;
            this.grid_totalSellsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grid_totalSellsList.Location = new System.Drawing.Point(45, 105);
            this.grid_totalSellsList.Name = "grid_totalSellsList";
            this.grid_totalSellsList.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_totalSellsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_totalSellsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_totalSellsList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_totalSellsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_totalSellsList.Size = new System.Drawing.Size(1294, 628);
            this.grid_totalSellsList.TabIndex = 2;
            // 
            // TotalSells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1390, 787);
            this.Controls.Add(this.grid_totalSellsList);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.combo_itemName);
            this.Controls.Add(this.lbl_item);
            this.Controls.Add(this.lbl_totalSelling);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TotalSells";
            this.Text = "TotalSells";
            ((System.ComponentModel.ISupportInitialize)(this.grid_totalSellsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_totalSelling;
        private System.Windows.Forms.ComboBox combo_itemName;
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView grid_totalSellsList;
    }
}