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

    }
}
