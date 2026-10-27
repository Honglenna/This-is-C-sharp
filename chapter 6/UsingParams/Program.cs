namespace UsingParams
{
    class Program
    {
        static int Sum(params int[] args)
        {
            System.Console.Write("Summing......");

            int sum = 0;

            for (int i = 0; i < args.Length; i++)
            {
                if (i > 0)
                    System.Console.Write(", ");

                System.Console.Write(args[i]);
                sum += args[i];
            }
            System.Console.WriteLine();

            return sum;
        }

        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9);

            System.Console.WriteLine($"Sum : {sum}");
        }
    }
}
