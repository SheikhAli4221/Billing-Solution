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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).BeginInit();
            groupBoxCustomer.SuspendLayout();
            groupBoxSummary.SuspendLayout();
            tableLayoutPanelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericDiscount).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Copperplate Gothic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(634, 85);
            label1.TabIndex = 0;
            label1.Text = "Sales Invoice ";
            label1.Click += label1_Click;
            // 
            // dataGridViewInvoice
            // 
            dataGridViewInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoice.Columns.AddRange(new DataGridViewColumn[] { ColumnItemName, ColumnDescription, ColumnQuantity, ColumnUnitPrice, ColumnTotal });
            dataGridViewInvoice.Location = new Point(77, 220);
            dataGridViewInvoice.Margin = new Padding(4);
            dataGridViewInvoice.Name = "dataGridViewInvoice";
            dataGridViewInvoice.RowHeadersWidth = 51;
            dataGridViewInvoice.Size = new Size(690, 312);
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
            groupBoxCustomer.Location = new Point(875, 220);
            groupBoxCustomer.Margin = new Padding(4);
            groupBoxCustomer.Name = "groupBoxCustomer";
            groupBoxCustomer.Padding = new Padding(4);
            groupBoxCustomer.Size = new Size(511, 188);
            groupBoxCustomer.TabIndex = 2;
            groupBoxCustomer.TabStop = false;
            groupBoxCustomer.Text = "Customer Information ";
            // 
            // maskedPhone
            // 
            maskedPhone.Location = new Point(209, 96);
            maskedPhone.Margin = new Padding(4);
            maskedPhone.Mask = "(999) 000-0000";
            maskedPhone.Name = "maskedPhone";
            maskedPhone.Size = new Size(155, 31);
            maskedPhone.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(209, 38);
            txtCustomerName.Margin = new Padding(4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(155, 31);
            txtCustomerName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 96);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 27);
            label3.TabIndex = 0;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 40);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 27);
            label2.TabIndex = 0;
            label2.Text = "Customer Name";
            // 
            // groupBoxSummary
            // 
            groupBoxSummary.Controls.Add(tableLayoutPanelSummary);
            groupBoxSummary.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxSummary.Location = new Point(77, 559);
            groupBoxSummary.Margin = new Padding(4);
            groupBoxSummary.Name = "groupBoxSummary";
            groupBoxSummary.Padding = new Padding(4);
            groupBoxSummary.Size = new Size(625, 225);
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
            tableLayoutPanelSummary.Location = new Point(4, 32);
            tableLayoutPanelSummary.Margin = new Padding(4);
            tableLayoutPanelSummary.Name = "tableLayoutPanelSummary";
            tableLayoutPanelSummary.RowCount = 5;
            tableLayoutPanelSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelSummary.Size = new Size(625, 188);
            tableLayoutPanelSummary.TabIndex = 0;
            // 
            // label5
            // 
            label5.Font = new Font("Nirmala Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 37);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(286, 34);
            label5.TabIndex = 0;
            label5.Text = "Discount %";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Nirmala Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(4, 148);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(304, 38);
            label8.TabIndex = 0;
            label8.Text = "Balance";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxSubTotal
            // 
            textBoxSubTotal.Location = new Point(316, 4);
            textBoxSubTotal.Margin = new Padding(4);
            textBoxSubTotal.Name = "textBoxSubTotal";
            textBoxSubTotal.ReadOnly = true;
            textBoxSubTotal.Size = new Size(304, 31);
            textBoxSubTotal.TabIndex = 1;
            // 
            // numericDiscount
            // 
            numericDiscount.Location = new Point(316, 41);
            numericDiscount.Margin = new Padding(4);
            numericDiscount.Name = "numericDiscount";
            numericDiscount.Size = new Size(305, 31);
            numericDiscount.TabIndex = 2;
            // 
            // textBoxGrandtotal
            // 
            textBoxGrandtotal.Location = new Point(316, 78);
            textBoxGrandtotal.Margin = new Padding(4);
            textBoxGrandtotal.Name = "textBoxGrandtotal";
            textBoxGrandtotal.ReadOnly = true;
            textBoxGrandtotal.Size = new Size(304, 31);
            textBoxGrandtotal.TabIndex = 1;
            // 
            // textBoxAmountGiven
            // 
            textBoxAmountGiven.Location = new Point(316, 115);
            textBoxAmountGiven.Margin = new Padding(4);
            textBoxAmountGiven.Name = "textBoxAmountGiven";
            textBoxAmountGiven.Size = new Size(304, 31);
            textBoxAmountGiven.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(316, 152);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(304, 31);
            textBox1.TabIndex = 1;
            // 
            // label6
            // 
            label6.Font = new Font("Nirmala Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(4, 74);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(304, 37);
            label6.TabIndex = 0;
            label6.Text = "Grandtotal";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Nirmala Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(4, 111);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(304, 25);
            label7.TabIndex = 0;
            label7.Text = "Amount Given";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Nirmala Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(286, 26);
            label4.TabIndex = 0;
            label4.Text = "Subtotal";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Black;
            btnCalculate.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(725, 559);
            btnCalculate.Margin = new Padding(4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 41);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Black;
            btnPrint.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(77, 819);
            btnPrint.Margin = new Padding(4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(186, 41);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 158);
            panel1.TabIndex = 6;
            // 
            // ZH_GenerateInvoice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(btnPrint);
            Controls.Add(btnCalculate);
            Controls.Add(groupBoxSummary);
            Controls.Add(groupBoxCustomer);
            Controls.Add(dataGridViewInvoice);
            Margin = new Padding(4);
            Name = "ZH_GenerateInvoice";
            Size = new Size(1411, 900);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).EndInit();
            groupBoxCustomer.ResumeLayout(false);
            groupBoxCustomer.PerformLayout();
            groupBoxSummary.ResumeLayout(false);
            tableLayoutPanelSummary.ResumeLayout(false);
            tableLayoutPanelSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericDiscount).EndInit();
            panel1.ResumeLayout(false);
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
        private Panel panel1;
    }
}
