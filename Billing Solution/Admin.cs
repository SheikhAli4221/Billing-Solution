using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Billing_Solution
{
    public partial class Admin : Form
    {



        public Admin()
        {
            InitializeComponent();
        }



        private void Admin_Load(object sender, EventArgs e)
        {
            MakePictureBoxRound(pictureBox1); // Ensure karo ke PictureBox ka name correct ho
            MakePictureBoxRound(pictureBox2);
            MakePictureBoxRound(pictureBox3);
            MakePictureBoxRound(pictureBox4);
            MakePictureBoxRound(pictureBox5);
            MakePictureBoxRound(pictureBox6);
        }

        private void MakePictureBoxRound(PictureBox picBox)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, picBox.Width, picBox.Height);
            picBox.Region = new Region(gp);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            // Yahaan per custom drawing ya background set kar sakte ho
            e.Graphics.FillRectangle(Brushes.LightGray, e.ClipRectangle);
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadUserControl(UserControl uc)
        {
            Panel.Controls.Clear();       // Clear old content
            uc.Dock = DockStyle.Fill;                // Make it fill the panel
            Panel.Controls.Add(uc);       // Add new control
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_ManagingUsers());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_SalesReport());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Supplier());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Inventory());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login adminForm = new Login();
            adminForm.Show();
            this.Hide();
        }
    }
}
