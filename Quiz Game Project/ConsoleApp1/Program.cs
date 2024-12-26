using Quiz_Game_System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Our Quiz Game!!");
            Quiz quiz = new Quiz();

            quiz.AddQuestion(new Questions (
                "What is the capital of France?",
                new List<string> { "Berlin", "Madrid", "Paris", "Rome" },
                3
            ));

            quiz.AddQuestion(new Questions (
                "What is 5 + 3?",
                new List<string> { "5", "8", "10", "12" },
                2
            ));

            quiz.AddQuestion(new Questions(
                "Which programming language is this quiz written in?",
                new List<string> { "Python", "Java", "C#", "Ruby" },
                3
            ));

            quiz.AskQuestions();
        }
    }
}
