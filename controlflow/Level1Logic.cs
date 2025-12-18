using System;

public class Level1Logic
{
    // 1. Divisible by 5
    public static void DivisibleByFive()
    {
        Console.Write("Enter number: ");
        double num  = Convert.ToDouble(Console.ReadLine());
        double div = Convert.ToDouble( num % 5 == 0);
        Console.WriteLine("Is the number " + num + " divisible by 5? " +div);
    }

    // 2. First number smallest
    public static void FirstIsSmallest()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Is the first number the smallest? " + (a < b && a < c));
    }

    // 3. Largest of three numbers
    public static void LargestOfThree()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Is the first number the largest? " + (a > b && a > c));
        Console.WriteLine("Is the second number the largest? " + (b > a && b > c));
        Console.WriteLine("Is the third number the largest? " + (c > a && c > b));
    }

    // 4. Natural number & sum (formula)
    public static void NaturalNumberSum()
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 1)
            Console.WriteLine("The sum of " + n + " natural numbers is " + (n * (n + 1) / 2));
        else
            Console.WriteLine("The number " + n + " is not a natural number");
    }

    // 5. Voting eligibility
    public static void CanVote()
    {
        int age = int.Parse(Console.ReadLine());

        if (age >= 18)
            Console.WriteLine("The person's age is " + age + " and can vote.");
        else
            Console.WriteLine("The person's age is " + age + " and cannot vote.");
    }

    // 6. Positive / Negative / Zero
    public static void CheckNumberType()
    {
    
        int num;
        num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
            Console.WriteLine("Positive");
        else if (num < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");
    }

    // 7. Spring Season
    public static void SpringSeason()
    {
        int month = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());

        if ((month == 3 && day >= 20) ||
            (month == 4) ||
            (month == 5) ||
            (month == 6 && day <= 20))
            Console.WriteLine("Its a Spring Season");
        else
            Console.WriteLine("Not a Spring Season");
    }

    // 8. Countdown using while loop
    public static void CountdownWhile()
    {
        int counter = int.Parse(Console.ReadLine());

        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }

    // 9. Countdown using for loop
    public static void CountdownFor()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i >= 1; i--)
            Console.WriteLine(i);
    }

    // 10. Sum until user enters 0
    public static void SumUntilZero()
    {
        double total = 0.0;

        while (true)
        {
            double num = double.Parse(Console.ReadLine());
            if (num == 0)
                break;

            total += num;
        }

        Console.WriteLine(total);
    }

    // 11. Sum until 0 or negative (break)
    public static void SumUntilNegative()
    {
        double total = 0.0;

        while (true)
        {
            double num = double.Parse(Console.ReadLine());
            if (num <= 0)
                break;

            total += num;
        }

        Console.WriteLine(total);
    }

    // 12. Sum of n natural numbers (while + formula)
    public static void SumNaturalWhileCompare()
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 1)
        {
            int sumWhile = 0;
            int i = 1;

            while (i <= n)
            {
                sumWhile += i;
                i++;
            }

            int sumFormula = n * (n + 1) / 2;

            Console.WriteLine("While Loop Sum: " + sumWhile);
            Console.WriteLine("Formula Sum: " + sumFormula);
        }
        else
        {
            Console.WriteLine("Not a natural number");
        }
    }

    // 13. Sum of n natural numbers (for + formula)
    public static void SumNaturalForCompare()
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 1)
        {
            int sumFor = 0;

            for (int i = 1; i <= n; i++)
                sumFor += i;

            int sumFormula = n * (n + 1) / 2;

            Console.WriteLine("For Loop Sum: " + sumFor);
            Console.WriteLine("Formula Sum: " + sumFormula);
        }
        else
        {
            Console.WriteLine("Not a natural number");
        }
    }

    // 14. Factorial using while loop
    public static void FactorialWhile()
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 1)
        {
            int fact = 1;
            int i = 1;

            while (i <= n)
            {
                fact *= i;
                i++;
            }

            Console.WriteLine("Factorial = " + fact);
        }
        else
        {
            Console.WriteLine("Enter a positive integer");
        }
    }

    // 15. Factorial using for loop
    public static void FactorialFor()
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 1)
        {
            int fact = 1;

            for (int i = 1; i <= n; i++)
                fact *= i;

            Console.WriteLine("Factorial = " + fact);
        }
        else
        {
            Console.WriteLine("Enter a positive integer");
        }
    }

    // 16. Odd and Even numbers
    public static void OddEven()
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 1)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i + " is Even");
                else
                    Console.WriteLine(i + " is Odd");
            }
        }
        else
        {
            Console.WriteLine("Not a natural number");
        }
    }

    // 17. Employee bonus
    public static void EmployeeBonus()
    {
        double salary = double.Parse(Console.ReadLine());
        int years = int.Parse(Console.ReadLine());

        if (years > 5)
            Console.WriteLine("Bonus: " + (salary * 0.05));
        else
            Console.WriteLine("Bonus: 0");
    }

    // 18. Multiplication table from 6 to 9
    public static void MultiplicationTableSixToNine()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 6; i <= 9; i++)
            Console.WriteLine(number + " * " + i + " = " + (number * i));
    }
}
