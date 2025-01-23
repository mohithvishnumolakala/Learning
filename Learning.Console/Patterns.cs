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
            for (int i = 1; i <= breadth; i++)
            {
                for (int j = 1; j <= length; j++)
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
                        Console.Write(" ");
                    }
                    for (int k = 1; k <=i; k++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 1; j <=i-1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
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
       
    }


}


