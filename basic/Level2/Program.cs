using System;

namespace Practice_Level2
{
    class Program
    {
        static void Main()
        {
            int choice;

            Console.WriteLine("=== Practice Day 3 ===");
            Console.WriteLine("1. Quotient & Remainder");
            Console.WriteLine("2. Int Operations");
            Console.WriteLine("3. Double Operations");
            Console.WriteLine("4. Celsius to Fahrenheit");
            Console.WriteLine("5. Fahrenheit to Celsius");
            Console.WriteLine("6. Total Income");
            Console.WriteLine("7. Swap Numbers");
            Console.WriteLine("8. Trip Distance");
            Console.WriteLine("9. Athlete Rounds");
            Console.WriteLine("10. Chocolate Distribution");
            Console.WriteLine("11. Simple Interest");
            Console.WriteLine("12. Weight Conversion");
            Console.WriteLine("0. Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            Operations ops = new Operations();

            switch (choice)
            {
                case 1: ops.QuotientRemainder(); break;
                case 2: ops.IntOperations(); break;
                case 3: ops.DoubleOperations(); break;
                case 4: ops.CelsiusToFahrenheit(); break;
                case 5: ops.FahrenheitToCelsius(); break;
                case 6: ops.TotalIncome(); break;
                case 7: ops.SwapNumbers(); break;
                case 8: ops.TripDistance(); break;
                case 9: ops.AthleteRounds(); break;
                case 10: ops.ChocolateDistribution(); break;
                case 11: ops.SimpleInterest(); break;
                case 12: ops.WeightConversion(); break;
                case 0: return;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }
    }
}
