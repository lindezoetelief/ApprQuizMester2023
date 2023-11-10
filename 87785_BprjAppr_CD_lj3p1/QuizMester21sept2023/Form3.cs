using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
// For audio
using System.IO;
using System.Runtime.InteropServices;
using QuizMester21sept2023.Properties;
using static System.Windows.Forms.LinkLabel;
using System.Xml.Linq;
using System.Media;

namespace QuizMester21sept2023
{
    public partial class Form3 : Form
    {
        // Declare variables
        int currentScore = 0;
        int timeLeft = 30;
        int correctAnswers = 0;
        int wrongAnswers = 0;

        bool removeUsed = false;

        string selectedAnswer = "";

        bool specialQuestionIsActive = false; 

        DataTable dt = null;

        // Get the questions from a class (Question.cs) and the database
        private List<Questions> questions = new List<Questions>();

        private Database db;

        // Random number for the special question, between 1 and 21
        Random random = new Random();
        int randomNumber = 0;

        //Forms
        Form5 specialQuizForm = new Form5();

        int loggedinUserID;

        private int currentQuestionIndex = 0;

        public Form3(int userID)
        {
            InitializeComponent();
            LoadQuestionsFromDatabase();
            DisplayQuestion();
            loggedinUserID = userID;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Styling for placing the buttons
            lblQuestion.MaximumSize = new Size(350, 0);
            lblQuestion.AutoSize = true;
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            lblQuestion.Left = this.Width / 2 - (lblQuestion.Width / 2);
            lblQuestion.Top = btnAnswerA.Top - lblQuestion.Height - 20;

            // Default design
            btnAnswerA.BackColor = Color.DarkSlateGray;
            btnAnswerB.BackColor = Color.DarkSlateGray;
            btnAnswerC.BackColor = Color.DarkSlateGray;
            btnAnswerD.BackColor = Color.DarkSlateGray;
            lblQuestion.ForeColor = Color.DarkSlateGray;
            pbxSpecialQuestion.Image = null;

            //Always start at 30 seconds
            tmrTimeLeft.Stop();
            timeLeft = 30;

            lblScoreIndicator.Text = "";
            lblTimeLeft.Text = timeLeft.ToString();
            lblCurrentScore.Text = currentScore.ToString();

            // Get random number
            randomNumber = random.Next(1, 21);
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
            // Default design
            btnAnswerA.BackColor = Color.DarkSlateGray;
            btnAnswerB.BackColor = Color.DarkSlateGray;
            btnAnswerC.BackColor = Color.DarkSlateGray;
            btnAnswerD.BackColor = Color.DarkSlateGray;
            lblQuestion.ForeColor = Color.DarkSlateGray;
            pbxSpecialQuestion.Image = null;

            string soundFilePath = "C:\\Users\\linde\\OneDrive\\Documents\\Appr\\Quizmester\\ApprQuizMester2023\\QuizMester21sept2023\\QuizMester21sept2023\\Resources\\special-song.wav";
            SoundPlayer player = null;

            // Check if there are any questions left
            if (currentQuestionIndex < questions.Count)
            {
                specialQuestionIsActive = false;

                // Get the previously added data from the questions object at the selected question index
                Questions question = questions[currentQuestionIndex];

                // Check if the question shown is equal to the randomrumber (so special question) and if the randomnumber is not 0 (default number)
                if (currentQuestionIndex == randomNumber && randomNumber != 0)
                {
                    specialQuestionIsActive = true;

                    lblQuestion.Text = question.Question;

                    ShuffleOptions(question.Options);
                    // Add the data to the form elements
                    lblQuestion.Text = question.Question;
                    btnAnswerA.Text = question.Options[0];
                    btnAnswerB.Text = question.Options[1];
                    btnAnswerC.Text = question.Options[2];
                    btnAnswerD.Text = question.Options[3];

                    // Design
                    btnAnswerA.BackColor = Color.HotPink;
                    btnAnswerB.BackColor = Color.HotPink;
                    btnAnswerC.BackColor = Color.HotPink;
                    btnAnswerD.BackColor = Color.HotPink;
                    lblQuestion.ForeColor = Color.HotPink;
                    pbxSpecialQuestion.Image = Properties.Resources.burbuja_rosada;

                    // Play sound
                    if (specialQuestionIsActive == true)
                    {
                        player = new SoundPlayer(soundFilePath);
                        player.Play();
                    }
                }
                else
                {
                    // Stop playing sound
                    player = new SoundPlayer(soundFilePath);
                    player.Stop();

                    if (removeUsed == true)
                    {
                        lblQuestion.Text = question.Question;

                        btnAnswerA.Text = question.CorrectAnswer;
                        btnAnswerB.Text = question.Options[1];
                    }
                    else
                    {
                        // Make sure all buttons are enabled
                        btnAnswerC.Enabled = true;
                        btnAnswerD.Enabled = true; ;

                        ShuffleOptions(question.Options);
                        // Add the data to the form elements
                        lblQuestion.Text = question.Question;
                        btnAnswerA.Text = question.Options[0];
                        btnAnswerB.Text = question.Options[1];
                        btnAnswerC.Text = question.Options[2];
                        btnAnswerD.Text = question.Options[3];
                    }
                }
            }
            else
            {
                // Show a MessageBox saying the quiz has been completed
                MessageBox.Show("Quiz completed! Your end score: " + currentScore + " points");
                tmrTimeLeft.Stop();
                btnAnswerA.Enabled = false;
                btnAnswerB.Enabled = false;
                btnAnswerC.Enabled = false;
                btnAnswerD.Enabled = false;

                // Set score in database
                SetScore();

                // Switch to highscores
                this.Hide();
                Form4 highscoreForm = new Form4();
                highscoreForm.Show();
            }
        }

