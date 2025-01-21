using System;

public class Whileloop
{
    public void WhileLoopMethod()
    {
        Console.WriteLine("Whileloop");
    }
    public void Print1to10()
    { 
        Console.WriteLine("1-10");
        int i = 1;
        while (i <= 10)
        {
            Console.Write(i + " ");
            i++;
        }
        Console.WriteLine();
    }
    public void Print10to1()
    {
        Console.WriteLine("10-1");
        int i = 10;
        while (i > 0)
        {
            Console.Write(i + " ");
            i--;
        }
        Console.WriteLine();
    }
    public void PrintEven()
    {
        int i = 1;
        while (i <= 10)
        {
            if (i % 2 == 0)
            {

                Console.Write(i + " ");

            }
            i++;
        }

    }
    public void PrintOdd()
    {
        int i = 1;
        while (i <= 10)
        {
            if (i % 2 != 0)
            {

                Console.Write(i + " ");

            }
            i++;
        }

    }
    public void Table()
    {
        int i = 1;
        int j = 5;
        while (i <= 10)
        {
            Console.WriteLine($"{j} * {i} = {j * i}");
            i++;
        }

    }
    public void Factorial()
    {
        Console.WriteLine("enter number");
        string input = Console.ReadLine();
        int num = int.Parse(input);
        int i = 1;
        int result = 1;
        while (i <= num)
        {
            result = result * i;
            i++;
        }
        Console.WriteLine($"{result}-result");
    }
    public void CountOfDigits()
    {
        Console.WriteLine("enter no of testcases");
        string x = Console.ReadLine();
        int testcases = int.Parse(x);
        for (int k = 0; k < testcases; k++)
        {
            int count = 0;
            Console.WriteLine("enter number");
            int input = int.Parse(Console.ReadLine());
            int num = input;
            while (input != 0)
            {
                count = count + 1;
                input = input / 10;
            }
            Console.WriteLine("the number of digits in " + num + "is" + count);

        }

    }
    public void SumofDigits()
    {
        int num = 1452;
        int k = num;
        int sum = 0;
        while (num != 0)
        {
            int rem = num % 10;
            num = num / 10;
            sum = sum + rem;
        }
        Console.WriteLine($"sum of {k} is{sum}");
    }
    public void ReverseNum()
    {
        int num = 1221;
        int k = num;
        int NewNum = 0;
        while (num != 0)
        {
            int rem = num % 10;
            num = num / 10;
            NewNum = NewNum * 10 + rem;
        }
        Console.WriteLine("new" + NewNum);
        if (k == NewNum)
        { Console.WriteLine("Palandrome"); }
        else { Console.WriteLine("not a palandrome"); }
    }

}
