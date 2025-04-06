namespace Billing_Solution
{
    partial class ZH_OrderHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            history = new Label();
            dataGridViewHIstory = new DataGridView();
            ColumnTransactionDate = new DataGridViewTextBoxColumn();
            ColumnTotalAmount = new DataGridViewTextBoxColumn();
            ColumnDiscountGiven = new DataGridViewTextBoxColumn();
            ColumnGrandTotal = new DataGridViewTextBoxColumn();
            btnApplyDiscount = new DataGridViewButtonColumn();
            textBoxSearchCustomer = new TextBox();
            btnSearch = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHIstory).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // history
            // 
            history.BackColor = Color.Transparent;
            history.Font = new Font("Copperplate Gothic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            history.Location = new Point(-1, 0);
            history.Margin = new Padding(4, 0, 4, 0);
            history.Name = "history";
            history.Size = new Size(702, 101);
            history.TabIndex = 0;
            history.Text = "Customer  History";
            // 
            // dataGridViewHIstory
            // 
            dataGridViewHIstory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHIstory.Columns.AddRange(new DataGridViewColumn[] { ColumnTransactionDate, ColumnTotalAmount, ColumnDiscountGiven, ColumnGrandTotal, btnApplyDiscount });
            dataGridViewHIstory.Location = new Point(297, 295);
            dataGridViewHIstory.Margin = new Padding(4);
            dataGridViewHIstory.Name = "dataGridViewHIstory";
            dataGridViewHIstory.RowHeadersWidth = 51;
            dataGridViewHIstory.Size = new Size(848, 345);
            dataGridViewHIstory.TabIndex = 1;
            // 
            // ColumnTransactionDate
            // 
            ColumnTransactionDate.HeaderText = "Date";
            ColumnTransactionDate.MinimumWidth = 6;
            ColumnTransactionDate.Name = "ColumnTransactionDate";
            ColumnTransactionDate.Width = 125;
            // 
            // ColumnTotalAmount
            // 
            ColumnTotalAmount.HeaderText = "Total Amount ";
            ColumnTotalAmount.MinimumWidth = 6;
            ColumnTotalAmount.Name = "ColumnTotalAmount";
            ColumnTotalAmount.Width = 125;
            // 
            // ColumnDiscountGiven
            // 
            ColumnDiscountGiven.HeaderText = "Discount Given";
            ColumnDiscountGiven.MinimumWidth = 6;
            ColumnDiscountGiven.Name = "ColumnDiscountGiven";
            ColumnDiscountGiven.Width = 125;
            // 
            // ColumnGrandTotal
            // 
            ColumnGrandTotal.HeaderText = "Grand Total";
            ColumnGrandTotal.MinimumWidth = 6;
            ColumnGrandTotal.Name = "ColumnGrandTotal";
            ColumnGrandTotal.Width = 125;
            // 
            // btnApplyDiscount
            // 
            btnApplyDiscount.HeaderText = "Apply Discount";
            btnApplyDiscount.MinimumWidth = 6;
            btnApplyDiscount.Name = "btnApplyDiscount";
            btnApplyDiscount.Resizable = DataGridViewTriState.True;
            btnApplyDiscount.SortMode = DataGridViewColumnSortMode.Automatic;
            btnApplyDiscount.Width = 125;
            // 
            // textBoxSearchCustomer
            // 
            textBoxSearchCustomer.Location = new Point(542, 235);
            textBoxSearchCustomer.Margin = new Padding(4);
            textBoxSearchCustomer.Name = "textBoxSearchCustomer";
            textBoxSearchCustomer.Size = new Size(185, 31);
            textBoxSearchCustomer.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(765, 230);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(142, 48);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(history);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 181);
            panel1.TabIndex = 4;
            // 
            // ZH_OrderHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(btnSearch);
            Controls.Add(textBoxSearchCustomer);
            Controls.Add(dataGridViewHIstory);
            Margin = new Padding(4);
            Name = "ZH_OrderHistory";
            Size = new Size(1411, 900);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHIstory).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label history;
        private DataGridView dataGridViewHIstory;
        private TextBox textBoxSearchCustomer;
        private Button btnSearch;
        private DataGridViewTextBoxColumn ColumnTransactionDate;
        private DataGridViewTextBoxColumn ColumnTotalAmount;
        private DataGridViewTextBoxColumn ColumnDiscountGiven;
        private DataGridViewTextBoxColumn ColumnGrandTotal;
        private DataGridViewButtonColumn btnApplyDiscount;
        private Panel panel1;
    }
}
