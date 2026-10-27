namespace UsingVar
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 20;
            System.Console.WriteLine("Type: {0}, Value:{1}", a.GetType(), a);

            var b = 3.1414213;
            System.Console.WriteLine("Type: {0}, Value:{1}", b.GetType(), b);

            var c = "Hello World";
            System.Console.WriteLine("Type: {0}, Value:{1}", c.GetType(), c);

            var d = new int[] {10, 20, 30};
            System.Console.Write("Type: {0}, Value:", d.GetType());
            foreach (var e in d)
                System.Console.Write("{0} ", e);
            
            System.Console.WriteLine();

        }
    }
}

