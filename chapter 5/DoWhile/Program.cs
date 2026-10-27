namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                System.Console.WriteLine($"a) i : {i--}");
            }
            while (i > 0);

            do
            {
                System.Console.WriteLine($"b) i : {i--}");
            }
            while (i > 0);
        }
    }
}

