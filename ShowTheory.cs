using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyCareerApp
{
    public partial class ShowTheory : Form
    {
        public static int new_current_user_id;
        public ShowTheory(int current_user_id)
        {
            InitializeComponent();
            new_current_user_id= current_user_id;
        }

        private void ShowTheory_Load(object sender, EventArgs e)
        {
             if (Theory.speciality == "Καινοτομία στο Ηλεκτρονικό Επιχειρείν") { 
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\hlektronikoEpixeirin.txt");
            string fileText = File.ReadAllText(filePath);
            richTextBox1.Text = fileText;
            speciality.Text = Theory.speciality;
            }
            if (Theory.speciality == "Εικονική Πραγματικότητα")
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\eikonikiPragmatikotita.txt");
                string fileText = File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
                speciality.Text = Theory.speciality;
            }
            if (Theory.speciality == "Συστήματα Διαχείρισης Βάσεων Δεδομένων")
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\sdvd.txt");
                string fileText = File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
                speciality.Text = Theory.speciality;
            }
            if (Theory.speciality == "Λογικός Προγραμματισμός")
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\logikosProgrammatismos.txt");
                string fileText = File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
                speciality.Text = Theory.speciality;
            }
            if (Theory.speciality == "Προηγμένη Αρχιτεκτονική Υπολογιστών")
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\prohgmenhArxitektonikiYpologistwn.txt");
                string fileText = File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
                speciality.Text = Theory.speciality;
            }
            if (Theory.speciality == "Κινητές και Ασύρματες Επικοινωνίες")
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\kinites_asirmatesEpikoinwnies.txt");
                string fileText = File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
                speciality.Text = Theory.speciality;
            }
            if (Theory.speciality == "Δίκτυα Υψηλών Ταχυτήτων")
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\diktyaYpsilwnTaxythtwn.txt");
                string fileText = File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
                speciality.Text = Theory.speciality;
            }
            if (Theory.speciality == "Κρυπτογραφία")
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\kryptografia.txt");
                string fileText = File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
                speciality.Text = Theory.speciality;
            }
            if (Theory.speciality == "Συστήματα Υποστήριξης Αποφάσεων")
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\sya.txt");
                string fileText = File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
                speciality.Text = Theory.speciality;
            }

        }
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            Close();
            Theory theoryForm = new Theory(new_current_user_id);
            theoryForm.Show();
        }
    }
}
