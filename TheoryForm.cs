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
    public partial class TheoryForm : Form
    {
        public static string speciality;
        public TheoryForm()
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
    }
}
