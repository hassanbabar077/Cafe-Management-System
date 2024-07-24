namespace CafeManagementSystem
{
    partial class Selling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selling));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_itemList = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.btn_addToBill = new System.Windows.Forms.Button();
            this.lbl_orderDetails = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_editOrderItem = new System.Windows.Forms.Button();
            this.grid_orderBill = new System.Windows.Forms.DataGridView();
            this.lbl_orderTotalPrice = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.grid_itemList = new System.Windows.Forms.DataGridView();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_dltOrderItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_orderBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_itemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_category
            // 
            this.cb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(17, 106);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(215, 32);
            this.cb_category.TabIndex = 4;
            this.cb_category.SelectionChangeCommitted += new System.EventHandler(this.cb_category_SelectionChangeCommitted);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(238, 106);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(134, 32);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_itemList
            // 
            this.lbl_itemList.AutoSize = true;
            this.lbl_itemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_itemList.Location = new System.Drawing.Point(444, 30);
            this.lbl_itemList.Name = "lbl_itemList";
            this.lbl_itemList.Size = new System.Drawing.Size(163, 37);
            this.lbl_itemList.TabIndex = 10;
            this.lbl_itemList.Text = "Items List";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(1201, 405);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(215, 29);
            this.txt_quantity.TabIndex = 0;
            this.txt_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_quantity_KeyDown);
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_quantity.Location = new System.Drawing.Point(1112, 410);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(83, 24);
            this.lbl_quantity.TabIndex = 10;
            this.lbl_quantity.Text = "Quantity:";
            // 
            // btn_addToBill
            // 
            this.btn_addToBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_addToBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addToBill.FlatAppearance.BorderSize = 0;
            this.btn_addToBill.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addToBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addToBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addToBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addToBill.ForeColor = System.Drawing.Color.White;
            this.btn_addToBill.Location = new System.Drawing.Point(1431, 402);
            this.btn_addToBill.Name = "btn_addToBill";
            this.btn_addToBill.Size = new System.Drawing.Size(134, 32);
            this.btn_addToBill.TabIndex = 1;
            this.btn_addToBill.Text = "Add to Bill";
            this.btn_addToBill.UseVisualStyleBackColor = false;
            this.btn_addToBill.Click += new System.EventHandler(this.btn_addToBill_Click);
            // 
            // lbl_orderDetails
            // 
            this.lbl_orderDetails.AutoSize = true;
            this.lbl_orderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_orderDetails.Location = new System.Drawing.Point(444, 420);
            this.lbl_orderDetails.Name = "lbl_orderDetails";
            this.lbl_orderDetails.Size = new System.Drawing.Size(218, 37);
            this.lbl_orderDetails.TabIndex = 14;
            this.lbl_orderDetails.Text = "Order Details";
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(1164, 786);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(134, 32);
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_editOrderItem
            // 
            this.btn_editOrderItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editOrderItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editOrderItem.FlatAppearance.BorderSize = 0;
            this.btn_editOrderItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_editOrderItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_editOrderItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editOrderItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editOrderItem.ForeColor = System.Drawing.Color.White;
            this.btn_editOrderItem.Location = new System.Drawing.Point(451, 786);
            this.btn_editOrderItem.Name = "btn_editOrderItem";
            this.btn_editOrderItem.Size = new System.Drawing.Size(134, 32);
            this.btn_editOrderItem.TabIndex = 3;
            this.btn_editOrderItem.Text = "Edit";
            this.btn_editOrderItem.UseVisualStyleBackColor = false;
            this.btn_editOrderItem.Click += new System.EventHandler(this.btn_editOrderItem_Click);
            // 
            // grid_orderBill
            // 
            this.grid_orderBill.AllowUserToAddRows = false;
            this.grid_orderBill.AllowUserToDeleteRows = false;
            this.grid_orderBill.AllowUserToResizeColumns = false;
            this.grid_orderBill.AllowUserToResizeRows = false;
            this.grid_orderBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_orderBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_orderBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grid_orderBill.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_orderBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_orderBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_orderBill.ColumnHeadersHeight = 40;
            this.grid_orderBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_orderBill.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_orderBill.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_orderBill.EnableHeadersVisualStyles = false;
            this.grid_orderBill.GridColor = System.Drawing.Color.WhiteSmoke;
            this.grid_orderBill.Location = new System.Drawing.Point(451, 460);
            this.grid_orderBill.Name = "grid_orderBill";
            this.grid_orderBill.ReadOnly = true;
            this.grid_orderBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_orderBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_orderBill.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_orderBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_orderBill.Size = new System.Drawing.Size(847, 294);
            this.grid_orderBill.TabIndex = 21;
            this.grid_orderBill.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_orderBill_CellValueChanged);
            // 
            // lbl_orderTotalPrice
            // 
            this.lbl_orderTotalPrice.AutoSize = true;
            this.lbl_orderTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_orderTotalPrice.Location = new System.Drawing.Point(824, 793);
            this.lbl_orderTotalPrice.Name = "lbl_orderTotalPrice";
            this.lbl_orderTotalPrice.Size = new System.Drawing.Size(73, 25);
            this.lbl_orderTotalPrice.TabIndex = 22;
            this.lbl_orderTotalPrice.Text = "Rs.00";
            this.lbl_orderTotalPrice.Click += new System.EventHandler(this.lbl_orderTotalPrice_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // grid_itemList
            // 
            this.grid_itemList.AllowUserToAddRows = false;
            this.grid_itemList.AllowUserToDeleteRows = false;
            this.grid_itemList.AllowUserToResizeRows = false;
            this.grid_itemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_itemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_itemList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grid_itemList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_itemList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_itemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_itemList.ColumnHeadersHeight = 40;
            this.grid_itemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_itemList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_itemList.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_itemList.EnableHeadersVisualStyles = false;
            this.grid_itemList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grid_itemList.Location = new System.Drawing.Point(451, 70);
            this.grid_itemList.Name = "grid_itemList";
            this.grid_itemList.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_itemList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_itemList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_itemList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_itemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_itemList.Size = new System.Drawing.Size(1114, 310);
            this.grid_itemList.TabIndex = 63;
            this.grid_itemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_itemList_CellContentClick);
            this.grid_itemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_itemList_CellContentClick);
            this.grid_itemList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_itemList_CellContentClick);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_login.Location = new System.Drawing.Point(1512, 9);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(53, 20);
            this.lbl_login.TabIndex = 6;
            this.lbl_login.Text = "Login";
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_date.Location = new System.Drawing.Point(13, 76);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(48, 24);
            this.lbl_date.TabIndex = 65;
            this.lbl_date.Text = "Date";
            // 
            // btn_dltOrderItem
            // 
            this.btn_dltOrderItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_dltOrderItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dltOrderItem.FlatAppearance.BorderSize = 0;
            this.btn_dltOrderItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_dltOrderItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_dltOrderItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dltOrderItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dltOrderItem.ForeColor = System.Drawing.Color.White;
            this.btn_dltOrderItem.Location = new System.Drawing.Point(591, 786);
            this.btn_dltOrderItem.Name = "btn_dltOrderItem";
            this.btn_dltOrderItem.Size = new System.Drawing.Size(134, 32);
            this.btn_dltOrderItem.TabIndex = 68;
            this.btn_dltOrderItem.Text = "Delete";
            this.btn_dltOrderItem.UseVisualStyleBackColor = false;
            this.btn_dltOrderItem.Click += new System.EventHandler(this.btn_dltOrderItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(135, 18);
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
            this.label1.Location = new System.Drawing.Point(70, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "CAFE";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CafeManagementSystem.Properties.Resources.Untitled_design__7__fotor_bg_remover_20240721101529;
            this.pictureBox3.Location = new System.Drawing.Point(12, -4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeManagementSystem.Properties.Resources.icons8_counter_100;
            this.pictureBox1.Location = new System.Drawing.Point(84, 574);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CafeManagementSystem.Properties.Resources.icons8_counter_100__1_;
            this.pictureBox2.Location = new System.Drawing.Point(33, 455);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(287, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // Selling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1604, 839);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dltOrderItem);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.grid_itemList);
            this.Controls.Add(this.lbl_orderTotalPrice);
            this.Controls.Add(this.grid_orderBill);
            this.Controls.Add(this.btn_editOrderItem);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.lbl_orderDetails);
            this.Controls.Add(this.btn_addToBill);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_itemList);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.cb_category);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Selling";
            this.Text = "Selling";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Selling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_orderBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_itemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_itemList;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Button btn_addToBill;
        private System.Windows.Forms.Label lbl_orderDetails;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_editOrderItem;
        private System.Windows.Forms.DataGridView grid_orderBill;
        private System.Windows.Forms.Label lbl_orderTotalPrice;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView grid_itemList;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button btn_dltOrderItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}