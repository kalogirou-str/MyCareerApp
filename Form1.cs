using System.Data.SQLite;

namespace MyCareerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "User.db");
            string connectionString = $"Data Source={databasePath};Version=3;";
            string query = "SELECT * FROM Users WHERE Username=@username AND Password=@password";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", usernameTextBox.Text);
                command.Parameters.AddWithValue("@password", passwordTextBox.Text);

                connection.Open();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Login successful!");
                        Menu menu= new Menu();
                        this.Hide();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
        }

    }
}