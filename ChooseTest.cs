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
    public partial class chooseTest : Form
    {
        public static string speciality;

        public chooseTest()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //Thelei allagh
            Close();
            Menu menu = new(1);
            menu.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void softwareDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Προγραμματιστής Λογισμικού";
            Test test = new(speciality);
            Close();
            test.Show();
        }
        private void dataAnalyst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Αναλυτής Δεδομένων";
            Test test = new(speciality);
            Close();
            test.Show();
        }
        private void computerSystemAnalyst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Αναλυτής Συστήματος Υπολογιστών";
            Test test = new(speciality);
            Close();
            test.Show();
        }
        private void videoGameDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Προγραμματιστής Βιντεοπαιχνιδιών";
            Test test = new(speciality);
            Close();
            test.Show();
        }
        private void userExperienceDesign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Σχεδιαστής Εμπειρίας Χρήστη";
            Test test = new(speciality);
            Close();
            test.Show();
        }
        private void informationSecurity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Ασφάλεια Πληροφοριών";
            Test test = new(speciality);
            Close();
            test.Show();
        }
        private void networkEngineer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Μηχανικός Δικτύου";
            Test test = new(speciality);
            Close();
            test.Show();
        }
        private void machineLearning_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Μηχανική Μάθηση";
            Test test = new(speciality);
            Close();
            test.Show();
        }
        private void webDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Προγραμματιστής Ιστού";
            Test test = new(speciality); 
            Close();
            test.Show();
        }
        private void webDesigner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Σχεδιαστής Iστοσελίδων";
            Test test = new(speciality);
            Close();
            test.Show();
        }
    }
}
