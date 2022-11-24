using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColbyWatersSite.Models
{
    public class QuizModel
    {
        public int Qid { get; set; }
        public string Question { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string CorrectAnswer { get; set; }
        public string UserAnswer { get; set; }
        public int Score { get; set; }

        public QuizModel() { }

        //Overloaded constructor determines question attributes depending on Qid.
        public QuizModel(int qid)
        {
            //Real questions will be added later.
            if (qid == 1)
            {
                Question = "What is 2 + 2?";
                AnswerA = "2";
                AnswerB = "4";
                AnswerC = "8";
                AnswerD = "16";
                CorrectAnswer = "B";
            }
            if (qid == 2)
            {
                Question = "What color is the sky?";
                AnswerA = "Red";
                AnswerB = "Yellow";
                AnswerC = "Green";
                AnswerD = "Blue";
                CorrectAnswer = "D";
            }
            if (qid == 3)
            {
                Question = "What sound does a dog make?";
                AnswerA = "Woof";
                AnswerB = "Meow";
                AnswerC = "Ribbit";
                AnswerD = "Moo";
                CorrectAnswer = "A";
            }
            if (qid == 4)
            {
                Question = "How many days are there is a year?";
                AnswerA = "350";
                AnswerB = "360";
                AnswerC = "365";
                AnswerD = "377";
                CorrectAnswer = "C";
            }
            if (qid == 5)
            {
                Question = "What is 2 + 2 - 2 + 2?";
                AnswerA = "2";
                AnswerB = "4";
                AnswerC = "8";
                AnswerD = "16";
                CorrectAnswer = "B";
            }
        }

        //Compares the user's answer to the previous question with the correct answer.
        public bool IsCorrect(QuizModel previous)
        {
            if (this.UserAnswer == previous.CorrectAnswer)
                return true;
            else
                return false;
        }
    }
}
