namespace Break
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("계속할까요? (Y/N) : ");
                string? answer = Console.ReadLine();

                if (answer == "N")
                    break;
            }
        }
    }
}

