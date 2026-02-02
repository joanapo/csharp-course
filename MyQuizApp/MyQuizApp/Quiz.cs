using System;
using System.Collections.Generic;
using System.Text;

namespace MyQuizApp
{
    internal class Quiz
    {
        private Question[] questions;

        public Quiz(Question[] questions)
        {
            this.questions = questions;
        }

        private void DisplayQuestion(Question question)
        {
            Console.WriteLine(question.QuestionText);
        }
    }
}
