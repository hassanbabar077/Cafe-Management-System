namespace CafeManagementSystem
{
    partial class Items
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
            this.btn_addItem = new System.Windows.Forms.Button();
            this.btn_editItem = new System.Windows.Forms.Button();
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.grid_itemsList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_addCategory = new System.Windows.Forms.Label();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.txt_categoryName = new System.Windows.Forms.TextBox();
            this.lbl_categoryName = new System.Windows.Forms.Label();
            this.lbl_itemsList = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.combo_itemCategory = new System.Windows.Forms.ComboBox();
            this.lbl_itemCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_itemsList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addItem
            // 
            this.btn_addItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_addItem.FlatAppearance.BorderSize = 0;
            this.btn_addItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_addItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItem.ForeColor = System.Drawing.Color.White;
            this.btn_addItem.Location = new System.Drawing.Point(35, 36);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(215, 42);
            this.btn_addItem.TabIndex = 2;
            this.btn_addItem.Text = "Add Item";
            this.btn_addItem.UseVisualStyleBackColor = false;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            this.btn_addItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_addItem_KeyDown);
            // 
            // btn_editItem
            // 
            this.btn_editItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editItem.FlatAppearance.BorderSize = 0;
            this.btn_editItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_editItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editItem.ForeColor = System.Drawing.Color.White;
            this.btn_editItem.Location = new System.Drawing.Point(35, 90);
            this.btn_editItem.Name = "btn_editItem";
            this.btn_editItem.Size = new System.Drawing.Size(215, 42);
            this.btn_editItem.TabIndex = 3;
            this.btn_editItem.Text = "Edit Item";
            this.btn_editItem.UseVisualStyleBackColor = false;
            this.btn_editItem.Click += new System.EventHandler(this.btn_editItem_Click);
            this.btn_editItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_editItem_KeyDown);
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_deleteItem.FlatAppearance.BorderSize = 0;
            this.btn_deleteItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_deleteItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_deleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteItem.ForeColor = System.Drawing.Color.White;
            this.btn_deleteItem.Location = new System.Drawing.Point(35, 144);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(215, 42);
            this.btn_deleteItem.TabIndex = 4;
            this.btn_deleteItem.Text = "Delete Item";
            this.btn_deleteItem.UseVisualStyleBackColor = false;
            this.btn_deleteItem.Click += new System.EventHandler(this.btn_deleteItem_Click);
            this.btn_deleteItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_deleteItem_KeyDown);
            // 
            // grid_itemsList
            // 
            this.grid_itemsList.AllowUserToAddRows = false;
            this.grid_itemsList.AllowUserToDeleteRows = false;
            this.grid_itemsList.AllowUserToResizeRows = false;
            this.grid_itemsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_itemsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_itemsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grid_itemsList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_itemsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_itemsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_itemsList.ColumnHeadersHeight = 40;
            this.grid_itemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_itemsList.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_itemsList.EnableHeadersVisualStyles = false;
            this.grid_itemsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grid_itemsList.Location = new System.Drawing.Point(375, 102);
            this.grid_itemsList.Name = "grid_itemsList";
            this.grid_itemsList.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_itemsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_itemsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_itemsList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_itemsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_itemsList.Size = new System.Drawing.Size(970, 645);
            this.grid_itemsList.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_addCategory);
            this.panel1.Controls.Add(this.btn_addCategory);
            this.panel1.Controls.Add(this.txt_categoryName);
            this.panel1.Controls.Add(this.lbl_categoryName);
            this.panel1.Location = new System.Drawing.Point(44, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 208);
            this.panel1.TabIndex = 12;
            // 
            // lbl_addCategory
            // 
            this.lbl_addCategory.AutoSize = true;
            this.lbl_addCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_addCategory.Location = new System.Drawing.Point(46, 22);
            this.lbl_addCategory.Name = "lbl_addCategory";
            this.lbl_addCategory.Size = new System.Drawing.Size(192, 31);
            this.lbl_addCategory.TabIndex = 10;
            this.lbl_addCategory.Text = "Add Category";
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_addCategory.FlatAppearance.BorderSize = 0;
            this.btn_addCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_addCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCategory.ForeColor = System.Drawing.Color.White;
            this.btn_addCategory.Location = new System.Drawing.Point(35, 136);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(215, 36);
            this.btn_addCategory.TabIndex = 1;
            this.btn_addCategory.Text = "Add ";
            this.btn_addCategory.UseVisualStyleBackColor = false;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            this.btn_addCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_addCategory_KeyDown);
            // 
            // txt_categoryName
            // 
            this.txt_categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoryName.Location = new System.Drawing.Point(35, 101);
            this.txt_categoryName.Name = "txt_categoryName";
            this.txt_categoryName.Size = new System.Drawing.Size(215, 29);
            this.txt_categoryName.TabIndex = 0;
            this.txt_categoryName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_categoryName_KeyDown);
            // 
            // lbl_categoryName
            // 
            this.lbl_categoryName.AutoSize = true;
            this.lbl_categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_categoryName.Location = new System.Drawing.Point(31, 72);
            this.lbl_categoryName.Name = "lbl_categoryName";
            this.lbl_categoryName.Size = new System.Drawing.Size(66, 24);
            this.lbl_categoryName.TabIndex = 11;
            this.lbl_categoryName.Text = "Name:";
            // 
            // lbl_itemsList
            // 
            this.lbl_itemsList.AutoSize = true;
            this.lbl_itemsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_itemsList.Location = new System.Drawing.Point(736, 56);
            this.lbl_itemsList.Name = "lbl_itemsList";
            this.lbl_itemsList.Size = new System.Drawing.Size(163, 37);
            this.lbl_itemsList.TabIndex = 15;
            this.lbl_itemsList.Text = "Items List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.btn_addItem);
            this.panel2.Controls.Add(this.btn_editItem);
            this.panel2.Controls.Add(this.btn_deleteItem);
            this.panel2.Location = new System.Drawing.Point(44, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 405);
            this.panel2.TabIndex = 13;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(35, 328);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(215, 42);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // combo_itemCategory
            // 
            this.combo_itemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_itemCategory.FormattingEnabled = true;
            this.combo_itemCategory.Location = new System.Drawing.Point(375, 63);
            this.combo_itemCategory.Name = "combo_itemCategory";
            this.combo_itemCategory.Size = new System.Drawing.Size(223, 32);
            this.combo_itemCategory.TabIndex = 6;
            this.combo_itemCategory.SelectionChangeCommitted += new System.EventHandler(this.combo_itemCategory_SelectionChangeCommitted);
            // 
            // lbl_itemCategory
            // 
            this.lbl_itemCategory.AutoSize = true;
            this.lbl_itemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_itemCategory.Location = new System.Drawing.Point(371, 36);
            this.lbl_itemCategory.Name = "lbl_itemCategory";
            this.lbl_itemCategory.Size = new System.Drawing.Size(90, 24);
            this.lbl_itemCategory.TabIndex = 14;
            this.lbl_itemCategory.Text = "Category:";
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1390, 787);
            this.Controls.Add(this.combo_itemCategory);
            this.Controls.Add(this.lbl_itemCategory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_itemsList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_itemsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Items";
            this.Text = "Items";
            ((System.ComponentModel.ISupportInitialize)(this.grid_itemsList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_editItem;
        private System.Windows.Forms.Button btn_deleteItem;
        private System.Windows.Forms.DataGridView grid_itemsList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.TextBox txt_categoryName;
        private System.Windows.Forms.Label lbl_categoryName;
        private System.Windows.Forms.Label lbl_itemsList;
        private System.Windows.Forms.Label lbl_addCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ComboBox combo_itemCategory;
        private System.Windows.Forms.Label lbl_itemCategory;
    }
}