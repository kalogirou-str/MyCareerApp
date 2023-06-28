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

    public partial class Recommendation : Form
    {
        public static int new_current_user_id;
        public Recommendation(int current_user_id)
        {
            InitializeComponent();
            new_current_user_id = current_user_id;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
            Menu menu = new Menu(new_current_user_id);
            menu.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Recommendation_Load(object sender, EventArgs e)
        {
            chosenSpeciality1.Text = "1";
            chosenSpeciality2.Text = "2";
            chosenSpeciality3.Text = "3";

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the help message you want to display.", "Βοήθεια");
        }
    }
}
