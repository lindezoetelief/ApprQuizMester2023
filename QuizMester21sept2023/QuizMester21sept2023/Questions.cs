using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuizMester21sept2023
{
    internal class Questions
    {


        //public string Text { get; }
        //public List<string> Options { get; }
        //public string CorrectAnswer { get; }

        //public Questions(string text, List<string> options, string correctAnswer)
        //{
        //    Text = text;
        //    Options = options;
        //    CorrectAnswer = correctAnswer;
        //}


        public string Question { get; }

        public List<string> Options { get; }

        public string CorrectAnswer { get; }

        public Questions(string c_question, List<string> c_options, string c_correctAnswer)
        {
            Question = c_question;
            Options = c_options;
            CorrectAnswer = c_correctAnswer;
        }
    }
}
