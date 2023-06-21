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
        private List<Question> questions;
        private int score;

        public Test(string speciality)
        {
            InitializeComponent();
            this.speciality = speciality;
        }

        private void InitializeQuestions()
        {
            // Create a list of questions
            questions = new List<Question>
            {
                new Question("What is the capital of France?", new List<string> { "Paris", "Madrid", "Berlin" }, "Paris"),
                new Question("Which planet is known as the Red Planet?", new List<string> { "Mars", "Venus", "Jupiter" }, "Mars"),
                new Question("Who painted the Mona Lisa?", new List<string> { "Leonardo da Vinci", "Pablo Picasso", "Vincent van Gogh" }, "Leonardo da Vinci")
            };
        }

       
    }
}
