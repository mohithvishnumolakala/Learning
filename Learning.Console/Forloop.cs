﻿
public class Forloop
{
    public void ForLoopMethod()
    {
        Console.WriteLine("forloop");
    }
    public void Print1to10()
    {
        Console.WriteLine("1-10");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    public void Print10to1()
    {
        Console.WriteLine("10-1");
        for (int i = 10; i > 0; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    public void PrintEven()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            { Console.Write(i + " "); }

        }
    }
    public void PrintOdd()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 != 0)
            { Console.Write(i + " "); }

        }
    }
    public void Table()
    {
        int j = 5;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{j} * {i} = {i * j}");
        }
    }
    public void Factorial()
    {
        Console.WriteLine("enter number");
        string input = Console.ReadLine();
        int num = int.Parse(input);
        int result = 1;
        for (int i = 1; i <= num; i++)
        {
            result = result * i;

        }
        Console.WriteLine($"factorial of {num} is {result}");
    }
    public void SumFactorial()
    {
        Console.WriteLine("enter number");
        string input = Console.ReadLine();
        int num = int.Parse(input);
        int result = 0;
        for (int i = 1; i <= num; i++)
        {
            result += i;

        }
        Console.WriteLine($"factorial of {num} is {result}");
    }
    public void Fibbinoci()
    {
        Console.WriteLine("enter the terms");
        int terms = int.Parse(Console.ReadLine());
        int first = 0;
        int second = 1;
        Console.Write(first + " " + second + " ");
        for (int i = 3; i <= terms; i++)
        {
            int third = first + second;
            first = second;
            second = third;
            Console.Write(third + " ");
        }

    }
    public void PrimeNumber()
    {

        bool isPrime = true;
        for (int start = 2; start < 10; start++)
        {
            isPrime = true;
            for (int i = 2; i <= start - 1; i++)
            {
                if (start % i == 0)
                {
                    isPrime = false;
                    break;
                }

            }
            if (isPrime)
            {
                Console.WriteLine("prime" + start);
            }
            else
            {
                Console.WriteLine("Not" + start);
            }
        }
    }
}
