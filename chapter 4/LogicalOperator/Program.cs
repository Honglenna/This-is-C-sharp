namespace LogicalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Testing && .... ");
            System.Console.WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}");
            System.Console.WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}");
            System.Console.WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}");
            System.Console.WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}");

            System.Console.WriteLine("\nTesting || .... ");
            System.Console.WriteLine($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}");
            System.Console.WriteLine($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}");
            System.Console.WriteLine($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}");
            System.Console.WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}");

            System.Console.WriteLine("\nTesting ! .... ");
            System.Console.WriteLine($"!True : {!true}");
            System.Console.WriteLine(($"!False : {!false}"));

        }


    }
}

