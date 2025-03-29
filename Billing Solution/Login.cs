using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Billing_Solution
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
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
            string username = Username.Text;  // MaskedTextBox for Username
            string password = Password.Text;  // MaskedTextBox for Password

            // Role-Based Authentication Without Database
            if (username == "admin" && password == "1234")
            {
                // Open Admin Form
                Admin adminForm = new Admin();
                adminForm.Show();
                this.Hide(); // Hide Login Form
            }
            else if (username == "inventory" && password == "1234")
            {
                // Open Inventory Manager Form
                InventoryManager invManagerForm = new InventoryManager();
                invManagerForm.Show();
                this.Hide();
            }
            else if (username == "sales" && password == "1234")
            {
                // Open Sales Manager Form
                SalesManDashboard salesManagerForm = new SalesManDashboard();
                salesManagerForm.Show();
                this.Hide();
            }
            else
            {
                // Invalid Credentials Message
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
