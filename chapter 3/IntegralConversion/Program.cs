namespace IntegralConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 127;
            System.Console.WriteLine(a);

            int b = (int)a;
            System.Console.WriteLine(b);

            int x = 128; // sbyte의 최대값 127보다 1 큰 수
            System.Console.WriteLine(x);

            sbyte y = (sbyte)x; // overflow
            System.Console.WriteLine(y);
        }
    }
}
