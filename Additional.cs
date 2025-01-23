using System;

public class Additional
{
    public void LeapYear()
    {
        Console.WriteLine("Enter Year");
        int year = int.Parse(Console.ReadLine());
        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        {
            Console.WriteLine("This is Leap Year " + year);
        }
        else { Console.WriteLine("This is Not Leap Year " + year); }

    }
    public void minmaxSum()
    {
        int[] arr = [1, 3, 2, 4, 3, 5];
        Array.Sort(arr);

        int totalSum = 0;
        foreach (var num in arr)
        {
            totalSum += num;
        }

        int maxSum = totalSum - arr[0];
        int minSum = totalSum - arr[arr.Length - 1];

        Console.WriteLine($"Min Sum: {minSum}");
        Console.WriteLine($"Max Sum: {maxSum}");
    }
    public void missingNumber()
    {
        int[] arr = { 1, 2, 4, 5, 6 };
        int n = 6; // The size of the sequence should be from 1 to 6
        int totalSum = n * (n + 1) / 2;  //expected sum
        int actualSum = 0;

        foreach (int num in arr)
        {
            actualSum += num;
        }
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    actualsum += arr[i];
        //}   this is as also the same meaning
        int missingNumber = totalSum - actualSum;
        Console.WriteLine("Missing number is: " + missingNumber);
    }
    public void GCD()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        while (a != b)
        {
            if (a < b)
            {
                b -= a;

            }
            else
            {
                a = a - b;
            }
        }
        Console.WriteLine("GCD: " + a);
    }
    public void amStrong()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        int temp = num;

        int digits = num.ToString().Length;

        while (temp > 0)
        {
            int rem = temp % 10; 
            sum += (int)Math.Pow(rem, digits);
            temp /= 10; 
        }

        if (sum == num)
            Console.WriteLine(num + " is an Armstrong number.");
        else
            Console.WriteLine(num + " is not an Armstrong number.");
    }
    public void sortFilter()
    {
        Console.WriteLine("Enter the number of names:");
        int count = int.Parse(Console.ReadLine());
        
        List<string> names = new List<string>();

        Console.WriteLine("Enter the names:");
        for (int i = 1; i <= count; i++)
        {
            Console.Write($"Name {i}: ");
            names.Add(Console.ReadLine());
        }

        names.Sort();

        Console.WriteLine("\nSorted names in ascending order:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("\nEnter a keyword to filter names:");
        string keyword = Console.ReadLine();

        var filteredNames = names.Where(n => n.Contains(keyword, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine($"\nFiltered names containing '{keyword}':");
        foreach (var name in filteredNames)
        {
            Console.WriteLine(name);
        }

    }
}
