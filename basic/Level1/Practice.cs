using System;
using System.Security.Principal;

namespace Practice_Day1
{
    public class Practice
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to Bridgelabz!");
        }

        public void Add()
        {
            int num1, num2;
            Console.Write("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("The sum of two numbers: " + sum);
        }

        public void CelciusToFahrenheit()
        {
            double celsius;
            Console.Write("Enter temperature in celcius: ");
            celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Converted into Fahrenheit = " + fahrenheit);
        }

        public void AreaOfCircle()
        {
            double radius;
            Console.Write("Enter radius:");
            radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of circle : " + area);
        }

        public void VolumeOfCylinder()
        {
            double radius , height ;
            Console.Write("Enter radius: ");
            radius = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = double.Parse(Console.ReadLine());
            double volume = Math.PI * radius * radius * height;
            Console.WriteLine("Volume of cylinder = " + volume);
        }

        public void SimpleInterest()
        {
            double principle, rate, time;
            Console.Write("Enter Principle = ");
            principle = double.Parse(Console.ReadLine());
            Console.Write("Enter Rate = ");
            rate = double.Parse(Console.ReadLine());
            Console.Write("Enter Time  = ");
            time = double.Parse(Console.ReadLine());
            double si = (principle * rate * time) / 100;
            Console.WriteLine("Simple Interest = " + si);

        }

        public void PerimeterOfRectangle()
        {
            Console.Write("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double perimeter = 2 * (length + width);

            Console.WriteLine("Perimeter = " + perimeter);
        }

        public void Powercalculation()
        {
            Console.Write("Enter base: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter exponent: ");
            double exponent = Convert.ToDouble(Console.ReadLine());

            double result = Math.Pow(baseNum, exponent);

            Console.WriteLine("Result = " + result);
        }

        public void AverageOfThreeNumbers()
        {
            Console.Write("Enter number 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number 3: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double average = (num1 + num2 + num3) / 3;

            Console.WriteLine("Average = " + average);
        }

        public void KilometersToMiles()
        {
            Console.Write("Enter distance in kilometers: ");
            double km = Convert.ToDouble(Console.ReadLine());

            double miles = km * 0.621371;

            Console.WriteLine("Miles = " + miles);

        }
    }
}
