using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_Solution
{
    public partial class SalesMan : Form
    {
        public SalesMan()
        {
            InitializeComponent();
        }

        private void LoadUserControl(UserControl uc)
        {
            pnlContent.Controls.Clear();       // Clear old content
            uc.Dock = DockStyle.Fill;                // Make it fill the panel
            pnlContent.Controls.Add(uc);       // Add new control
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ZH_MainMenu());
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ZH_GenerateInvoice());
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ZH_OrderHistory());
        }

        private void btnStockCheck_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ZH_StockCheck());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login adminForm = new Login();
            adminForm.Show();
            this.Hide();
        }

        private void SalesManDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

