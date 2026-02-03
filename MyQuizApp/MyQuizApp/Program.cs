namespace MyQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question("What is the capital of Germany?", // Question text
                new string[] {"Paris", "Berlin", "London", "Madrid"}, // Answers array
                1 // Correct amswer
                ),
                new Question("What is 2+2?", // Question text
                new string[] {"3", "4", "5", "6"}, // Answers array
                1 // Correct amswer
                ),
                new Question("Who wrote Hamlet?", // Question text
                new string[] {"Goethe", "Austen", "Shakespeare", "Dickens"}, // Answers array
                2 // Correct amswer
                ),
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
            
            Console.ReadLine();
        }
    }
}
