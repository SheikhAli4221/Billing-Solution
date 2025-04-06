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
    public partial class InventoryManager : Form
    {
        public InventoryManager()
        {
            InitializeComponent();
        }

        private void InventoryManager_Load(object sender, EventArgs e)
        {

        }

        private void LoadUserControl(UserControl uc)
        {
            Panel.Controls.Clear();       // Clear old content
            uc.Dock = DockStyle.Fill;                // Make it fill the panel
            Panel.Controls.Add(uc);       // Add new control
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Login adminForm = new Login();
            adminForm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadUserControl(new MR_Entry());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LoadUserControl(new MR_Low());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LoadUserControl(new MR_Manage());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LoadUserControl(new MR_Damage());
        }


    }
}
