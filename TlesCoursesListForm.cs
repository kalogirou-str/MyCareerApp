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
    public partial class TlesCoursesListForm : Form
    {
        int new_current_user_id;
        public TlesCoursesListForm(int current_user_id)
        {
            InitializeComponent();
            new_current_user_id = current_user_id;
        }

        private void androidLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowTheory showTheory = new ShowTheory(1, new_current_user_id);
            Close();
            showTheory.Show();
        }

        private void naturalLanguageProcessLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowTheory showTheory = new ShowTheory(1, new_current_user_id);
            Close();
            showTheory.Show();
        }

        private void bioinformaticsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowTheory showTheory = new ShowTheory(1, new_current_user_id);
            Close();
            showTheory.Show();
        }
    }
}
