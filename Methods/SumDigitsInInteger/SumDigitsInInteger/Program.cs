using System;

namespace SumDigitsInInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for an integer
            Console.Write("Enter an integer: ");
            long n = long.Parse(Console.ReadLine());

            // display sum
            int result = sumDigits(n);
            Console.WriteLine(result);
        }

        /// <summary>
        /// Method computes the sum of the digits in an integer
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int sumDigits(long n)
        {
            // method variables
            int sum = 0;

            // remove the last digit
            while (n != 0)
            {
                int mod = (int)n % 10;
                sum += mod;

                int div = (int)n / 10;
                n = div;
            }

            return sum;
        }
    }
}
