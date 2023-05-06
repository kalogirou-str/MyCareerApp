using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCareerApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void theoryButton_Click(object sender, EventArgs e)
        {
            Hide();
            Theory theoryForm= new Theory();
            theoryForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //TODO EXIT FROM THE SQLITE ACCOUNT FROM THE TABLE
            Login login = new Login();
            login.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
