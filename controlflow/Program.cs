using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("====== LEVEL 1 PRACTICE PROGRAMS ======");
        Console.WriteLine("1  - Check divisible by 5");
        Console.WriteLine("2  - Check if first number is smallest");
        Console.WriteLine("3  - Check largest of three numbers");
        Console.WriteLine("4  - Natural number & sum (formula)");
        Console.WriteLine("5  - Voting eligibility");
        Console.WriteLine("6  - Positive / Negative / Zero");
        Console.WriteLine("7  - Spring Season");
        Console.WriteLine("8  - Countdown using while loop");
        Console.WriteLine("9  - Countdown using for loop");
        Console.WriteLine("10 - Sum until user enters 0");
        Console.WriteLine("11 - Sum until 0 or negative");
        Console.WriteLine("12 - Sum of natural numbers (while + formula)");
        Console.WriteLine("13 - Sum of natural numbers (for + formula)");
        Console.WriteLine("14 - Factorial using while loop");
        Console.WriteLine("15 - Factorial using for loop");
        Console.WriteLine("16 - Odd & Even numbers");
        Console.WriteLine("17 - Employee bonus");
        Console.WriteLine("18 - Multiplication table (6 to 9)");
        Console.WriteLine("--------------------------------------");

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Level1Logic.DivisibleByFive();
                break;

            case 2:
                Level1Logic.FirstIsSmallest();
                break;

            case 3:
                Level1Logic.LargestOfThree();
                break;

            case 4:
                Level1Logic.NaturalNumberSum();
                break;

            case 5:
                Level1Logic.CanVote();
                break;

            case 6:
                Level1Logic.CheckNumberType();
                break;

            case 7:
                Level1Logic.SpringSeason();
                break;

            case 8:
                Level1Logic.CountdownWhile();
                break;

            case 9:
                Level1Logic.CountdownFor();
                break;

            case 10:
                Level1Logic.SumUntilZero();
                break;

            case 11:
                Level1Logic.SumUntilNegative();
                break;

            case 12:
                Level1Logic.SumNaturalWhileCompare();
                break;

            case 13:
                Level1Logic.SumNaturalForCompare();
                break;

            case 14:
                Level1Logic.FactorialWhile();
                break;

            case 15:
                Level1Logic.FactorialFor();
                break;

            case 16:
                Level1Logic.OddEven();
                break;

            case 17:
                Level1Logic.EmployeeBonus();
                break;

            case 18:
                Level1Logic.MultiplicationTableSixToNine();
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
