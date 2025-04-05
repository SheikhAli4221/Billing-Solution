namespace Billing_Solution
{
    partial class SalesManDashboard
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
            pnlSidebar = new Panel();
            btnStockCheck = new Button();
            btnInvoice = new Button();
            btnSellProduct = new Button();
            btnOrderHistory = new Button();
            pnlHeader = new Panel();
            btnLogout = new Button();
            label = new Label();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(64, 64, 64);
            pnlSidebar.Controls.Add(btnStockCheck);
            pnlSidebar.Controls.Add(btnInvoice);
            pnlSidebar.Controls.Add(btnSellProduct);
            pnlSidebar.Controls.Add(btnOrderHistory);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(4, 4, 4, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(225, 900);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // btnStockCheck
            // 
            btnStockCheck.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStockCheck.BackColor = Color.FromArgb(64, 64, 64);
            btnStockCheck.FlatStyle = FlatStyle.Flat;
            btnStockCheck.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockCheck.ForeColor = SystemColors.ScrollBar;
            btnStockCheck.Location = new Point(0, 384);
            btnStockCheck.Margin = new Padding(0);
            btnStockCheck.Name = "btnStockCheck";
            btnStockCheck.Padding = new Padding(6, 12, 6, 12);
            btnStockCheck.Size = new Size(225, 76);
            btnStockCheck.TabIndex = 2;
            btnStockCheck.Text = "Check Stock";
            btnStockCheck.UseVisualStyleBackColor = false;
            // 
            // btnInvoice
            // 
            btnInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInvoice.BackColor = Color.FromArgb(64, 64, 64);
            btnInvoice.FlatStyle = FlatStyle.Flat;
            btnInvoice.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInvoice.ForeColor = SystemColors.ScrollBar;
            btnInvoice.Location = new Point(0, 460);
            btnInvoice.Margin = new Padding(0);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Padding = new Padding(6, 12, 6, 12);
            btnInvoice.Size = new Size(225, 76);
            btnInvoice.TabIndex = 3;
            btnInvoice.Text = "Invoice";
            btnInvoice.UseVisualStyleBackColor = false;
            // 
            // btnSellProduct
            // 
            btnSellProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSellProduct.BackColor = Color.FromArgb(64, 64, 64);
            btnSellProduct.FlatStyle = FlatStyle.Flat;
            btnSellProduct.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSellProduct.ForeColor = SystemColors.ScrollBar;
            btnSellProduct.Location = new Point(0, 218);
            btnSellProduct.Margin = new Padding(0);
            btnSellProduct.Name = "btnSellProduct";
            btnSellProduct.Padding = new Padding(6, 12, 6, 12);
            btnSellProduct.Size = new Size(225, 80);
            btnSellProduct.TabIndex = 0;
            btnSellProduct.Text = "Sell Product";
            btnSellProduct.UseVisualStyleBackColor = false;
            btnSellProduct.Click += button1_Click;
            // 
            // btnOrderHistory
            // 
            btnOrderHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOrderHistory.BackColor = Color.FromArgb(64, 64, 64);
            btnOrderHistory.FlatStyle = FlatStyle.Flat;
            btnOrderHistory.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrderHistory.ForeColor = SystemColors.ScrollBar;
            btnOrderHistory.Location = new Point(0, 298);
            btnOrderHistory.Margin = new Padding(0);
            btnOrderHistory.Name = "btnOrderHistory";
            btnOrderHistory.Padding = new Padding(6, 12, 6, 12);
            btnOrderHistory.Size = new Size(225, 86);
            btnOrderHistory.TabIndex = 1;
            btnOrderHistory.Text = "Order History";
            btnOrderHistory.UseVisualStyleBackColor = false;
            btnOrderHistory.Click += btnOrderHistory_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.LightSlateGray;
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(label);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(225, 0);
            pnlHeader.Margin = new Padding(4, 4, 4, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1477, 94);
            pnlHeader.TabIndex = 1;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Right;
            btnLogout.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(1359, 0);
            btnLogout.Margin = new Padding(4, 4, 4, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(118, 94);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            label.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.Location = new Point(473, 4);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(350, 81);
            label.TabIndex = 0;
            label.Text = "Salesman Dashboard";
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Click += label2_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.WhiteSmoke;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(225, 94);
            pnlContent.Margin = new Padding(4, 4, 4, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1477, 806);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // SalesManDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1702, 900);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            Name = "SalesManDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salesman Dashboard";
            Load += SalesManDashboard_Load;
            pnlSidebar.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnStockCheck;
        private Button btnInvoice;
        private Button btnSellProduct;
        private Button btnOrderHistory;
        private Panel pnlHeader;
        private Label label;
        private Panel pnlContent;
        private Button btnLogout;
    }
}