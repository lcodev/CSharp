using System;

namespace PentagonalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call method to get pentagonal number
            // return the first 100 pentagonal numbers
            // with 10 numbers per line
            for (int i = 1; i < 101; i++)
            {
                int pent = getPentagonalNumber(i);
                Console.Write(pent + "\t");
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

        }

        public static int getPentagonalNumber(int n)
        {
            // formula n(3n - 1) / 2
            int result = n * (3 * n - 1) / 2;
            return result;
        }
    }
}
