namespace IntegerTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = -10;
            // sbyte a = -5000_0000_0000;
            // cannot implicitly convert type 'long' to 'sbyte'. An explicit conversion exists (are you missing a cast?)
            byte b = 40;

            Console.WriteLine($"a={a}, b={b}");

            short c = -30000;
            ushort d = 60000;

            Console.WriteLine($"c={c}, d={d}");

            // 큰 자리수의 정수 리터럴을 타이핑 할 때 자릿수 구분자를 이용하면 편리
            int e = -10_000_000; // 0이 7개
            uint f = 300_000_000; // 0이 8개

            Console.WriteLine($"e={e}, f={f}");
            
            long g = -500_000_000_000; // 0이 11개
            ulong h = 2_000_000_000_000_000_000; // 0이 18개

            Console.WriteLine($"g={g}, h={h}");
        }
    }
}
