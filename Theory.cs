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
        private void softwareDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Προγραμματιστής Λογισμικού";
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void dataAnalyst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Αναλυτής Δεδομένων";
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void computerSystemAnalyst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Αναλυτής Συστήματος Υπολογιστών";
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void videoGameDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Προγραμματιστής Βιντεοπαιχνιδιών";
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void userExperienceDesign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Σχεδιαστής Εμπειρίας Χρήστη";
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void informationSecurity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Ασφάλεια Πληροφοριών";
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void networkEngineer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Μηχανικός Δικτύου";
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void machineLearning_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Μηχανική Μάθηση";
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void webDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Προγραμματιστής Ιστού";
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void webDesigner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Σχεδιαστής Iστοσελίδων";
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
    }
}
