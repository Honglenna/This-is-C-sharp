namespace SignedUnsignedConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 500;
            System.Console.WriteLine(a);

            uint b = (uint)a;
            System.Console.WriteLine(b);

            int x = -30;
            System.Console.WriteLine(x);

            uint y = (uint)x; // Underflow
            System.Console.WriteLine(y);
        }
    }
}

