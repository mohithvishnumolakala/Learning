using Learning.Console;
using Learning.Console.Arrays;

internal class Program
{
    private static void Main(string[] args)
    {

        Loops();
        //ArraysIntro.PrintArray();
        //ArraysIntro.PrintString();

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