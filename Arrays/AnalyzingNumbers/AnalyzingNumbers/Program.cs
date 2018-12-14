using System;

namespace AnalyzingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myList = { 2, 4, 6, 8};
            foreach (int e in myList)
            {
                Console.WriteLine(Math.Pow(e, 2));
            }
        }
    }
}
