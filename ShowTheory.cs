﻿using System;
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
        public ShowTheory()
        {
            InitializeComponent();
        }

        private void ShowTheory_Load(object sender, EventArgs e)
        {
            if (Theory.speciality == "Προγραμματιστής Λογισμικού") { 
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\softwareDeveloper.txt");
            string fileText = File.ReadAllText(filePath);
            richTextBox1.Text = fileText;
            speciality.Text = Theory.speciality;
            }
            if (Theory.speciality == "Αναλυτής Δεδομένων")
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\dataAnalyst.txt");
                string fileText = File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
                speciality.Text = Theory.speciality;
            }
            if (Theory.speciality == "Αναλυτής Συστήματος Υπολογιστών")
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\computerSystemAnalyst.txt");
                string fileText = File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
                speciality.Text = Theory.speciality;
            }
            if (Theory.speciality == "Προγραμματιστής Βιντεοπαιχνιδιών")
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\videoGameDeveloper.txt");
                string fileText = File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
                speciality.Text = Theory.speciality;
            }
            if (Theory.speciality == "Σχεδιαστής Εμπειρίας Χρήστη")
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\userExperienceDesigner.txt");
                string fileText = File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
                speciality.Text = Theory.speciality;
            }
            if (Theory.speciality == "Ασφάλεια Πληροφοριών")
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\informationSecurity.txt");
                string fileText = File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
                speciality.Text = Theory.speciality;
            }
            if (Theory.speciality == "Μηχανικός Δικτύου")
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\networkEngineer.txt");
                string fileText = File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
                speciality.Text = Theory.speciality;
            }
            if (Theory.speciality == "Μηχανική Μάθηση")
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\machineLearning.txt");
                string fileText = File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
                speciality.Text = Theory.speciality;
            }
            if (Theory.speciality == "Προγραμματιστής Ιστού")
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\webDeveloper.txt");
                string fileText = File.ReadAllText(filePath);
                richTextBox1.Text = fileText;
                speciality.Text = Theory.speciality;
            }
            if (Theory.speciality == "Σχεδιαστής Iστοσελίδων")
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Theory\\webDesigner.txt");
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
            Theory theoryForm = new Theory();
            theoryForm.Show();
        }
    }
}
