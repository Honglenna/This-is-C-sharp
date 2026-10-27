namespace FloatConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 69.6875f;
            System.Console.WriteLine("a : {0}", a);

            double b = (double)a;
            System.Console.WriteLine("b : {0}", b);
            System.Console.WriteLine("69.6875 == b : {0}", 69.6875 == b);

            float x = 0.1f;
            System.Console.WriteLine("x : {0}", x);

            double y = (double)x;
            System.Console.WriteLine("y : {0}", y);
            System.Console.WriteLine("0.1 == y : {0}", 0.1 == y);
        }
    }
}