        private void SetScore()
        {
            string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=QuizMesterDatabase;Integrated Security=True";

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }

                // Find the max rankingID
                int maxNumber;
                using (SqlCommand cmd = new SqlCommand("SELECT MAX(rankingID) FROM QuizRankings", cn))
                {
                    maxNumber = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                }


                // Use the new maxNumber as the rankingID in an INSERT statement for the new ranking
                using (SqlCommand cmd = new SqlCommand("INSERT INTO QuizRankings (rankingID, userID, quizID, score, dateDone) VALUES (@rankingID, @userID, @quizID, @score, @dateDone)", cn))
                {
                    cmd.Parameters.AddWithValue("@rankingID", maxNumber);
                    cmd.Parameters.AddWithValue("@userID", loggedinUserID);
                    cmd.Parameters.AddWithValue("@quizID", "-");
                    cmd.Parameters.AddWithValue("@score", currentScore);
                    cmd.Parameters.AddWithValue("@dateDone", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void ShuffleOptions(List<string> options)
        {
            // Shuffle answers so correct answer is in a random place (A, B, C or D) each time
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
                // Show a message saying the time has ran out and the score the user ended up with
                MessageBox.Show("Time's up, game over Your end score: " + currentScore + " points");
                // Disable buttons so quiz can't be played
                btnAnswerA.Enabled = false;
                btnAnswerB.Enabled = false;
                btnAnswerC.Enabled = false;
                btnAnswerD.Enabled = false;

                // Save score in the databse
                SetScore();
                this.Hide();
                Form4 highscoreForm = new Form4();
                highscoreForm.Show();
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
                if (currentQuestionIndex == randomNumber)
                {
                    // Increment the user's current score by 15 points (special question
                    currentScore = currentScore + 15;
                    // Add the user's current score into the score label (convert int to string)
                    lblCurrentScore.Text = currentScore.ToString();
                    // Display how many points the user got underneath the score indicator
                    lblScoreIndicator.Text = "+ 15";
                    lblScoreIndicator.ForeColor = Color.HotPink;
                    // Increment the user's correct answers by 1
                    correctAnswers += 1;
                }
                else
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

        private void btnRemoveTwoQuestions_Click(object sender, EventArgs e)
        {
            removeUsed = true;

            // Disable the two incorrect answer buttons
            btnAnswerC.Enabled = false;
            btnAnswerD.Enabled = false;

            // Call the function to display the next question
            DisplayQuestion();

            removeUsed = false;
            btnRemoveTwoQuestions.Enabled = false;

        }

        private void btnSpecialQuiz_Click(object sender, EventArgs e)
        {
            // Switch to special quiz
            this.Hide();
            specialQuizForm.Show();
        }
    }
}
