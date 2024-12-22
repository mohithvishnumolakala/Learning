
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



}
