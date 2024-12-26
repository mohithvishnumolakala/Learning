using Learning.Console;
using Learning.Console.Arrays;
using Learning.Console.OOPS;
using Learning.Console.Strings;



internal class Program
{
    private static void Main(string[] args)
    {

        Strings obj = new Strings();
        //obj.Example();
        //CompileTimeVsRuntime();
        // ArraysIntro obj = new ArraysIntro();
        //obj.Example2();
        //obj.SumOfElements();
        //obj.CountOccur();
        //obj.Search();
        //obj.OccuranceOfLetter();
        obj.VowelsCount();
    }

    static void CompileTimeVsRuntime()
    {
        int x = 0; int y = 10;
        //Compile time error
        //int x=0  // syntax error 

        //runtime error
        //int s = 10 / 0; // divide by 0  
        //arr[index out of range] // index of range exception

        //var sum = Console.ReadLine();
        MethodA(1, "2");
        MethodA("a", 1);
        //Compile ytime polymorphism --> Which method tocall is decided at compile time;

        Animal obj = new Animal();
        obj.sound();

        Animal c = new Cat();
        c.sound();  // which method to call is decided at run time.


    }

    static void MethodA(int a, string b)
    {
        Console.WriteLine("No Params");
    }

    static void MethodA(string a, int b)
    {
        Console.WriteLine("one param a");
    }
    static void MethodA(bool a, int b)
    {
        Console.WriteLine("one param a");
    }

    static void inheritanceDemo()
    {
        Animal obj = new Animal();
        obj.sound();

        Cat c = new Cat();
        c.sound();
        c.sample();

        Dog d = new Dog();
        d.sound();
    }

    static void Loops()
    {
        Forloop Fobj = new Forloop();
        //Fobj.ForLoopMethod();
        //Fobj.Print1to10();
        //Fobj.Print10to1();
        //Fobj.PrintEven();
        //Fobj.PrintOdd();
        //Fobj.Table();
        //Fobj.Factorial();
        //Fobj.SumFactorial();
        //Fobj.Fibbinoci();
        Fobj.PrimeNumber();

        Whileloop Wobj = new Whileloop();
        //Wobj.WhileLoopMethod();
        //Wobj.Print1to10();
        //Wobj.Print10to1();
        //Wobj.PrintEven();
        //Wobj.PrintOdd();
        //Wobj.Table();
        //Wobj.Factorial();
        //Wobj.CountOfDigits();
        //Wobj.SumofDigits();
        //Wobj.ReverseNum();


        //Patterns.SquarePattern();
        //Patterns.RectanglePattern();
        //Patterns.LeftTriangle();
        //Patterns.num1();
        //Patterns.num2();
        //Patterns.num3();
        //Patterns.num4();
        //Patterns.num5();
        //Patterns.num6();
        //Patterns.num7();
        //Patterns.RightTriangle();
        // Patterns.EqualTriangle();


        //DoWhileloop.DoWhileLoop();
        // DoWhileloop.DoWhile();
    }

}
