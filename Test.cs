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
    public partial class Test : Form
    {
        private string speciality;
        private int score;

        public Test(string speciality)
        {
            InitializeComponent();
            this.speciality = speciality;
            score = 0;
            label1.Text = speciality;


            // Check the value of speciality and add specific options accordingly
            if (speciality == "Συστήματα Διαχείρισης Βάσεων Δεδομένων")
            {
                question1.Text = "what is ....1";
                radioButton1.Text = "dawdawd";
                radioButton2.Text = "dawddaw";
                radioButton3.Text = "dawdawd";
                radioButton4.Text = "dawdawd";
                // 
                question2.Text = "what is ....2";
                radioButton5.Text = "dawddaw";
                radioButton6.Text = "dawdawd";
                radioButton7.Text = "dawdawd";
                radioButton8.Text = "dawddaw";
                //
                question3.Text = "what is ....3";
                radioButton9.Text = "dawdawd";
                radioButton10.Text = "dawddaw";
                radioButton11.Text = "dawddaw";
                radioButton12.Text = "dawddaw";

            }
            else if (speciality == "Λογικός Προγραμματισμός")
            {
                question1.Text = "what is ....1";
                radioButton1.Text = "dawdawd";
                radioButton2.Text = "dawddaw";
                radioButton3.Text = "dawdawd";
                radioButton4.Text = "dawdawd";
                // 
                question2.Text = "what is ....2";
                radioButton5.Text = "dawddaw";
                radioButton6.Text = "dawdawd";
                radioButton7.Text = "dawdawd";
                radioButton8.Text = "dawddaw";
                //
                question3.Text = "what is ....3";
                radioButton9.Text = "dawdawd";
                radioButton10.Text = "dawddaw";
                radioButton11.Text = "dawddaw";
                radioButton12.Text = "dawddaw";

            }

            else if (speciality == "Εικονική Πραγματικότητα")
            {
                question1.Text = "what is ....1";
                radioButton1.Text = "dawdawd";
                radioButton2.Text = "dawddaw";
                radioButton3.Text = "dawdawd";
                radioButton4.Text = "dawdawd";
                // 
                question2.Text = "what is ....2";
                radioButton5.Text = "dawddaw";
                radioButton6.Text = "dawdawd";
                radioButton7.Text = "dawdawd";
                radioButton8.Text = "dawddaw";
                //
                question3.Text = "what is ....3";
                radioButton9.Text = "dawdawd";
                radioButton10.Text = "dawddaw";
                radioButton11.Text = "dawddaw";
                radioButton12.Text = "dawddaw";

            }

            else if (speciality == "Ηλεκτρονικό Επιχειρείν και Καινοτομία")
            {
                question1.Text = "what is ....1";
                radioButton1.Text = "dawdawd";
                radioButton2.Text = "dawddaw";
                radioButton3.Text = "dawdawd";
                radioButton4.Text = "dawdawd";
                // 
                question2.Text = "what is ....2";
                radioButton5.Text = "dawddaw";
                radioButton6.Text = "dawdawd";
                radioButton7.Text = "dawdawd";
                radioButton8.Text = "dawddaw";
                //
                question3.Text = "what is ....3";
                radioButton9.Text = "dawdawd";
                radioButton10.Text = "dawddaw";
                radioButton11.Text = "dawddaw";
                radioButton12.Text = "dawddaw";

            }

            else if (speciality == "Συστήματα Υποστήριξης Αποφάσεων")
            {
                question1.Text = "what is ....1";
                radioButton1.Text = "dawdawd";
                radioButton2.Text = "dawddaw";
                radioButton3.Text = "dawdawd";
                radioButton4.Text = "dawdawd";
                // 
                question2.Text = "what is ....2";
                radioButton5.Text = "dawddaw";
                radioButton6.Text = "dawdawd";
                radioButton7.Text = "dawdawd";
                radioButton8.Text = "dawddaw";
                //
                question3.Text = "what is ....3";
                radioButton9.Text = "dawdawd";
                radioButton10.Text = "dawddaw";
                radioButton11.Text = "dawddaw";
                radioButton12.Text = "dawddaw";

            }

            else if (speciality == "Κρυπτογραφία")
            {
                question1.Text = "what is ....1";
                radioButton1.Text = "dawdawd";
                radioButton2.Text = "dawddaw";
                radioButton3.Text = "dawdawd";
                radioButton4.Text = "dawdawd";
                // 
                question2.Text = "what is ....2";
                radioButton5.Text = "dawddaw";
                radioButton6.Text = "dawdawd";
                radioButton7.Text = "dawdawd";
                radioButton8.Text = "dawddaw";
                //
                question3.Text = "what is ....3";
                radioButton9.Text = "dawdawd";
                radioButton10.Text = "dawddaw";
                radioButton11.Text = "dawddaw";
                radioButton12.Text = "dawddaw";

            }

            else if (speciality == "Προηγμένη Αρχιτεκτονική Υπολογιστών")
            {
                question1.Text = "what is ....1";
                radioButton1.Text = "dawdawd";
                radioButton2.Text = "dawddaw";
                radioButton3.Text = "dawdawd";
                radioButton4.Text = "dawdawd";
                // 
                question2.Text = "what is ....2";
                radioButton5.Text = "dawddaw";
                radioButton6.Text = "dawdawd";
                radioButton7.Text = "dawdawd";
                radioButton8.Text = "dawddaw";
                //
                question3.Text = "what is ....3";
                radioButton9.Text = "dawdawd";
                radioButton10.Text = "dawddaw";
                radioButton11.Text = "dawddaw";
                radioButton12.Text = "dawddaw";

            }

            else if (speciality == "Κινητές και Ασύρματες Επικοινωνίες")
            {
                question1.Text = "what is ....1";
                radioButton1.Text = "dawdawd";
                radioButton2.Text = "dawddaw";
                radioButton3.Text = "dawdawd";
                radioButton4.Text = "dawdawd";
                // 
                question2.Text = "what is ....2";
                radioButton5.Text = "dawddaw";
                radioButton6.Text = "dawdawd";
                radioButton7.Text = "dawdawd";
                radioButton8.Text = "dawddaw";
                //
                question3.Text = "what is ....3";
                radioButton9.Text = "dawdawd";
                radioButton10.Text = "dawddaw";
                radioButton11.Text = "dawddaw";
                radioButton12.Text = "dawddaw";

            }

            else if (speciality == "Δίκτυα Υψηλών Ταχυτήτων")
            {
                question1.Text = "what is ....1";
                radioButton1.Text = "dawdawd";
                radioButton2.Text = "dawddaw";
                radioButton3.Text = "dawdawd";
                radioButton4.Text = "dawdawd";
                // 
                question2.Text = "what is ....2";
                radioButton5.Text = "dawddaw";
                radioButton6.Text = "dawdawd";
                radioButton7.Text = "dawdawd";
                radioButton8.Text = "dawddaw";
                //
                question3.Text = "what is ....3";
                radioButton9.Text = "dawdawd";
                radioButton10.Text = "dawddaw";
                radioButton11.Text = "dawddaw";
                radioButton12.Text = "dawddaw";

            }
            else if (speciality == "Επαναληπτικό Τεστ")
            {
                question1.Text = "what is ....1";
                radioButton1.Text = "dawdawd";
                radioButton2.Text = "dawddaw";
                radioButton3.Text = "dawdawd";
                radioButton4.Text = "dawdawd";
                // 
                question2.Text = "what is ....2";
                radioButton5.Text = "dawddaw";
                radioButton6.Text = "dawdawd";
                radioButton7.Text = "dawdawd";
                radioButton8.Text = "dawddaw";
                //
                question3.Text = "what is ....3";
                radioButton9.Text = "dawdawd";
                radioButton10.Text = "dawddaw";
                radioButton11.Text = "dawddaw";
                radioButton12.Text = "dawddaw";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            chooseTest chooseTest = new chooseTest();
            Hide();
            chooseTest.Show();
        }
    }
}
