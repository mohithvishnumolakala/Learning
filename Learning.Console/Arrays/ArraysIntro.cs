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
        public static void PrintArray()
        {
            Console.WriteLine("enter the length");
            int Length = int.Parse(Console.ReadLine());
            int[] arr = new int[Length];
            Console.WriteLine("enter the elements");
            for (int i = 0; i < Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine(arr[i]);
            }



        }
        public static void PrintString()
        {
            Console.WriteLine("enter the string");
            string element = Console.ReadLine();
            string[] arr = element.Split();
            int[] array = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = int.Parse(arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }


    }
}
