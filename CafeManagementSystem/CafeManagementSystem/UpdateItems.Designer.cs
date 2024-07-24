namespace CafeManagementSystem
{
    partial class UpdateItems
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
            this.btn_updateItem = new System.Windows.Forms.Button();
            this.txt_itemPrice = new System.Windows.Forms.TextBox();
            this.lbl_itemPrice = new System.Windows.Forms.Label();
            this.combo_itemCategory = new System.Windows.Forms.ComboBox();
            this.lbl_itemCategory = new System.Windows.Forms.Label();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.lbl_itemName = new System.Windows.Forms.Label();
            this.lbl_editItem = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_itemId1 = new System.Windows.Forms.Label();
            this.lbl_itemId2 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_updateItem
            // 
            this.btn_updateItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_updateItem.FlatAppearance.BorderSize = 0;
            this.btn_updateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateItem.ForeColor = System.Drawing.Color.White;
            this.btn_updateItem.Location = new System.Drawing.Point(59, 369);
            this.btn_updateItem.Name = "btn_updateItem";
            this.btn_updateItem.Size = new System.Drawing.Size(142, 30);
            this.btn_updateItem.TabIndex = 3;
            this.btn_updateItem.Text = "Save";
            this.btn_updateItem.UseVisualStyleBackColor = false;
            this.btn_updateItem.Click += new System.EventHandler(this.btn_updateItem_Click);
            // 
            // txt_itemPrice
            // 
            this.txt_itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemPrice.Location = new System.Drawing.Point(59, 284);
            this.txt_itemPrice.Name = "txt_itemPrice";
            this.txt_itemPrice.Size = new System.Drawing.Size(290, 29);
            this.txt_itemPrice.TabIndex = 2;
            this.txt_itemPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_itemPrice_KeyDown);
            // 
            // lbl_itemPrice
            // 
            this.lbl_itemPrice.AutoSize = true;
            this.lbl_itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemPrice.ForeColor = System.Drawing.Color.White;
            this.lbl_itemPrice.Location = new System.Drawing.Point(55, 257);
            this.lbl_itemPrice.Name = "lbl_itemPrice";
            this.lbl_itemPrice.Size = new System.Drawing.Size(58, 24);
            this.lbl_itemPrice.TabIndex = 15;
            this.lbl_itemPrice.Text = "Price:";
            // 
            // combo_itemCategory
            // 
            this.combo_itemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_itemCategory.FormattingEnabled = true;
            this.combo_itemCategory.Location = new System.Drawing.Point(59, 220);
            this.combo_itemCategory.Name = "combo_itemCategory";
            this.combo_itemCategory.Size = new System.Drawing.Size(290, 32);
            this.combo_itemCategory.TabIndex = 1;
            this.combo_itemCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combo_itemCategory_KeyDown);
            // 
            // lbl_itemCategory
            // 
            this.lbl_itemCategory.AutoSize = true;
            this.lbl_itemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemCategory.ForeColor = System.Drawing.Color.White;
            this.lbl_itemCategory.Location = new System.Drawing.Point(55, 193);
            this.lbl_itemCategory.Name = "lbl_itemCategory";
            this.lbl_itemCategory.Size = new System.Drawing.Size(90, 24);
            this.lbl_itemCategory.TabIndex = 13;
            this.lbl_itemCategory.Text = "Category:";
            // 
            // txt_itemName
            // 
            this.txt_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemName.Location = new System.Drawing.Point(59, 159);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(290, 29);
            this.txt_itemName.TabIndex = 0;
            this.txt_itemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_itemName_KeyDown);
            // 
            // lbl_itemName
            // 
            this.lbl_itemName.AutoSize = true;
            this.lbl_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemName.ForeColor = System.Drawing.Color.White;
            this.lbl_itemName.Location = new System.Drawing.Point(55, 132);
            this.lbl_itemName.Name = "lbl_itemName";
            this.lbl_itemName.Size = new System.Drawing.Size(66, 24);
            this.lbl_itemName.TabIndex = 11;
            this.lbl_itemName.Text = "Name:";
            // 
            // lbl_editItem
            // 
            this.lbl_editItem.AutoSize = true;
            this.lbl_editItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editItem.ForeColor = System.Drawing.Color.White;
            this.lbl_editItem.Location = new System.Drawing.Point(139, 39);
            this.lbl_editItem.Name = "lbl_editItem";
            this.lbl_editItem.Size = new System.Drawing.Size(130, 31);
            this.lbl_editItem.TabIndex = 10;
            this.lbl_editItem.Text = "Edit Item";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Red;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(207, 369);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(142, 30);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Undo Changes";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_itemId1
            // 
            this.lbl_itemId1.AutoSize = true;
            this.lbl_itemId1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemId1.ForeColor = System.Drawing.Color.White;
            this.lbl_itemId1.Location = new System.Drawing.Point(141, 104);
            this.lbl_itemId1.Name = "lbl_itemId1";
            this.lbl_itemId1.Size = new System.Drawing.Size(20, 24);
            this.lbl_itemId1.TabIndex = 22;
            this.lbl_itemId1.Text = "0";
            // 
            // lbl_itemId2
            // 
            this.lbl_itemId2.AutoSize = true;
            this.lbl_itemId2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemId2.ForeColor = System.Drawing.Color.White;
            this.lbl_itemId2.Location = new System.Drawing.Point(55, 104);
            this.lbl_itemId2.Name = "lbl_itemId2";
            this.lbl_itemId2.Size = new System.Drawing.Size(32, 24);
            this.lbl_itemId2.TabIndex = 21;
            this.lbl_itemId2.Text = "ID:";
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = global::CafeManagementSystem.Properties.Resources.close;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(377, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(20, 18);
            this.btn_close.TabIndex = 5;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // UpdateItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(409, 445);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_itemId1);
            this.Controls.Add(this.lbl_itemId2);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_updateItem);
            this.Controls.Add(this.txt_itemPrice);
            this.Controls.Add(this.lbl_itemPrice);
            this.Controls.Add(this.combo_itemCategory);
            this.Controls.Add(this.lbl_itemCategory);
            this.Controls.Add(this.txt_itemName);
            this.Controls.Add(this.lbl_itemName);
            this.Controls.Add(this.lbl_editItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_updateItem;
        private System.Windows.Forms.TextBox txt_itemPrice;
        private System.Windows.Forms.Label lbl_itemPrice;
        private System.Windows.Forms.ComboBox combo_itemCategory;
        private System.Windows.Forms.Label lbl_itemCategory;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.Label lbl_itemName;
        private System.Windows.Forms.Label lbl_editItem;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_itemId1;
        private System.Windows.Forms.Label lbl_itemId2;
        private System.Windows.Forms.Button btn_close;
    }
}