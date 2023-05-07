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
            Close();
            Theory theoryForm= new Theory();
            theoryForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //TODO EXIT FROM THE SQLITE ACCOUNT FROM THE TABLE
            Close();
            Login login = new Login();
            login.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            Close();
            chooseTest chooseTest = new();
            chooseTest.Show();
        }

        private void suggestButton_Click(object sender, EventArgs e)
        {
            Close();
            Recommendation recommendation = new();
            recommendation.Show();
        }
    }
}
