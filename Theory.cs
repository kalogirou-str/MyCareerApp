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
    public partial class Theory : Form
    {
        public static string speciality;
        public Theory()
        {
            InitializeComponent();
        }

        private void softwareDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "softwareDeveloper";
            ShowTheory showTheory = new ShowTheory();
            Hide();
            showTheory.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
