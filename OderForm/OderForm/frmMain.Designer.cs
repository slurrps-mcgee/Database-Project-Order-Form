namespace OderForm
{
    partial class frmMain
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
            this.grpOrders = new System.Windows.Forms.GroupBox();
            this.btnDisplayInfo = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnPlacetheOrder = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCustomers = new System.Windows.Forms.GroupBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFistName = new System.Windows.Forms.TextBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpProducts = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpOrderStuff = new System.Windows.Forms.GroupBox();
            this.listOrders = new System.Windows.Forms.ListBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.grpOrders.SuspendLayout();
            this.grpCustomers.SuspendLayout();
            this.grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.grpOrderStuff.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrders
            // 
            this.grpOrders.Controls.Add(this.btnDisplayInfo);
            this.grpOrders.Controls.Add(this.btnCancelOrder);
            this.grpOrders.Controls.Add(this.btnPlacetheOrder);
            this.grpOrders.Controls.Add(this.lblDate);
            this.grpOrders.Controls.Add(this.label2);
            this.grpOrders.Controls.Add(this.lblOrderNum);
            this.grpOrders.Controls.Add(this.label1);
            this.grpOrders.ForeColor = System.Drawing.Color.White;
            this.grpOrders.Location = new System.Drawing.Point(12, 29);
            this.grpOrders.Name = "grpOrders";
            this.grpOrders.Size = new System.Drawing.Size(911, 175);
            this.grpOrders.TabIndex = 0;
            this.grpOrders.TabStop = false;
            this.grpOrders.Text = "Order:";
            // 
            // btnDisplayInfo
            // 
            this.btnDisplayInfo.ForeColor = System.Drawing.Color.Black;
            this.btnDisplayInfo.Location = new System.Drawing.Point(365, 100);
            this.btnDisplayInfo.Name = "btnDisplayInfo";
            this.btnDisplayInfo.Size = new System.Drawing.Size(519, 39);
            this.btnDisplayInfo.TabIndex = 2;
            this.btnDisplayInfo.Text = "Display Info";
            this.btnDisplayInfo.UseVisualStyleBackColor = true;
            this.btnDisplayInfo.Click += new System.EventHandler(this.btnDisplayInfo_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelOrder.ForeColor = System.Drawing.Color.Black;
            this.btnCancelOrder.Location = new System.Drawing.Point(647, 40);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(237, 39);
            this.btnCancelOrder.TabIndex = 1;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnPlacetheOrder
            // 
            this.btnPlacetheOrder.ForeColor = System.Drawing.Color.Black;
            this.btnPlacetheOrder.Location = new System.Drawing.Point(365, 40);
            this.btnPlacetheOrder.Name = "btnPlacetheOrder";
            this.btnPlacetheOrder.Size = new System.Drawing.Size(237, 39);
            this.btnPlacetheOrder.TabIndex = 0;
            this.btnPlacetheOrder.Text = "Place the Order";
            this.btnPlacetheOrder.UseVisualStyleBackColor = true;
            this.btnPlacetheOrder.Click += new System.EventHandler(this.btnPlacetheOrder_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(192, 110);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 19);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order Date";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Location = new System.Drawing.Point(192, 50);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(83, 19);
            this.lblOrderNum.TabIndex = 0;
            this.lblOrderNum.Text = "Order Num";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Store Order";
            // 
            // grpCustomers
            // 
            this.grpCustomers.Controls.Add(this.txtZip);
            this.grpCustomers.Controls.Add(this.txtCity);
            this.grpCustomers.Controls.Add(this.txtAddress);
            this.grpCustomers.Controls.Add(this.txtLastName);
            this.grpCustomers.Controls.Add(this.txtFistName);
            this.grpCustomers.Controls.Add(this.cmbState);
            this.grpCustomers.Controls.Add(this.btnCancel);
            this.grpCustomers.Controls.Add(this.btnSave);
            this.grpCustomers.Controls.Add(this.btnNew);
            this.grpCustomers.Controls.Add(this.cmbCustomers);
            this.grpCustomers.Controls.Add(this.label8);
            this.grpCustomers.Controls.Add(this.label7);
            this.grpCustomers.Controls.Add(this.label6);
            this.grpCustomers.Controls.Add(this.label5);
            this.grpCustomers.Controls.Add(this.label4);
            this.grpCustomers.Controls.Add(this.label3);
            this.grpCustomers.ForeColor = System.Drawing.Color.White;
            this.grpCustomers.Location = new System.Drawing.Point(12, 237);
            this.grpCustomers.Name = "grpCustomers";
            this.grpCustomers.Size = new System.Drawing.Size(911, 373);
            this.grpCustomers.TabIndex = 1;
            this.grpCustomers.TabStop = false;
            this.grpCustomers.Text = "Customers:";
            // 
            // txtZip
            // 
            this.txtZip.Enabled = false;
            this.txtZip.Location = new System.Drawing.Point(130, 321);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(230, 27);
            this.txtZip.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(130, 231);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(718, 27);
            this.txtCity.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(130, 186);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(718, 27);
            this.txtAddress.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(130, 141);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(718, 27);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFistName
            // 
            this.txtFistName.Enabled = false;
            this.txtFistName.Location = new System.Drawing.Point(130, 96);
            this.txtFistName.Name = "txtFistName";
            this.txtFistName.Size = new System.Drawing.Size(718, 27);
            this.txtFistName.TabIndex = 4;
            // 
            // cmbState
            // 
            this.cmbState.Enabled = false;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cmbState.Location = new System.Drawing.Point(130, 276);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(145, 27);
            this.cmbState.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Enabled = false;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(713, 32);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 39);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(539, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(365, 32);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(135, 39);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(19, 39);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(305, 27);
            this.cmbCustomers.TabIndex = 0;
            this.cmbCustomers.SelectedIndexChanged += new System.EventHandler(this.cmbCustomers_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Zip:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "State:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name:";
            // 
            // grpProducts
            // 
            this.grpProducts.Controls.Add(this.txtTotal);
            this.grpProducts.Controls.Add(this.cmbBooks);
            this.grpProducts.Controls.Add(this.numQuantity);
            this.grpProducts.Controls.Add(this.btnAddtoCart);
            this.grpProducts.Controls.Add(this.label11);
            this.grpProducts.Controls.Add(this.label10);
            this.grpProducts.Controls.Add(this.label9);
            this.grpProducts.ForeColor = System.Drawing.Color.White;
            this.grpProducts.Location = new System.Drawing.Point(12, 649);
            this.grpProducts.Name = "grpProducts";
            this.grpProducts.Size = new System.Drawing.Size(442, 286);
            this.grpProducts.TabIndex = 2;
            this.grpProducts.TabStop = false;
            this.grpProducts.Text = "Products:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(130, 228);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(174, 27);
            this.txtTotal.TabIndex = 3;
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(130, 43);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(278, 27);
            this.cmbBooks.TabIndex = 0;
            this.cmbBooks.SelectedIndexChanged += new System.EventHandler(this.cmbBooks_SelectedIndexChanged);
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(130, 98);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 27);
            this.numQuantity.TabIndex = 1;
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.ForeColor = System.Drawing.Color.Black;
            this.btnAddtoCart.Location = new System.Drawing.Point(30, 158);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(378, 39);
            this.btnAddtoCart.TabIndex = 2;
            this.btnAddtoCart.Text = "Add to Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(72, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(54, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Quantity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Select Product:";
            // 
            // grpOrderStuff
            // 
            this.grpOrderStuff.Controls.Add(this.listOrders);
            this.grpOrderStuff.Controls.Add(this.txtOrderTotal);
            this.grpOrderStuff.Controls.Add(this.btnRemoveFromCart);
            this.grpOrderStuff.Controls.Add(this.label12);
            this.grpOrderStuff.ForeColor = System.Drawing.Color.White;
            this.grpOrderStuff.Location = new System.Drawing.Point(481, 649);
            this.grpOrderStuff.Name = "grpOrderStuff";
            this.grpOrderStuff.Size = new System.Drawing.Size(442, 286);
            this.grpOrderStuff.TabIndex = 2;
            this.grpOrderStuff.TabStop = false;
            this.grpOrderStuff.Text = "Orders:";
            // 
            // listOrders
            // 
            this.listOrders.FormattingEnabled = true;
            this.listOrders.ItemHeight = 19;
            this.listOrders.Location = new System.Drawing.Point(22, 39);
            this.listOrders.Name = "listOrders";
            this.listOrders.Size = new System.Drawing.Size(406, 137);
            this.listOrders.TabIndex = 5;
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Enabled = false;
            this.txtOrderTotal.Location = new System.Drawing.Point(205, 183);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(174, 27);
            this.txtOrderTotal.TabIndex = 0;
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(40, 231);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(375, 39);
            this.btnRemoveFromCart.TabIndex = 1;
            this.btnRemoveFromCart.Text = "Remove From the Cart";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(101, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Order Total:";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnPlacetheOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnCancelOrder;
            this.ClientSize = new System.Drawing.Size(935, 953);
            this.Controls.Add(this.grpOrderStuff);
            this.Controls.Add(this.grpProducts);
            this.Controls.Add(this.grpCustomers);
            this.Controls.Add(this.grpOrders);
            this.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpOrders.ResumeLayout(false);
            this.grpOrders.PerformLayout();
            this.grpCustomers.ResumeLayout(false);
            this.grpCustomers.PerformLayout();
            this.grpProducts.ResumeLayout(false);
            this.grpProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.grpOrderStuff.ResumeLayout(false);
            this.grpOrderStuff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrders;
        private System.Windows.Forms.Button btnDisplayInfo;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnPlacetheOrder;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCustomers;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFistName;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpProducts;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpOrderStuff;
        private System.Windows.Forms.ListBox listOrders;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Label label12;
    }
}

