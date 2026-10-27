namespace ShiftOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Testing << ...");

            int a = 1;
            System.Console.WriteLine("a         : {0:D5} (0x{0:X8})", a);
            System.Console.WriteLine("a << 1    : {0:D5} (0x{0:X8})", a << 1);
            System.Console.WriteLine("a << 2    : {0:D5} (0x{0:X8})", a << 2);
            System.Console.WriteLine("a << 5    : {0:D5} (0x{0:X8})", a << 5);

            System.Console.WriteLine("\nTesting >> ...");

            int b = 255;
            System.Console.WriteLine("b         : {0:D5} (0x{0:X8})", b);
            System.Console.WriteLine("b >> 1    : {0:D5} (0x{0:X8})", b >> 1);
            System.Console.WriteLine("b >> 2    : {0:D5} (0x{0:X8})", b >> 2);
            System.Console.WriteLine("b >> 5    : {0:D5} (0x{0:X8})", b >> 5);

            System.Console.WriteLine("\nTesting >> 2 ...");

            int c = -255;
            System.Console.WriteLine("c         : {0:D5} (0x{0:X8})", c);
            System.Console.WriteLine("c >> 1    : {0:D5} (0x{0:X8})", c >> 1);
            System.Console.WriteLine("c >> 2    : {0:D5} (0x{0:X8})", c >> 2);
            System.Console.WriteLine("c >> 5    : {0:D5} (0x{0:X8})", c >> 5);
        }
    }
}