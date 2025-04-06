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
            textBoxSearchCustomer = new TextBox();
            btnSearch = new Button();
            ColumnTransactionDate = new DataGridViewTextBoxColumn();
            ColumnTotalAmount = new DataGridViewTextBoxColumn();
            ColumnDiscountGiven = new DataGridViewTextBoxColumn();
            ColumnGrandTotal = new DataGridViewTextBoxColumn();
            btnApplyDiscount = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHIstory).BeginInit();
            SuspendLayout();
            // 
            // history
            // 
            history.Font = new Font("Copperplate Gothic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            history.Location = new Point(20, 16);
            history.Name = "history";
            history.Size = new Size(562, 81);
            history.TabIndex = 0;
            history.Text = "Customer  History";
            // 
            // dataGridViewHIstory
            // 
            dataGridViewHIstory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHIstory.Columns.AddRange(new DataGridViewColumn[] { ColumnTransactionDate, ColumnTotalAmount, ColumnDiscountGiven, ColumnGrandTotal, btnApplyDiscount });
            dataGridViewHIstory.Location = new Point(264, 177);
            dataGridViewHIstory.Name = "dataGridViewHIstory";
            dataGridViewHIstory.RowHeadersWidth = 51;
            dataGridViewHIstory.Size = new Size(678, 276);
            dataGridViewHIstory.TabIndex = 1;
            // 
            // textBoxSearchCustomer
            // 
            textBoxSearchCustomer.Location = new Point(410, 108);
            textBoxSearchCustomer.Name = "textBoxSearchCustomer";
            textBoxSearchCustomer.Size = new Size(149, 27);
            textBoxSearchCustomer.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(609, 106);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(114, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
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
            // ZH_OrderHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch);
            Controls.Add(textBoxSearchCustomer);
            Controls.Add(dataGridViewHIstory);
            Controls.Add(history);
            Name = "ZH_OrderHistory";
            Size = new Size(1332, 582);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHIstory).EndInit();
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
    }
}
