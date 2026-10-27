namespace ArithmaticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 111 + 222;
            System.Console.WriteLine($"a : {a}");

            int b = a - 100;
            System.Console.WriteLine($"b : {b}");

            int c = b * 10;
            System.Console.WriteLine($"c : {c}");

            double d = c / 6.3;
            System.Console.WriteLine($"d : {d}");

            System.Console.WriteLine($"22 / 7 = {22 / 7}({22 % 7})");
        }
    }
}


