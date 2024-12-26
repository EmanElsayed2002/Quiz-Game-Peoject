using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Game_System
{
    internal class Quiz
    {
        public List<Questions> Questions { get; set; }
        public int Score { get; set; }
        public Quiz()
        {
            Questions = new List<Questions>();
            Score = 0;
        }

        

        public void AddQuestion(Questions question)
        {
            Questions.Add(question);
        }

        public void AskQuestions()
        {

            for(int i =0;i < Questions.Count; i++)
            {
                Console.WriteLine($"Question{i + 1}: {Questions[i].QuestionText}");
                
                for(int j = 0; j < Questions[i].Options.Count; j++)
                {
                     Console.WriteLine($"{j+1}: {Questions[i].Options[j]}");
                }
                Console.Write("Your Answer: ");
                if (int.TryParse(Console.ReadLine(), out var result) && result > 0 && result < Questions.Count)
                {
                    if (Questions[i].CheckAnswer(result))
                    {
                        Console.WriteLine("Correct!");
                        Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong!");

                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.\n");
                }
            }
        }

        public void ShowScore()
        {
            Console.WriteLine($"Quiz Over! Your final score is: {Score}/{Questions.Count}");
        }
    }
}
