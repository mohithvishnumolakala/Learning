using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Console.OOPS
{
    internal class Classes
    {

    }

    class A
    {
        int a;
         A() {
            
        }
        
    }
    public  class B {
        int b;
       public  B() { }
        void Eat(string fruit) {
            System.Console.WriteLine(fruit);

        }
    }
    
    class C {
        int c;
        void Breath() { }
        B obj = new B();

    }
    class D {
        int d;
        void ReleaseGas() { }

    }
    class E {
        int e;
        void Break() { }
    }

}
