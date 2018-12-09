using System;

namespace SortThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter three numbers: ");
            int num1 = Int16.Parse(Console.ReadLine());
            int num2 = Int16.Parse(Console.ReadLine());
            int num3 = Int16.Parse(Console.ReadLine());

            displaySortedNumbers(num1, num2, num3);
        }

        /// <summary>
        /// Method sorts three numbers in ascending order
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        public static void displaySortedNumbers(int num1, int num2, int num3)
        {
            // check if num1 is greater than num2
            // if it is reverse the order
            if (num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            // check if num2 is greater than num3
            // if it is reverse the order
            if (num2 > num3)
            {
                int temp = num2;
                num2 = num3;
                num3 = temp;
            }

            // check if num1 is greater than num2
            // if it is reverse the order
            if (num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            string result = num1.ToString() + num2.ToString() + num3.ToString();
            Console.WriteLine("Numbers sorted: {0}", result);
        }
    }
}
