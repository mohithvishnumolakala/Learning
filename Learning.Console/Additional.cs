using System;
using System.Xml.Linq;

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
        Console.WriteLine("enter number of names:");
        int num = int.Parse(Console.ReadLine());
        List<string> names=new List<string>();
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine("enter name");
            names.Add( Console.ReadLine());  
        }
        names.Sort();
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("enter key:");
        string key = Console.ReadLine();
        for (int i = 1; i < names.Count; i++)
        {
            if (names[i].Contains(key))
            {
                Console.WriteLine($"the key found {key}");
            }
            
        }

    }
    public void WithoutClass()
    {
        Console.WriteLine("Details of Mohith:");
        string firstName = "mohith";
        string lastName = "vishnumolakala";
        int age = 19;
        int salary = 15000;
        Console.WriteLine($"firstname:{firstName}");
        Console.WriteLine($"lastname:{lastName}");
        Console.WriteLine($"age:{age}");
        Console.WriteLine($"salary:{salary}");

        Console.WriteLine();

        Console.WriteLine("Details of geetha:");
        string firstName1 = "geetha";
        string lastName1 = "gopalam";
        int age1 = 18;
        int salary1 = 20000;
        Console.WriteLine($"firstname:{firstName1}");
        Console.WriteLine($"lastname:{lastName1}");
        Console.WriteLine($"age:{age1}");
        Console.WriteLine($"salary:{salary1}");
    }
}
