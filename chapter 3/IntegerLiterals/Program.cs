namespace IntegerLiterals
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 240; // 10진수 리터럴
            System.Console.WriteLine($"a={a}");

            byte b = 0b1111_0000; // 2진수 리터럴
            System.Console.WriteLine($"b={b}");

            byte c = 0xf0; // 16진수 리터럴
            System.Console.WriteLine($"c={c}");

            uint d = 0x1234_abcd; // 16진수 리터럴
            System.Console.WriteLine($"d={d}");
        }
    }
}
