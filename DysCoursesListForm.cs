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
    public partial class DysCoursesListForm : Form
    {
        int new_current_user_id;
        public DysCoursesListForm(int current_user_id)
        {
            InitializeComponent();
            new_current_user_id = current_user_id;
        }

        private void computerDesignLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowTheory showTheory = new ShowTheory(1, new_current_user_id);
            Close();
            showTheory.Show();
        }

        private void ArchitectureLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowTheory showTheory = new ShowTheory(5, new_current_user_id);
            Close();
            showTheory.Show();
        }

        private void securityLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowTheory showTheory = new ShowTheory(4, new_current_user_id);
            Close();
            showTheory.Show();
        }
    }
}
