namespace Billing_Solution
{
    partial class MR_Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MR_Manage));
            dataGridViewInventory = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBoxFilter = new ComboBox();
            btnNewProduct = new Button();
            btnReorderStock = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            btnRemoveWhole = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewInventory
            // 
            dataGridViewInventory.AllowUserToOrderColumns = true;
            dataGridViewInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInventory.BackgroundColor = Color.White;
            dataGridViewInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventory.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewInventory.Dock = DockStyle.Fill;
            dataGridViewInventory.Location = new Point(0, 0);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewInventory.RowHeadersVisible = false;
            dataGridViewInventory.RowHeadersWidth = 62;
            dataGridViewInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInventory.Size = new Size(1411, 719);
            dataGridViewInventory.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Image";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Name";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Category";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Sale Price";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Cost Price";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Quantity";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(280, 141);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 31);
            textBox1.TabIndex = 7;
            textBox1.Text = "Search..";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Copperplate Gothic Bold", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(480, 63);
            label1.TabIndex = 0;
            label1.Text = "Manage Stock";
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.BackColor = Color.White;
            comboBoxFilter.FlatStyle = FlatStyle.Flat;
            comboBoxFilter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilter.ForeColor = Color.FromArgb(37, 37, 38);
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Low stock", "Out of stock ", "All stock" });
            comboBoxFilter.Location = new Point(519, 126);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(182, 36);
            comboBoxFilter.TabIndex = 6;
            // 
            // btnNewProduct
            // 
            btnNewProduct.BackColor = Color.Black;
            btnNewProduct.Cursor = Cursors.Hand;
            btnNewProduct.FlatStyle = FlatStyle.Flat;
            btnNewProduct.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewProduct.ForeColor = Color.White;
            btnNewProduct.Image = (Image)resources.GetObject("btnNewProduct.Image");
            btnNewProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewProduct.Location = new Point(717, 126);
            btnNewProduct.Name = "btnNewProduct";
            btnNewProduct.Size = new Size(207, 46);
            btnNewProduct.TabIndex = 5;
            btnNewProduct.Text = "New Product";
            btnNewProduct.TextAlign = ContentAlignment.MiddleRight;
            btnNewProduct.UseVisualStyleBackColor = false;
            // 
            // btnReorderStock
            // 
            btnReorderStock.BackColor = Color.Black;
            btnReorderStock.Cursor = Cursors.Hand;
            btnReorderStock.FlatStyle = FlatStyle.Flat;
            btnReorderStock.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReorderStock.ForeColor = Color.White;
            btnReorderStock.ImageAlign = ContentAlignment.MiddleRight;
            btnReorderStock.Location = new Point(1186, 129);
            btnReorderStock.Name = "btnReorderStock";
            btnReorderStock.Size = new Size(194, 46);
            btnReorderStock.TabIndex = 4;
            btnReorderStock.Text = "Remove Quantity";
            btnReorderStock.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(dataGridViewInventory);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(1411, 719);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(btnRemoveWhole);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBoxFilter);
            panel1.Controls.Add(btnNewProduct);
            panel1.Controls.Add(btnReorderStock);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 181);
            panel1.TabIndex = 2;
            // 
            // btnRemoveWhole
            // 
            btnRemoveWhole.BackColor = Color.Black;
            btnRemoveWhole.Cursor = Cursors.Hand;
            btnRemoveWhole.FlatStyle = FlatStyle.Flat;
            btnRemoveWhole.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveWhole.ForeColor = Color.White;
            btnRemoveWhole.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemoveWhole.Location = new Point(973, 129);
            btnRemoveWhole.Name = "btnRemoveWhole";
            btnRemoveWhole.Size = new Size(207, 46);
            btnRemoveWhole.TabIndex = 9;
            btnRemoveWhole.Text = "Remove Whole";
            btnRemoveWhole.TextAlign = ContentAlignment.MiddleRight;
            btnRemoveWhole.UseVisualStyleBackColor = false;
            // 
            // MR_Manage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MR_Manage";
            Size = new Size(1411, 900);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewInventory;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBoxFilter;
        private Button btnNewProduct;
        private Button btnReorderStock;
        private Panel panel2;
        private Panel panel1;
        private Button btnRemoveWhole;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}
