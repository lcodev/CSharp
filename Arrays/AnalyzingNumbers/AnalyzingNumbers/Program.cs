using System;

namespace AnalyzingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of items: ");
            int n = Int16.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            double sum = 0;

            Console.Write("Enter the numbers: ");
            var data = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Double.Parse(data[i]);
                sum += numbers[i];
            }

            double average = sum / n;

            int count = 0; // The number of elements above average
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > average)
                {
                    count++;
                }
            }

            Console.WriteLine("Average is " + average);
            Console.WriteLine("Number of elements above the average is " + count);
        }
    }
}
