using System;

namespace Practice_Level2
{
    public class Operations
    {
        public void QuotientRemainder()
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quotient: " + (a / b));
            Console.WriteLine("Remainder: " + (a % b));
        }

        public void IntOperations()
        {
            Console.Write("Enter value of a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a + b * c = " + (a + b * c));
            Console.WriteLine("a * b + c = " + (a * b + c));
            Console.WriteLine("c + a / b = " + (c + a / b));
            Console.WriteLine("a % b + c = " + (a % b + c));
        }

        public void DoubleOperations()
        {
            Console.Write("Enter value of a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value of b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value of c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a + b * c = " + (a + b * c));
            Console.WriteLine("a * b + c = " + (a * b + c));
            Console.WriteLine("c + a / b = " + (c + a / b));
            Console.WriteLine("a % b + c = " + (a % b + c));
        }

        public void CelsiusToFahrenheit()
        {
            Console.Write("Enter temperature in Celsius: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit: " + f);
        }

        public void FahrenheitToCelsius()
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32) * 5 / 9;
            Console.WriteLine("Celsius: " + c);
        }

        public void TotalIncome()
        {
            Console.Write("Enter salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter bonus: ");
            double bonus = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Total Income: " + (salary + bonus));
        }

        public void SwapNumbers()
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping: " + a + " " + b);
        }

        public void TripDistance()
        {
            Console.Write("Enter distance from source to via (km): ");
            double d1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter distance from via to destination (km): ");
            double d2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter time taken (hours): ");
            double time = Convert.ToDouble(Console.ReadLine());
            double totalDistance = d1 + d2;
            Console.WriteLine("Total Distance: " + totalDistance);
            Console.WriteLine("Speed: " + (totalDistance / time));
        }

        public void AthleteRounds()
        {
            Console.Write("Enter side 1 of triangle (meters): ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side 2 of triangle (meters): ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side 3 of triangle (meters): ");
            double c = Convert.ToDouble(Console.ReadLine());
            double perimeter = a + b + c;
            double rounds = 5000 / perimeter;
            Console.WriteLine("Total rounds to complete 5 km: " + rounds);
        }

        public void ChocolateDistribution()
        {
            Console.Write("Enter total chocolates: ");
            int chocolates = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of children: ");
            int children = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Each child gets: " + (chocolates / children));
            Console.WriteLine("Remaining chocolates: " + (chocolates % children));
        }

        public void SimpleInterest()
        {
            Console.Write("Enter principal: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter rate of interest: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter time (years): ");
            double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Simple Interest: " + (p * r * t) / 100);
        }

        public void WeightConversion()
        {
            Console.Write("Enter weight in pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Weight in kg: " + (pounds / 2.2));
        }
    }
}
