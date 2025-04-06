namespace Billing_Solution
{
    partial class SalesMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesMan));
            pnlSidebar = new Panel();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            btnStockCheck = new Button();
            pictureBox10 = new PictureBox();
            btnLogOut = new Button();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnMainMenu = new Button();
            btnGenerateInvoice = new Button();
            btnOrderHistory = new Button();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.DimGray;
            pnlSidebar.Controls.Add(button8);
            pnlSidebar.Controls.Add(pictureBox1);
            pnlSidebar.Controls.Add(pictureBox7);
            pnlSidebar.Controls.Add(btnStockCheck);
            pnlSidebar.Controls.Add(pictureBox10);
            pnlSidebar.Controls.Add(btnLogOut);
            pnlSidebar.Controls.Add(pictureBox6);
            pnlSidebar.Controls.Add(pictureBox5);
            pnlSidebar.Controls.Add(pictureBox4);
            pnlSidebar.Controls.Add(btnMainMenu);
            pnlSidebar.Controls.Add(btnGenerateInvoice);
            pnlSidebar.Controls.Add(btnOrderHistory);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(282, 900);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.BackgroundImageLayout = ImageLayout.None;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(94, 32);
            button8.Name = "button8";
            button8.Size = new Size(158, 76);
            button8.TabIndex = 24;
            button8.Text = "Sales Man";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 32);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(3, 461);
            pictureBox7.Margin = new Padding(4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(52, 61);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // btnStockCheck
            // 
            btnStockCheck.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStockCheck.BackColor = Color.Transparent;
            btnStockCheck.FlatAppearance.BorderSize = 0;
            btnStockCheck.FlatStyle = FlatStyle.Flat;
            btnStockCheck.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockCheck.ForeColor = Color.Black;
            btnStockCheck.Location = new Point(12, 462);
            btnStockCheck.Margin = new Padding(0);
            btnStockCheck.Name = "btnStockCheck";
            btnStockCheck.Padding = new Padding(6, 12, 6, 12);
            btnStockCheck.Size = new Size(270, 60);
            btnStockCheck.TabIndex = 14;
            btnStockCheck.Text = "    Check Stock";
            btnStockCheck.UseVisualStyleBackColor = false;
            btnStockCheck.Click += btnStockCheck_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(4, 828);
            pictureBox10.Margin = new Padding(4);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(52, 50);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 20;
            pictureBox10.TabStop = false;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.Black;
            btnLogOut.Location = new Point(0, 815);
            btnLogOut.Margin = new Padding(0);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(6, 12, 6, 12);
            btnLogOut.Size = new Size(282, 76);
            btnLogOut.TabIndex = 19;
            btnLogOut.Text = "    Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(4, 375);
            pictureBox6.Margin = new Padding(4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(52, 61);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 290);
            pictureBox5.Margin = new Padding(4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(52, 61);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 212);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 51);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMainMenu.BackColor = Color.DimGray;
            btnMainMenu.FlatAppearance.BorderSize = 0;
            btnMainMenu.FlatStyle = FlatStyle.Flat;
            btnMainMenu.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMainMenu.ForeColor = Color.Black;
            btnMainMenu.Location = new Point(-4, 212);
            btnMainMenu.Margin = new Padding(0);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Padding = new Padding(6, 12, 6, 12);
            btnMainMenu.Size = new Size(282, 62);
            btnMainMenu.TabIndex = 10;
            btnMainMenu.Text = "    Main Menu";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnGenerateInvoice
            // 
            btnGenerateInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGenerateInvoice.BackColor = Color.DimGray;
            btnGenerateInvoice.FlatAppearance.BorderSize = 0;
            btnGenerateInvoice.FlatStyle = FlatStyle.Flat;
            btnGenerateInvoice.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateInvoice.ForeColor = Color.Black;
            btnGenerateInvoice.Location = new Point(-4, 290);
            btnGenerateInvoice.Margin = new Padding(0);
            btnGenerateInvoice.Name = "btnGenerateInvoice";
            btnGenerateInvoice.Padding = new Padding(6, 12, 6, 12);
            btnGenerateInvoice.Size = new Size(282, 61);
            btnGenerateInvoice.TabIndex = 11;
            btnGenerateInvoice.Text = "  Invoice";
            btnGenerateInvoice.UseVisualStyleBackColor = false;
            btnGenerateInvoice.Click += btnGenerateInvoice_Click;
            // 
            // btnOrderHistory
            // 
            btnOrderHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOrderHistory.BackColor = Color.DimGray;
            btnOrderHistory.FlatAppearance.BorderSize = 0;
            btnOrderHistory.FlatStyle = FlatStyle.Flat;
            btnOrderHistory.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrderHistory.ForeColor = Color.Black;
            btnOrderHistory.Location = new Point(0, 378);
            btnOrderHistory.Margin = new Padding(0);
            btnOrderHistory.Name = "btnOrderHistory";
            btnOrderHistory.Padding = new Padding(6, 12, 6, 12);
            btnOrderHistory.Size = new Size(282, 61);
            btnOrderHistory.TabIndex = 12;
            btnOrderHistory.Text = "History";
            btnOrderHistory.UseVisualStyleBackColor = false;
            btnOrderHistory.Click += btnOrderHistory_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.WhiteSmoke;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(282, 0);
            pnlContent.Margin = new Padding(4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1420, 900);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // SalesMan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1702, 900);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            Name = "SalesMan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salesman Dashboard";
            Load += SalesManDashboard_Load;
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlContent;
        private PictureBox pictureBox10;
        private Button btnLogOut;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Button btnMainMenu;
        private Button btnGenerateInvoice;
        private Button btnOrderHistory;
        private Button btnStockCheck;
        private Button button8;
        private PictureBox pictureBox1;
    }
}