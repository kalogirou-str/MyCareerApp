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
    public partial class PsyCoursesListForm : Form
    {
        public PsyCoursesListForm()
        {
            InitializeComponent();
        }

        private void cryptographyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowTheory showTheory = new ShowTheory(1);
            Close();
            showTheory.Show();
        }

        private void securityLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowTheory showTheory = new ShowTheory(1);
            Close();
            showTheory.Show();
        }

        private void dataAnalyticsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowTheory showTheory = new ShowTheory(1);
            Close();
            showTheory.Show();
        }
    }
}
