namespace CafeManagementSystem
{
    partial class EditBillItem
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
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_itemId1 = new System.Windows.Forms.Label();
            this.lbl_itemId2 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_updateItem = new System.Windows.Forms.Button();
            this.lbl_itemPrice = new System.Windows.Forms.Label();
            this.lbl_itemQuantity = new System.Windows.Forms.Label();
            this.lbl_itemName = new System.Windows.Forms.Label();
            this.lbl_editItem = new System.Windows.Forms.Label();
            this.combo_item = new System.Windows.Forms.ComboBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btn_close.TabIndex = 28;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_itemId1
            // 
            this.lbl_itemId1.AutoSize = true;
            this.lbl_itemId1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemId1.ForeColor = System.Drawing.Color.White;
            this.lbl_itemId1.Location = new System.Drawing.Point(141, 104);
            this.lbl_itemId1.Name = "lbl_itemId1";
            this.lbl_itemId1.Size = new System.Drawing.Size(20, 24);
            this.lbl_itemId1.TabIndex = 34;
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
            this.lbl_itemId2.TabIndex = 33;
            this.lbl_itemId2.Text = "ID:";
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
            this.btn_clear.TabIndex = 27;
            this.btn_clear.Text = "Undo Changes";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
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
            this.btn_updateItem.TabIndex = 26;
            this.btn_updateItem.Text = "Update";
            this.btn_updateItem.UseVisualStyleBackColor = false;
            this.btn_updateItem.Click += new System.EventHandler(this.btn_updateItem_Click);
            // 
            // lbl_itemPrice
            // 
            this.lbl_itemPrice.AutoSize = true;
            this.lbl_itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemPrice.ForeColor = System.Drawing.Color.White;
            this.lbl_itemPrice.Location = new System.Drawing.Point(55, 257);
            this.lbl_itemPrice.Name = "lbl_itemPrice";
            this.lbl_itemPrice.Size = new System.Drawing.Size(58, 24);
            this.lbl_itemPrice.TabIndex = 32;
            this.lbl_itemPrice.Text = "Price:";
            // 
            // lbl_itemQuantity
            // 
            this.lbl_itemQuantity.AutoSize = true;
            this.lbl_itemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemQuantity.ForeColor = System.Drawing.Color.White;
            this.lbl_itemQuantity.Location = new System.Drawing.Point(55, 193);
            this.lbl_itemQuantity.Name = "lbl_itemQuantity";
            this.lbl_itemQuantity.Size = new System.Drawing.Size(83, 24);
            this.lbl_itemQuantity.TabIndex = 31;
            this.lbl_itemQuantity.Text = "Quantity:";
            // 
            // lbl_itemName
            // 
            this.lbl_itemName.AutoSize = true;
            this.lbl_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemName.ForeColor = System.Drawing.Color.White;
            this.lbl_itemName.Location = new System.Drawing.Point(55, 132);
            this.lbl_itemName.Name = "lbl_itemName";
            this.lbl_itemName.Size = new System.Drawing.Size(66, 24);
            this.lbl_itemName.TabIndex = 30;
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
            this.lbl_editItem.TabIndex = 29;
            this.lbl_editItem.Text = "Edit Item";
            // 
            // combo_item
            // 
            this.combo_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_item.FormattingEnabled = true;
            this.combo_item.Location = new System.Drawing.Point(59, 159);
            this.combo_item.Name = "combo_item";
            this.combo_item.Size = new System.Drawing.Size(290, 32);
            this.combo_item.TabIndex = 35;
            this.combo_item.SelectedIndexChanged += new System.EventHandler(this.combo_item_SelectedIndexChanged);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(59, 220);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(290, 29);
            this.txt_quantity.TabIndex = 36;
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged_1);
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.White;
            this.lbl_price.Location = new System.Drawing.Point(141, 257);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(20, 24);
            this.lbl_price.TabIndex = 37;
            this.lbl_price.Text = "0";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.Location = new System.Drawing.Point(141, 293);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(20, 24);
            this.lbl_total.TabIndex = 39;
            this.lbl_total.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Total:";
            // 
            // EditBillItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(409, 445);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.combo_item);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_itemId1);
            this.Controls.Add(this.lbl_itemId2);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_updateItem);
            this.Controls.Add(this.lbl_itemPrice);
            this.Controls.Add(this.lbl_itemQuantity);
            this.Controls.Add(this.lbl_itemName);
            this.Controls.Add(this.lbl_editItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditBillItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditBillItem";
            this.Load += new System.EventHandler(this.EditBillItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_itemId1;
        private System.Windows.Forms.Label lbl_itemId2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_updateItem;
        private System.Windows.Forms.Label lbl_itemPrice;
        private System.Windows.Forms.Label lbl_itemQuantity;
        private System.Windows.Forms.Label lbl_itemName;
        private System.Windows.Forms.Label lbl_editItem;
        private System.Windows.Forms.ComboBox combo_item;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label3;
    }
}