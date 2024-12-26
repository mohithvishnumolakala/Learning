using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Console.Strings
{
    internal class Strings
    {
        public void Example()
        {
            System.Console.WriteLine("enter the string");
            string name = System.Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                System.Console.WriteLine(name[i].ToString().ToUpper());
            }
        }
        public void OccuranceOfLetter()
        {
            System.Console.WriteLine("enter string");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("enter character");
            string letter = System.Console.ReadLine();
            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].ToString() == letter)
                {
                    count++;

                }
            }
            System.Console.WriteLine(count);
        }
        public void VowelsCount()
        {
            System.Console.WriteLine("enter string");
            string name = System.Console.ReadLine();
            int count = 0;

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].ToString().ToLower() == "a" ||
                    name[i].ToString().ToLower() == "e" ||
                   name[i].ToString().ToLower() == "i" ||
                    name[i].ToString().ToLower() == "o" ||
                   name[i].ToString().ToLower() == "u")
                {
                    count++;

                }
            }
            System.Console.WriteLine(count);
        }

    }
}
