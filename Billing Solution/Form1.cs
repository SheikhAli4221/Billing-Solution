using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Billing_Solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeButtonRounded(button1); // Apply rounded shape to button1
        }

        private void MakeButtonRounded(Button button)
        {
            int cornerRadius = 20; // Adjust the roundness of the edges
            GraphicsPath path = new GraphicsPath();

            // Create a rounded rectangle
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Top-left corner
            path.AddArc(button.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Top-right
            path.AddArc(button.Width - cornerRadius, button.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Bottom-right
            path.AddArc(0, button.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Bottom-left
            path.CloseFigure();

            // Apply the rounded region to the button
            button.Region = new Region(path);

            // Optional: Remove default button border
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
