using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMester21sept2023
{
    public partial class Form3 : Form
    {

        // Declare variables
        // Current score, time left, correct/wrong answer values are all saved in an int
        int currentScore = 0;
        int timeLeft = 30;
        int correctAnswers = 0;
        int wrongAnswers = 0;

        string selectedAnswer = "";

        // Get the questions from a class (Question.cs) and the database
        private List<Questions> questions = new List<Questions>();

      

        private int currentQuestionIndex = 0;

        public Form3()
        {
            InitializeComponent();
            LoadQuestionsFromDatabase();
            DisplayQuestion();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblQuestion.MaximumSize = new Size(350, 0);

            lblQuestion.AutoSize = true;

            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;

            lblQuestion.Left = this.Width / 2 - (lblQuestion.Width / 2);

            lblQuestion.Top = btnAnswerA.Top - lblQuestion.Height - 20;

            lblCurrentScore.Text = currentScore.ToString();

            //Always start at 30 seconds
            tmrTimeLeft.Stop();
            timeLeft = 30;

            //ClearSelection();
            lblScoreIndicator.Text = "";
            lblTimeLeft.Text = timeLeft.ToString();
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
                            // Fetch all data from the row the query was executed on
                            string question = reader.GetString(0);
                            string falseAnswerOne = reader.GetString(1);
                            string falseAnswerTwo = reader.GetString(2);
                            string falseAnswerThree = reader.GetString(3);
                            string correctAnswer = reader.GetString(4);

                            // Save the data into a List item
                            List<string> options = new List<string>();

                            options.Add(falseAnswerOne);
                            options.Add(falseAnswerTwo);
                            options.Add(falseAnswerThree);
                            options.Add(correctAnswer);

                            Random random = new Random();
                            int n = options.Count;

                            for (int i = options.Count; i < 4; i--)
                            {
                                int rnd = random.Next(i + 1);

                                var value = options[rnd];
                                options[rnd] = options[i];
                                options[i] = value;
                            }
                            List<string> optionList = new List<string>();
                            optionList = options;

                            
                            //// Shuffle the options randomly
                            //Random rng = new Random();
                            //int optionCount = options.Count;
                            //// While there is more than 1 option, shuffle the questions randomly
                            //while (optionCount > 1)
                            //{
                            //    // Decrement the options amount
                            //    optionCount--;
                            //    // Declare a next option by returning a non-negative int
                            //    // and increment 1 to the total amount
                            //    int optionNext = rng.Next(optionCount + 1);
                            //    // Save the value of the next option
                            //    string value = options[optionNext];
                            //    options[optionNext] = options[optionNext];
                            //    // Save the options into the value variable
                            //    options[optionNext] = value;
                            //}
                            // Save the question as an object, add the previous data into the object
                            Questions questionObject = new Questions(question, optionList, correctAnswer);
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
                // Add the data to the form elements
                lblQuestion.Text = question.Question;
                btnAnswerA.Text = question.Options[0];
                btnAnswerB.Text = question.Options[1];
                btnAnswerC.Text = question.Options[2];
                btnAnswerD.Text = question.Options[3];

                //MessageBox.Show(question.Options[0]);
            }
            else
            {
                // Show a MessageBox saying the quiz has been completed (unlikely)
                MessageBox.Show("Quiz completed!");
            }
        }


        private void tmrTimeLeft_Tick(object sender, EventArgs e)
        {
            // Decrement the user's time left
            timeLeft--;
            // Add the user's time left as a string into the form
            lblTimeLeft.Text = timeLeft.ToString();
      
            // Check if the user has ran out of time
            if (timeLeft == 0)
            {
                // Stop the timer
                tmrTimeLeft.Stop();
                // Show a message saying the time has ran out
                MessageBox.Show("Time's up, game over");
                //// Hide the quiz panel, display the data behind it
                //pnlQuizFinished.Visible = false;
                //// Add the user's data into the quiz' final data
                //lblUsername.Text = _username + "'s score";
                //lblFinalScore.Text = "Final score: " + currentScore.ToString();
                //lblCorrectAnswers.Text = "Correct answers: " + correctAnswers.ToString();
                //lblWrongAnswers.Text = "Wrong answers: " + wrongAnswers.ToString();
            }
        }


        private void btnAnswerA_Click(object sender, EventArgs e)
        {
            // Start the time left timer, save the selected answer into a string
            tmrTimeLeft.Start();

            // Evaluate the selected answer and save it into the string
            selectedAnswer = btnAnswerA.Text;

            CheckAnswer();
        }

        private void btnAnswerB_Click(object sender, EventArgs e)
        {
            // Start the time left timer, save the selected answer into a string
            tmrTimeLeft.Start();

            // Evaluate the selected answer and save it into the string
            selectedAnswer = btnAnswerB.Text;

            CheckAnswer();
        }

        private void btnAnswerC_Click(object sender, EventArgs e)
        {
            // Start the time left timer, save the selected answer into a string
            tmrTimeLeft.Start();

            // Evaluate the selected answer and save it into the string
            selectedAnswer = btnAnswerC.Text;

            CheckAnswer();
        }

        private void btnAnswerD_Click(object sender, EventArgs e)
        {
            // Start the time left timer, save the selected answer into a string
            tmrTimeLeft.Start();

            // Evaluate the selected answer and save it into the string
            selectedAnswer = btnAnswerD.Text;

            CheckAnswer();
        }

        private void CheckAnswer()
        {
            // Check if the answer was correct by getting the .CorrectAnswer value and comparing
            if (selectedAnswer == questions[currentQuestionIndex].CorrectAnswer)
            {
                // Increment the user's current score by 1 points
                currentScore++;
                // Add the user's current score into the score label (convert int to string)
                lblCurrentScore.Text = currentScore.ToString();
                // Display how many points the user got underneath the score indicator
                lblScoreIndicator.Text = "+ 1";
                lblScoreIndicator.ForeColor = Color.Green;
                // Increment the user's correct answers by 1
                correctAnswers += 1;
            }
            else
            {
                // Decrement the user's current score by 25 points
                currentScore--;
                // Add the user's current score into the score label (convert int to string)
                lblCurrentScore.Text = currentScore.ToString();
                // Display how many points the user got underneath the score indicator
                lblScoreIndicator.Text = "- 1";
                lblScoreIndicator.ForeColor = Color.Red;
                // Increment the user's wrong answers by 1
                wrongAnswers += 1;
            }


            // Increment the question index, clear all selections, display a new question
            currentQuestionIndex++;

            DisplayQuestion();
        }
    }
}
