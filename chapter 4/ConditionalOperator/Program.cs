namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = (10 % 2) == 0 ? "짝수" : "홀수";

            System.Console.WriteLine(result);
        }
    }
}

