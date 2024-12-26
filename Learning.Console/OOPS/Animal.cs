using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Console.OOPS
{
    internal class Animal
    {
        int legs = 4;
        
        public virtual void sound()
        {
            System.Console.WriteLine("animal makes sound");
        }

    }

    internal class Cat : Animal
    {
        public override  void sound()
        {
            System.Console.WriteLine("cat meows makes sound");
        }

        public void  sample()
        {
            System.Console.WriteLine();
        }

    }

    internal class Dog : Animal
    {
        public override void sound()
        {
            System.Console.WriteLine("dog meows makes sound");
        }

    }
}