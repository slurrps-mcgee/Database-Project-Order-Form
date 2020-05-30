namespace OderForm
{
    partial class frmDisplay
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
            this.dgDisplay = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtSpecificBook = new System.Windows.Forms.TextBox();
            this.txtSpecificCustomer = new System.Windows.Forms.TextBox();
            this.radBooks = new System.Windows.Forms.RadioButton();
            this.radCustomer = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDisplay
            // 
            this.dgDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDisplay.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDisplay.Enabled = false;
            this.dgDisplay.Location = new System.Drawing.Point(0, 137);
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.Size = new System.Drawing.Size(1347, 624);
            this.dgDisplay.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1347, 137);
            this.panel1.TabIndex = 1;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtSpecificBook);
            this.grpSearch.Controls.Add(this.txtSpecificCustomer);
            this.grpSearch.Controls.Add(this.radBooks);
            this.grpSearch.Controls.Add(this.radCustomer);
            this.grpSearch.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.ForeColor = System.Drawing.Color.White;
            this.grpSearch.Location = new System.Drawing.Point(27, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(1308, 119);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Options";
            // 
            // txtSpecificBook
            // 
            this.txtSpecificBook.Location = new System.Drawing.Point(425, 66);
            this.txtSpecificBook.Name = "txtSpecificBook";
            this.txtSpecificBook.Size = new System.Drawing.Size(313, 27);
            this.txtSpecificBook.TabIndex = 2;
            this.txtSpecificBook.Visible = false;
            this.txtSpecificBook.TextChanged += new System.EventHandler(this.txtSpecificBook_TextChanged);
            // 
            // txtSpecificCustomer
            // 
            this.txtSpecificCustomer.Location = new System.Drawing.Point(74, 66);
            this.txtSpecificCustomer.Name = "txtSpecificCustomer";
            this.txtSpecificCustomer.Size = new System.Drawing.Size(313, 27);
            this.txtSpecificCustomer.TabIndex = 2;
            this.txtSpecificCustomer.Visible = false;
            this.txtSpecificCustomer.TextChanged += new System.EventHandler(this.txtSpecificCustomer_TextChanged);
            // 
            // radBooks
            // 
            this.radBooks.AutoSize = true;
            this.radBooks.ForeColor = System.Drawing.Color.White;
            this.radBooks.Location = new System.Drawing.Point(425, 26);
            this.radBooks.Name = "radBooks";
            this.radBooks.Size = new System.Drawing.Size(222, 23);
            this.radBooks.TabIndex = 1;
            this.radBooks.TabStop = true;
            this.radBooks.Text = "Search by books (Book Code)";
            this.radBooks.UseVisualStyleBackColor = true;
            this.radBooks.CheckedChanged += new System.EventHandler(this.radBooks_CheckedChanged);
            // 
            // radCustomer
            // 
            this.radCustomer.AutoSize = true;
            this.radCustomer.ForeColor = System.Drawing.Color.White;
            this.radCustomer.Location = new System.Drawing.Point(74, 26);
            this.radCustomer.Name = "radCustomer";
            this.radCustomer.Size = new System.Drawing.Size(240, 23);
            this.radCustomer.TabIndex = 0;
            this.radCustomer.TabStop = true;
            this.radCustomer.Text = "Search by customer (Last Name)";
            this.radCustomer.UseVisualStyleBackColor = true;
            this.radCustomer.CheckedChanged += new System.EventHandler(this.radCustomer_CheckedChanged);
            // 
            // frmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1347, 761);
            this.Controls.Add(this.dgDisplay);
            this.Controls.Add(this.panel1);
            this.Name = "frmDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDisplay";
            this.Load += new System.EventHandler(this.frmDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSpecificBook;
        private System.Windows.Forms.TextBox txtSpecificCustomer;
        private System.Windows.Forms.RadioButton radBooks;
        private System.Windows.Forms.RadioButton radCustomer;
    }
}