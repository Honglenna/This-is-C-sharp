namespace Overloading
{
    class Program
    {
        static int Plus(int a, int b)
        {
            System.Console.WriteLine("Calling int Plus(int, int)...");
            return a + b;
        }

        static int Plus(int a, int b, int c)
        {
            System.Console.WriteLine("Calling int Plus(int, int, int)...");
            return a + b + c;
        }

        static double Plus(double a, double b)
        {
            System.Console.WriteLine("Calling double Plus(double, double)...");
            return a + b;
        }

        static double Plus(int a, double b)
        {
            System.Console.WriteLine("Calling double Plus(int, double)...");
            return a + b;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine(Plus(1, 2));
            System.Console.WriteLine(Plus(1, 2, 3));
            System.Console.WriteLine(Plus(1.0, 2.4));
            System.Console.WriteLine(Plus(1, 2.4));
        }


    }

}