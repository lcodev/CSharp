using System;

namespace AdditionQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program variables
            int numQuestions = 5;
            Random rnd = new Random();
            int correctAnswers = 0;

            // Generate 5 random addition questions
            for (int i = 0; i < numQuestions; i++)
            {
                int num1 = rnd.Next(1, 16);
                int num2 = rnd.Next(1, 16);

                Console.Write("{0} + {1} = ", num1, num2);
                int answer = Int16.Parse(Console.ReadLine());

                // check if answer is correct
                if (answer == num1 + num2)
                {
                    Console.WriteLine("Correct!");
                    correctAnswers++;
                }

                else
                {
                    Console.WriteLine("Answer is wrong. {0} + {1} is equal to {2}", num1, num2, num1 + num2);
                }
            } // end for loop

            // display results
            Console.WriteLine("\ncorrect answers: {0}", correctAnswers);
        }
    }
}
