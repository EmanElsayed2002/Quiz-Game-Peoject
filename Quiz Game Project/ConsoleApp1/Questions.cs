using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Game_System
{
    internal class Questions
    {
        public string QuestionText { get; set; }
        public List<string> Options { get; set; }
        public int CorrectAnswer { get; set; }

        public Questions(string text , List<string>options  , int ans)
        {
            QuestionText = text;
            Options = options;
            CorrectAnswer = ans;
        }
        public bool CheckAnswer(int ans)
        {
            return CorrectAnswer == ans;
        }
    }
}
