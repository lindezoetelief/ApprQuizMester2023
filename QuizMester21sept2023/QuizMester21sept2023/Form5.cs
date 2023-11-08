using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace QuizMester21sept2023
{
    public partial class Form5 : Form
    {
        // Declare variables        
        int timeCount = 0;
        int correctAnswers = 0;
        int wrongAnswers = 0;

        string selectedAnswer = "";

        DataTable dt = null;

        // Get the questions from a class (Question.cs) and the database
        private List<Questions> questions = new List<Questions>();

        private int currentQuestionIndex = 0;

        public Form5()
        {
            InitializeComponent();
            LoadQuestionsFromDatabase();
            DisplayQuestion();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            lblQuestion.MaximumSize = new Size(350, 0);

            lblQuestion.AutoSize = true;

            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;

            lblQuestion.Left = this.Width / 2 - (lblQuestion.Width / 2);

            lblQuestion.Top = btnAnswerA.Top - lblQuestion.Height - 20;

            //Always start at 0 seconds
            tmrTimeCounter.Stop();
            timeCount = 0;

            
            lblTimeIndicator.Text = "";
            lblTimeCounter.Text = timeCount.ToString();
        }


        private void LoadQuestionsFromDatabase()
        {
            // Database connection string
            string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=QuizMesterDatabase;Integrated Security=True";

            // Add a new SQL database connection using the connectionString
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the database connection
                connection.Open();
                // Add a query to select the questions, wrong answers and correct answer from the database
                // Order by NEWID() which sorts the question index randomly (built-in function)
                string query = "SELECT question, falseAnswerOne, falseAnswerTwo, falseAnswerThree, correctAnswer FROM Questions ORDER BY NEWID()";
                // Declare a new SQLCommand using the query and connectionString
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Declare a new SQL data reader to fetch data from the database
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // While the reader is active
                        while (reader.Read())
                        {
                            string question = reader.GetString(0);
                            string falseAnswerOne = reader.GetString(1);
                            string falseAnswerTwo = reader.GetString(2);
                            string falseAnswerThree = reader.GetString(3);
                            string correctAnswer = reader.GetString(4);


                            // Save the data into a List item
                            List<string> options = new List<string>
                            {
                                falseAnswerOne,
                                falseAnswerTwo,
                                falseAnswerThree,
                                correctAnswer
                            };

                            // Save the question as an object and add the previous data into the object
                            Questions questionObject = new Questions(question, options, correctAnswer);
                            questions.Add(questionObject);
                        }
                    }
                }
            }
        }


        private void DisplayQuestion()
        {
            // Check if there are any questions left
            if (currentQuestionIndex < questions.Count)
            {
                // Get the previously added data from the questions object at the selected question index
                Questions question = questions[currentQuestionIndex];

                ShuffleOptions(question.Options);
                // Add the data to the form elements
                lblQuestion.Text = question.Question + currentQuestionIndex;
                btnAnswerA.Text = question.Options[0];
                btnAnswerB.Text = question.Options[1];
                btnAnswerC.Text = question.Options[2];
                btnAnswerD.Text = question.Options[3];
            }
            else
            {
                // Show a MessageBox saying the quiz has been completed
                MessageBox.Show("Quiz completed! You ended with " + timeCount + " seconds");
                tmrTimeCounter.Stop();
                btnAnswerA.Enabled = false;
                btnAnswerB.Enabled = false;
                btnAnswerC.Enabled = false;
                btnAnswerD.Enabled = false;
            }
        }

        private void ShuffleOptions(List<string> options)
        {
            Random rng = new Random();
            int n = options.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = options[k];
                options[k] = options[n];
                options[n] = value;
            }
        }


        private void tmrTimeCounter_Tick(object sender, EventArgs e)
        {
            // Decrement the user's time left
            timeCount++;
            // Add the user's time left as a string into the form
            lblTimeCounter.Text = timeCount.ToString();
        }


        private void btnAnswerA_Click(object sender, EventArgs e)
        {
            // Start the time left timer, save the selected answer into a string
            tmrTimeCounter.Start();

            // Evaluate the selected answer and save it into the string
            selectedAnswer = btnAnswerA.Text;

            CheckAnswer();
        }

        private void btnAnswerB_Click(object sender, EventArgs e)
        {
            // Start the time left timer, save the selected answer into a string
            tmrTimeCounter.Start();

            // Evaluate the selected answer and save it into the string
            selectedAnswer = btnAnswerB.Text;

            CheckAnswer();
        }

        private void btnAnswerC_Click(object sender, EventArgs e)
        {
            // Start the time left timer, save the selected answer into a string
            tmrTimeCounter.Start();

            // Evaluate the selected answer and save it into the string
            selectedAnswer = btnAnswerC.Text;

            CheckAnswer();
        }

        private void btnAnswerD_Click(object sender, EventArgs e)
        {
            // Start the time left timer, save the selected answer into a string
            tmrTimeCounter.Start();

            // Evaluate the selected answer and save it into the string
            selectedAnswer = btnAnswerD.Text;

            CheckAnswer();
        }

        private void CheckAnswer()
        {
            // Check if the answer was correct by getting the .CorrectAnswer value and comparing
            if (selectedAnswer == questions[currentQuestionIndex].CorrectAnswer)
            {
                lblTimeIndicator.Text = "+ 0 seconds";
                lblTimeIndicator.ForeColor = Color.Green;
                correctAnswers += 1;

                if (correctAnswers == 10)
                {
                    MessageBox.Show("Game is finished, you have 10 correct answers and you ended up with " + timeCount + " seconds");
                    tmrTimeCounter.Stop();
                    btnAnswerA.Enabled = false;
                    btnAnswerB.Enabled = false;
                    btnAnswerC.Enabled = false;
                    btnAnswerD.Enabled = false;
                }
            }
            else
            {
                // Add 5 seconds to the time
                timeCount = timeCount + 5;

                lblTimeIndicator.Text = "+ 5 seconds";
                lblTimeIndicator.ForeColor = Color.Red;
                // Increment the user's wrong answers by 1
                wrongAnswers += 1;
            }

            // Increment the question index, clear all selections, display a new question
            currentQuestionIndex++;

            DisplayQuestion();
        }
    }
}

