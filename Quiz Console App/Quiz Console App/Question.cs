using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Console_App
{
    internal class Question
    {
        // properties
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        // constructor
        public Question(string questionText, string[] answers, int correctAnswerIndex)
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        // method
        public bool IsCorrectAnswer(int choice)
        {
            return CorrectAnswerIndex == choice;
        }
    }
}
