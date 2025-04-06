namespace Billing_Solution
{
    partial class ZH_GenerateInvoice
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
            label1 = new Label();
            dataGridViewInvoice = new DataGridView();
            ColumnItemName = new DataGridViewComboBoxColumn();
            ColumnDescription = new DataGridViewTextBoxColumn();
            ColumnQuantity = new DataGridViewTextBoxColumn();
            ColumnUnitPrice = new DataGridViewTextBoxColumn();
            ColumnTotal = new DataGridViewTextBoxColumn();
            groupBoxCustomer = new GroupBox();
            maskedPhone = new MaskedTextBox();
            txtCustomerName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBoxSummary = new GroupBox();
            tableLayoutPanelSummary = new TableLayoutPanel();
            label5 = new Label();
            label8 = new Label();
            textBoxSubTotal = new TextBox();
            numericDiscount = new NumericUpDown();
            textBoxGrandtotal = new TextBox();
            textBoxAmountGiven = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            btnCalculate = new Button();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).BeginInit();
            groupBoxCustomer.SuspendLayout();
            tableLayoutPanelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericDiscount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Copperplate Gothic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 0);
            label1.Name = "label1";
            label1.Size = new Size(507, 68);
            label1.TabIndex = 0;
            label1.Text = "Sales Invoice ";
            label1.Click += label1_Click;
            // 
            // dataGridViewInvoice
            // 
            dataGridViewInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoice.Columns.AddRange(new DataGridViewColumn[] { ColumnItemName, ColumnDescription, ColumnQuantity, ColumnUnitPrice, ColumnTotal });
            dataGridViewInvoice.Location = new Point(27, 53);
            dataGridViewInvoice.Name = "dataGridViewInvoice";
            dataGridViewInvoice.RowHeadersWidth = 51;
            dataGridViewInvoice.Size = new Size(740, 250);
            dataGridViewInvoice.TabIndex = 1;
            dataGridViewInvoice.CellContentClick += dataGridViewInvoice_CellContentClick;
            // 
            // ColumnItemName
            // 
            ColumnItemName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnItemName.HeaderText = "Item Name";
            ColumnItemName.MinimumWidth = 6;
            ColumnItemName.Name = "ColumnItemName";
            ColumnItemName.Resizable = DataGridViewTriState.True;
            ColumnItemName.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnDescription
            // 
            ColumnDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnDescription.HeaderText = "Description";
            ColumnDescription.MinimumWidth = 6;
            ColumnDescription.Name = "ColumnDescription";
            // 
            // ColumnQuantity
            // 
            ColumnQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnQuantity.HeaderText = "Quantity";
            ColumnQuantity.MinimumWidth = 6;
            ColumnQuantity.Name = "ColumnQuantity";
            // 
            // ColumnUnitPrice
            // 
            ColumnUnitPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnUnitPrice.HeaderText = "Unit Price";
            ColumnUnitPrice.MinimumWidth = 6;
            ColumnUnitPrice.Name = "ColumnUnitPrice";
            // 
            // ColumnTotal
            // 
            ColumnTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnTotal.HeaderText = "Total";
            ColumnTotal.MinimumWidth = 6;
            ColumnTotal.Name = "ColumnTotal";
            ColumnTotal.ReadOnly = true;
            // 
            // groupBoxCustomer
            // 
            groupBoxCustomer.Controls.Add(maskedPhone);
            groupBoxCustomer.Controls.Add(txtCustomerName);
            groupBoxCustomer.Controls.Add(label3);
            groupBoxCustomer.Controls.Add(label2);
            groupBoxCustomer.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxCustomer.Location = new Point(804, 108);
            groupBoxCustomer.Name = "groupBoxCustomer";
            groupBoxCustomer.Size = new Size(500, 150);
            groupBoxCustomer.TabIndex = 2;
            groupBoxCustomer.TabStop = false;
            groupBoxCustomer.Text = "Customer Information ";
            // 
            // maskedPhone
            // 
            maskedPhone.Location = new Point(167, 77);
            maskedPhone.Mask = "(999) 000-0000";
            maskedPhone.Name = "maskedPhone";
            maskedPhone.Size = new Size(125, 27);
            maskedPhone.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(167, 30);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(125, 27);
            txtCustomerName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 77);
            label3.Name = "label3";
            label3.Size = new Size(135, 22);
            label3.TabIndex = 0;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 32);
            label2.Name = "label2";
            label2.Size = new Size(143, 22);
            label2.TabIndex = 0;
            label2.Text = "Customer Name";
            // 
            // groupBoxSummary
            // 
            groupBoxSummary.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxSummary.Location = new Point(457, 309);
            groupBoxSummary.Name = "groupBoxSummary";
            groupBoxSummary.Size = new Size(500, 192);
            groupBoxSummary.TabIndex = 3;
            groupBoxSummary.TabStop = false;
            groupBoxSummary.Text = "Invoice Summary";
            // 
            // tableLayoutPanelSummary
            // 
            tableLayoutPanelSummary.ColumnCount = 2;
            tableLayoutPanelSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelSummary.Controls.Add(label5, 0, 1);
            tableLayoutPanelSummary.Controls.Add(label8, 0, 4);
            tableLayoutPanelSummary.Controls.Add(textBoxSubTotal, 1, 0);
            tableLayoutPanelSummary.Controls.Add(numericDiscount, 1, 1);
            tableLayoutPanelSummary.Controls.Add(textBoxGrandtotal, 1, 2);
            tableLayoutPanelSummary.Controls.Add(textBoxAmountGiven, 1, 3);
            tableLayoutPanelSummary.Controls.Add(textBox1, 1, 4);
            tableLayoutPanelSummary.Controls.Add(label6, 0, 2);
            tableLayoutPanelSummary.Controls.Add(label7, 0, 3);
            tableLayoutPanelSummary.Controls.Add(label4, 0, 0);
            tableLayoutPanelSummary.Location = new Point(457, 351);
            tableLayoutPanelSummary.Name = "tableLayoutPanelSummary";
            tableLayoutPanelSummary.RowCount = 5;
            tableLayoutPanelSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummary.Size = new Size(500, 150);
            tableLayoutPanelSummary.TabIndex = 0;
            // 
            // label5
            // 
            label5.Font = new Font("Nirmala Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 30);
            label5.Name = "label5";
            label5.Size = new Size(229, 27);
            label5.TabIndex = 0;
            label5.Text = "Discount %";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Nirmala Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 120);
            label8.Name = "label8";
            label8.Size = new Size(244, 30);
            label8.TabIndex = 0;
            label8.Text = "Balance";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxSubTotal
            // 
            textBoxSubTotal.Location = new Point(253, 3);
            textBoxSubTotal.Name = "textBoxSubTotal";
            textBoxSubTotal.ReadOnly = true;
            textBoxSubTotal.Size = new Size(244, 27);
            textBoxSubTotal.TabIndex = 1;
            // 
            // numericDiscount
            // 
            numericDiscount.Location = new Point(253, 33);
            numericDiscount.Name = "numericDiscount";
            numericDiscount.Size = new Size(244, 27);
            numericDiscount.TabIndex = 2;
            // 
            // textBoxGrandtotal
            // 
            textBoxGrandtotal.Location = new Point(253, 63);
            textBoxGrandtotal.Name = "textBoxGrandtotal";
            textBoxGrandtotal.ReadOnly = true;
            textBoxGrandtotal.Size = new Size(244, 27);
            textBoxGrandtotal.TabIndex = 1;
            // 
            // textBoxAmountGiven
            // 
            textBoxAmountGiven.Location = new Point(253, 93);
            textBoxAmountGiven.Name = "textBoxAmountGiven";
            textBoxAmountGiven.Size = new Size(244, 27);
            textBoxAmountGiven.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(253, 123);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(244, 27);
            textBox1.TabIndex = 1;
            // 
            // label6
            // 
            label6.Font = new Font("Nirmala Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 60);
            label6.Name = "label6";
            label6.Size = new Size(244, 30);
            label6.TabIndex = 0;
            label6.Text = "Grandtotal";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Nirmala Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 90);
            label7.Name = "label7";
            label7.Size = new Size(244, 20);
            label7.TabIndex = 0;
            label7.Text = "Amount Given";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Nirmala Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(229, 21);
            label4.TabIndex = 0;
            label4.Text = "Subtotal";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(661, 518);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 33);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(27, 518);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(149, 33);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // ZH_GenerateInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelSummary);
            Controls.Add(btnPrint);
            Controls.Add(btnCalculate);
            Controls.Add(groupBoxSummary);
            Controls.Add(groupBoxCustomer);
            Controls.Add(dataGridViewInvoice);
            Controls.Add(label1);
            Name = "ZH_GenerateInvoice";
            Size = new Size(1317, 604);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).EndInit();
            groupBoxCustomer.ResumeLayout(false);
            groupBoxCustomer.PerformLayout();
            tableLayoutPanelSummary.ResumeLayout(false);
            tableLayoutPanelSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericDiscount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewInvoice;
        private DataGridViewComboBoxColumn ColumnItemName;
        private DataGridViewTextBoxColumn ColumnDescription;
        private DataGridViewTextBoxColumn ColumnQuantity;
        private DataGridViewTextBoxColumn ColumnUnitPrice;
        private DataGridViewTextBoxColumn ColumnTotal;
        private GroupBox groupBoxCustomer;
        private Label label2;
        private TextBox txtCustomerName;
        private MaskedTextBox maskedPhone;
        private Label label3;
        private GroupBox groupBoxSummary;
        private TableLayoutPanel tableLayoutPanelSummary;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxSubTotal;
        private NumericUpDown numericDiscount;
        private TextBox textBoxGrandtotal;
        private TextBox textBoxAmountGiven;
        private TextBox textBox1;
        private Button btnCalculate;
        private Button btnPrint;
    }
}
