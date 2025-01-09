using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Console
{
    using System;

    public class Patterns
    {
        public static void SquarePattern()
        {
            Console.WriteLine("enter sqare dimensions");
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= input; j++)
                {
                    System.Console.Write("*");
                }
                Console.WriteLine();

            }

        }
        public static void RectanglePattern()
        {
            Console.WriteLine("enter the length");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the breadth");
            int breadth = int.Parse(Console.ReadLine());
            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= breadth; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

        }
        public static void LeftTriangle()
        {
            Console.WriteLine("enter the no.of rows");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void num1()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                { Console.Write(j); }
                Console.WriteLine();

            }
        }
        public static void num2()
        {
            int k = 1;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {

                    Console.Write(k);
                    k++;
                }
                Console.WriteLine();

            }

        }
        public static void num3()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

            }

        }
        public static void num4()
        {
            int k = 9;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write(k);
                    k--;
                }
                Console.WriteLine();
            }

        }
        public static void num5()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 3; j >= 1; j--)
                {
                    Console.Write(j);

                }
                Console.WriteLine();
            }

        }
        public static void num6()
        {
            for (int i = 3; i > 0; i--)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write(i);

                }
                Console.WriteLine();
            }

        }
        public static void num7()
        {

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 3; j > 0; j--)
                {
                    Console.Write(j);

                }
                Console.WriteLine();
            }

        }
        public static void RightTriangle()
        {

            Console.WriteLine("enter the no.of rows");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }
        public static void EqualTriangle()
        {
            {
                Console.WriteLine("enter the no.of rows");
                int rows = int.Parse(Console.ReadLine());
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= rows - i; j++)
                    {
                        Console.Write("_");
                    }
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 1; j <= rows - i; j++)
                    {
                        Console.Write("_");
                    }
                    Console.WriteLine();
                }
            }
        }
        public static void LeapYear()
        {
            Console.WriteLine("Enter Year");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("This is Leap Year " + year);
            }
            else { Console.WriteLine("This is Not Leap Year " + year); }

        }
        public static void minmaxSum()
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
        public static void missingNumber()
        {
            int[] arr = { 1, 2, 4, 5, 6 };
            int n = 6; // The size of the sequence should be from 1 to 6
            int totalSum = n * (n + 1) / 2;  //expected sum
            int actualSum = 0;

            foreach (int num in arr)
            {
                actualSum += num;
            }

            int missingNumber = totalSum - actualSum;
            Console.WriteLine("Missing number is: " + missingNumber);
        }

        public static void GCD()
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
        public static void amStrong()
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
        public static void GCD1() 
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

           int [] arr= new int[num1];
           int [] array= new int[num2];



    }


}


