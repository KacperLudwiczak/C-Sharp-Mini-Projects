using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Console_App
{
    internal class Quiz
    {
        // field
        private Question[] _questions;
        private int _score;

        // constructor
        public Quiz(Question[] questions) 
        {
            _questions = questions;
            _score = 0;
        }

        // methods
        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz.");
            int questionNumber = 1; // to display question numbers

            foreach (Question question in _questions) 
            {
                Console.WriteLine($"Question {questionNumber++}: ");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if(question.IsCorrectAnswer(userChoice))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!");
                    Console.ResetColor();
                    _score++;
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Wrong. ");
                    Console.ResetColor();
                    Console.WriteLine($"The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
                }
            }

            DisplayResults();
        }

        private void DisplayQuestion(Question question) 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan; // changes the text color
                Console.Write("  ");
                Console.Write(i + 1);
                Console.ResetColor(); // resets the foreground (text) color
                Console.WriteLine($". {question.Answers[i]}");
            }
        }

        private int GetUserChoice()
        {
            Console.WriteLine("Your answer (write the number of the question): ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number of the question between 1 and 4.");
                input = Console.ReadLine();
            }
            return choice -1; // adjust to 0-index array (because in DisplayQuestion method we add 1 to i)
        }

        private void DisplayResults()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Results                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();


            Console.WriteLine($"Quiz finished. Your score is: {_score} out of {_questions.Length}");

            double percentage = (double)_score / _questions.Length;
            if (percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent Work!");
            }
            else if (percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good effort!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep practicing");
            }
            Console.ResetColor();

        }
    }
}
