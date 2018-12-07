using System;

namespace CountPosNegAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program variables
            int positives = 0;
            int negatives = 0;
            double totalCount = 0;
            double total = 0;
            int index = 1;

            while (index != 0)
            {
                // Prompt user for integers
                Console.Write("Enter an integer, the input ends if it is 0: ");
                int num = Int16.Parse(Console.ReadLine());

                // Check for positives
                if (num > 0)
                {
                    positives++;
                    totalCount++;
                    total += num;
                }

                // check for negatives
                else if (num < 0)
                {
                    negatives++;
                    totalCount++;
                    total += num;
                }

                // set index to num
                index = num;

            } // end while loop

            // calculate average
            double avg = total / totalCount;

            // Display results
            Console.WriteLine("Number of positives: {0}", positives);
            Console.WriteLine("Number of negatives: {0}", negatives);
            Console.WriteLine("The total is: {0}", total);
            Console.WriteLine("The average is: {0}", avg);
        }
    }
}
