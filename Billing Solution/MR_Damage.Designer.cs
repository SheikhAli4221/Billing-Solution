namespace Billing_Solution
{
    partial class MR_Damage
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
            panel1 = new Panel();
            btnClearSearchDamage = new Button();
            label1 = new Label();
            textBoxSearchDamage = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Image = new DataGridViewImageColumn();
            Name = new DataGridViewTextBoxColumn();
            SalePrice = new DataGridViewTextBoxColumn();
            CostPrice = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(btnClearSearchDamage);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxSearchDamage);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 119);
            panel1.TabIndex = 3;
            // 
            // btnClearSearchDamage
            // 
            btnClearSearchDamage.BackColor = Color.FromArgb(37, 37, 38);
            btnClearSearchDamage.Cursor = Cursors.Hand;
            btnClearSearchDamage.FlatStyle = FlatStyle.Flat;
            btnClearSearchDamage.ForeColor = Color.White;
            btnClearSearchDamage.Location = new Point(1188, 82);
            btnClearSearchDamage.Name = "btnClearSearchDamage";
            btnClearSearchDamage.Size = new Size(112, 34);
            btnClearSearchDamage.TabIndex = 6;
            btnClearSearchDamage.Text = "Clear";
            btnClearSearchDamage.UseVisualStyleBackColor = false;
            btnClearSearchDamage.Click += btnClearSearchDamage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(294, 54);
            label1.TabIndex = 0;
            label1.Text = "Damage Stock";
            // 
            // textBoxSearchDamage
            // 
            textBoxSearchDamage.Location = new Point(885, 84);
            textBoxSearchDamage.Name = "textBoxSearchDamage";
            textBoxSearchDamage.Size = new Size(281, 31);
            textBoxSearchDamage.TabIndex = 5;
            textBoxSearchDamage.Text = "Search..";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1411, 900);
            panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Image, Name, SalePrice, CostPrice, Category, Stock, Delete });
            dataGridView1.Location = new Point(23, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1364, 759);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            // 
            // Image
            // 
            Image.HeaderText = "Image";
            Image.MinimumWidth = 8;
            Image.Name = "Image";
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            // 
            // SalePrice
            // 
            SalePrice.HeaderText = "Sale Price";
            SalePrice.MinimumWidth = 8;
            SalePrice.Name = "SalePrice";
            // 
            // CostPrice
            // 
            CostPrice.HeaderText = "Cost Price";
            CostPrice.MinimumWidth = 8;
            CostPrice.Name = "CostPrice";
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 8;
            Stock.Name = "Stock";
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            // 
            // MR_Damage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
           
            Size = new Size(1411, 900);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnClearSearchDamage;
        private Label label1;
        private TextBox textBoxSearchDamage;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewImageColumn Image;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn SalePrice;
        private DataGridViewTextBoxColumn CostPrice;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Delete;
    }
}
