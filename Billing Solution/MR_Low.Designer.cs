namespace Billing_Solution
{
    partial class MR_Low
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MR_Low));
            dataGridViewInventoryLow = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            btnReorderStock = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventoryLow).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewInventoryLow
            // 
            dataGridViewInventoryLow.AllowUserToOrderColumns = true;
            dataGridViewInventoryLow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInventoryLow.BackgroundColor = Color.White;
            dataGridViewInventoryLow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventoryLow.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridViewInventoryLow.Dock = DockStyle.Fill;
            dataGridViewInventoryLow.Location = new Point(0, 0);
            dataGridViewInventoryLow.Name = "dataGridViewInventoryLow";
            dataGridViewInventoryLow.RowHeadersVisible = false;
            dataGridViewInventoryLow.RowHeadersWidth = 62;
            dataGridViewInventoryLow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInventoryLow.Size = new Size(1298, 527);
            dataGridViewInventoryLow.TabIndex = 7;
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
            Column7.HeaderText = "Stock";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Delete";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1127, 144);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(909, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 31);
            textBox1.TabIndex = 7;
            textBox1.Text = "Search..";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 54);
            label1.TabIndex = 0;
            label1.Text = "Low Stock";
            // 
            // btnReorderStock
            // 
            btnReorderStock.BackColor = Color.Black;
            btnReorderStock.Cursor = Cursors.Hand;
            btnReorderStock.FlatStyle = FlatStyle.Flat;
            btnReorderStock.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReorderStock.ForeColor = Color.White;
            btnReorderStock.Image = (Image)resources.GetObject("btnReorderStock.Image");
            btnReorderStock.ImageAlign = ContentAlignment.MiddleLeft;
            btnReorderStock.Location = new Point(915, 92);
            btnReorderStock.Name = "btnReorderStock";
            btnReorderStock.Size = new Size(194, 46);
            btnReorderStock.TabIndex = 4;
            btnReorderStock.Text = "Reorder Stock";
            btnReorderStock.TextAlign = ContentAlignment.MiddleRight;
            btnReorderStock.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(dataGridViewInventoryLow);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(1298, 527);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnReorderStock);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1298, 181);
            panel1.TabIndex = 2;
            // 
            // MR_Low
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MR_Low";
            Size = new Size(1298, 708);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventoryLow).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewInventoryLow;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button btnReorderStock;
        private Panel panel2;
        private Panel panel1;
    }
}
