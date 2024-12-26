using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Console.Arrays
{
    using System;
    internal class ArraysIntro
    {
        public void Example()
        {
            Console.WriteLine("enter length");
            int Length = int.Parse(Console.ReadLine());
            int[] array = new int[Length];
            Console.WriteLine("enter elements");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void Example1()
        {
            string s = Console.ReadLine();
            string[] array = s.Split();
            int[] arr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = int.Parse(array[i]);
            }
            for (int i = 0; i < arr.Length; i++) { Console.WriteLine(arr[i]); }
        }
        public void MaxElement()
        {
            int[] array = [1, 12, 3, 5, 2, 1];
            int largest = array[0];
            int largestIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > largest)
                {
                    largest = array[i];
                    largestIndex = i;
                }

            }
            Console.WriteLine(largestIndex);

        }
        public void SumOfElements()
        {
            int[] array = [1, 4, 1, 7, 9];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);

        }
        public void CountOccur()
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            int[] array = [1, 2, 3, 1, 5, 6];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] == num)
                {
                    count++;
                }
            Console.WriteLine(count);
        }
        public void Search()
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            int[] array = [1, 2, 3, 1, 5, 6];
            bool isFound = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    isFound = true;
                }
            }
            if (isFound)
                Console.WriteLine($" {num} is found");
            else
            {
                Console.WriteLine($" {num} is not found");
            }
        }



    }
}
