namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            while (i > 0)
            {
                System.Console.WriteLine($"i : {i--}");
            }
        }
    }
}

