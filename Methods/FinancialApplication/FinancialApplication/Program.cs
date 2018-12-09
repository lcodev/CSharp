using System;

namespace FinancialApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for values
            Console.Write("Enter investment amount: ");
            double amount = double.Parse(Console.ReadLine());

            Console.Write("Enter interest rate: ");
            double rate = double.Parse(Console.ReadLine());

            // display future value for years 1 through 30
            Console.WriteLine("Years\tFutureValue");
            for (int i = 1; i <= 30; i++)
            {
                // display results
                double results = futureInvestmentValue(amount, rate, i);
                Console.WriteLine(i + "\t" + "{0:N2}", results);
            }
        }

        public static double futureInvestmentValue(double investmentAmount, double monthlyInterestRate, int years)
        {
            // get monthly interest rate
            double mInterestRate = (monthlyInterestRate / 100) / 12;
            int nYears = years * 12;
            double result = investmentAmount * Math.Pow(1 + mInterestRate, nYears);
            return result;
        }

    }
}
