using System.Data.SqlClient;
using System.Data.SQLite;

namespace MyCareerApp
{
    public partial class Theory : Form
    {
        public static string speciality;
        public static string speciality_id;
        public static int new_current_user_id;
        public Theory(int current_user_id)
        {
            InitializeComponent();
            current_user_id = new_current_user_id;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            //Thelei allagh
            Close();
            Menu menu = new Menu(1);
            menu.Show();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void softwareDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Προγραμματιστής Λογισμικού";
            int specialityID = GetSpecialityID(speciality);
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void dataAnalyst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Αναλυτής Δεδομένων";
            int specialityID = GetSpecialityID(speciality);
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void computerSystemAnalyst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Αναλυτής Συστήματος Υπολογιστών";
            int specialityID = GetSpecialityID(speciality);
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void videoGameDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Προγραμματιστής Βιντεοπαιχνιδιών";
            int specialityID = GetSpecialityID(speciality);
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void userExperienceDesign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Σχεδιαστής Εμπειρίας Χρήστη";
            int specialityID = GetSpecialityID(speciality);
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void informationSecurity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Ασφάλεια Πληροφοριών";
            int specialityID = GetSpecialityID(speciality);
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void networkEngineer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Μηχανικός Δικτύου";
            int specialityID = GetSpecialityID(speciality);
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void machineLearning_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Μηχανική Μάθηση";
            int specialityID = GetSpecialityID(speciality);
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void webDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Προγραμματιστής Ιστού";
            int specialityID = GetSpecialityID(speciality);
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }
        private void webDesigner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Σχεδιαστής Iστοσελίδων";
            int specialityID = GetSpecialityID(speciality);
            ShowTheory showTheory = new ShowTheory();
            Close();
            showTheory.Show();
        }

        private int GetSpecialityID(string specialityName)
        {
            int specialityID = -1; // default value in case no matching record is found

            string connectionString = "Data Source=User.db;Version=3;";
            string sql = "SELECT ID FROM Specialities WHERE Name = @specialityName";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@specialityName", specialityName);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            specialityID = reader.GetInt32(0);
                        }
                    }
                }
                connection.Close();
            }

            return specialityID;
        }

    }
}
