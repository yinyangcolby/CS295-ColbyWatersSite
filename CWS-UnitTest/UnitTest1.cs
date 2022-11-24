using System;
using Xunit;
using ColbyWatersSite;
using ColbyWatersSite.Models;

namespace ColbyWatersSiteTests
{
    public class QuizTests
    {
        [Fact]
        public void TestCorrectAnswer()
        {
            QuizModel q1 = new QuizModel(1);
            QuizModel q2 = new QuizModel();
            q2.UserAnswer = "B";
            Assert.True(q2.IsCorrect(q1));
        }

        [Fact]
        public void TestIncorrectAnswer()
        {
            QuizModel q1 = new QuizModel(1);
            QuizModel q2 = new QuizModel();
            q2.UserAnswer = "A";
            Assert.False(q2.IsCorrect(q1));
        }
    }
}
