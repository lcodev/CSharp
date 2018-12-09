using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int num = Int16.Parse(Console.ReadLine());
            Console.WriteLine("{0} is palindrome? {1}", num, isPalindrome(num));
            
        }

        /// <summary>
        /// Return the reversal of an integer, i.e., reverse(456) returns 654
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int reverse(int number)
        {
            string prev = "";
            while (number != 0)
            {
                int mod = number % 10;
                prev += mod.ToString();

                int div = number / 10;
                number = div;
            }

            return Int16.Parse(prev);
        }

        /// <summary>
        /// Method compares two numbers and returns true if they're the same
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool isPalindrome(int number)
        {
            bool result;

            // get the reverse number by calling reverse method
            int rev = reverse(number);

            // check if it is the same number
            if (rev == number)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
