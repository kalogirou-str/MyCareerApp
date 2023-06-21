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

        private void InitializeUI()
        {
            // Set up the initial UI state
            score = 0;

            DisplayQuestions();
        }

        private void DisplayQuestions()
        {
            // Clear existing controls
            panelQuestions.Controls.Clear();

            // Display all the questions
            for (int i = 0; i < questions.Count; i++)
            {
                Question currentQuestion = questions[i];

                // Create a label for the question
                Label lblQuestion = new Label
                {
                    Text = currentQuestion.Text,
                    AutoSize = true,
                    Top = i * 60
                };
                panelQuestions.Controls.Add(lblQuestion);

                // Create radio buttons for the answer choices
                List<RadioButton> radioButtons = new List<RadioButton>();
                for (int j = 0; j < currentQuestion.Options.Count; j++)
                {
                    RadioButton radioButton = new RadioButton
                    {
                        Text = currentQuestion.Options[j],
                        AutoSize = true,
                        Top = i * 60 + 30,
                        Left = j * 100
                    };
                    panelQuestions.Controls.Add(radioButton);
                    radioButtons.Add(radioButton);
                }

                // Add an event handler for the radio buttons' CheckedChanged event
                foreach (RadioButton radioButton in radioButtons)
                {
                    radioButton.CheckedChanged += (sender, e) =>
                    {
                        if (radioButton.Checked)
                            EvaluateAnswer(currentQuestion, radioButton.Text);
                    };
                }
            }
        }

        private void EvaluateAnswer(Question question, string selectedAnswer)
        {
            if (selectedAnswer == question.CorrectAnswer)
                score++;
        }

        private void ShowScore()
        {
            // Display the final score
            MessageBox.Show($"Your score: {score}/{questions.Count}", "Test Complete");
            Close();
        }

    }
}
