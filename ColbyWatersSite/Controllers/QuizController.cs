using Microsoft.AspNetCore.Mvc;
using ColbyWatersSite.Models;

namespace Fan_Site.Controllers
{
    public class QuizController : Controller
    {

        [HttpGet]
        public IActionResult Quiz()
        {
            ViewBag.Qid = 1;
            ViewBag.Score = 0;

            //Generate a new question and send its attributes back to the view to be displayed.
            QuizModel q = new QuizModel(ViewBag.Qid);
            ViewBag.Question = q.Question;
            ViewBag.AnswerA = q.AnswerA;
            ViewBag.AnswerB = q.AnswerB;
            ViewBag.AnswerC = q.AnswerC;
            ViewBag.AnswerD = q.AnswerD;

            return View();
        }

        [HttpPost]
        public IActionResult Quiz(QuizModel inModel)
        {
            //Increment the Qid in order to generate the next question.
            ViewBag.Qid = inModel.Qid + 1;
            ViewBag.Score = inModel.Score;

            //Generate the previous question to compare answers.
            QuizModel previous = new QuizModel(inModel.Qid);

            //Increment the user's score if they answered correctly.
            if (inModel.IsCorrect(previous) == true)
                ViewBag.Score++;

            //Generate the next question and send its attributes back to the view to be displayed.
            QuizModel q = new QuizModel(ViewBag.Qid);
            ViewBag.Question = q.Question;
            ViewBag.AnswerA = q.AnswerA;
            ViewBag.AnswerB = q.AnswerB;
            ViewBag.AnswerC = q.AnswerC;
            ViewBag.AnswerD = q.AnswerD;

            ModelState.Clear();

            /*If all 5 questions have been answered, redirect to the results page and display all the
            questions and answers.*/
            if (ViewBag.Qid > 5)
            {
                QuizModel q1 = new QuizModel(1);
                q1.Qid = 1;
                QuizModel q2 = new QuizModel(2);
                q2.Qid = 2;
                QuizModel q3 = new QuizModel(3);
                q3.Qid = 3;
                QuizModel q4 = new QuizModel(4);
                q4.Qid = 4;
                QuizModel q5 = new QuizModel(5);
                q5.Qid = 5;
                ViewBag.Q1Qid = q1.Qid;
                ViewBag.Q1Q = q1.Question;
                ViewBag.Q1A = q1.AnswerA;
                ViewBag.Q1B = q1.AnswerB;
                ViewBag.Q1C = q1.AnswerC;
                ViewBag.Q1D = q1.AnswerD;
                ViewBag.Q1Correct = q1.CorrectAnswer;
                ViewBag.Q2Qid = q2.Qid;
                ViewBag.Q2Q = q2.Question;
                ViewBag.Q2A = q2.AnswerA;
                ViewBag.Q2B = q2.AnswerB;
                ViewBag.Q2C = q2.AnswerC;
                ViewBag.Q2D = q2.AnswerD;
                ViewBag.Q2Correct = q2.CorrectAnswer;
                ViewBag.Q3Qid = q3.Qid;
                ViewBag.Q3Q = q3.Question;
                ViewBag.Q3A = q3.AnswerA;
                ViewBag.Q3B = q3.AnswerB;
                ViewBag.Q3C = q3.AnswerC;
                ViewBag.Q3D = q3.AnswerD;
                ViewBag.Q3Correct = q3.CorrectAnswer;
                ViewBag.Q4Qid = q4.Qid;
                ViewBag.Q4Q = q4.Question;
                ViewBag.Q4A = q4.AnswerA;
                ViewBag.Q4B = q4.AnswerB;
                ViewBag.Q4C = q4.AnswerC;
                ViewBag.Q4D = q4.AnswerD;
                ViewBag.Q4Correct = q4.CorrectAnswer;
                ViewBag.Q5Qid = q5.Qid;
                ViewBag.Q5Q = q5.Question;
                ViewBag.Q5A = q5.AnswerA;
                ViewBag.Q5B = q5.AnswerB;
                ViewBag.Q5C = q5.AnswerC;
                ViewBag.Q5D = q5.AnswerD;
                ViewBag.Q5Correct = q5.CorrectAnswer;
                return View("QuizResults");
            }

            return View();
        }

    }
}
