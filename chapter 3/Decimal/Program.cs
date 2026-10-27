namespace Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 3.1415_9265_3589_7932_3846_2643_3832_79f; // 숫자 뒤에 f -> float
            double b = 3.1415_9265_3589_7932_3846_2643_3832_79; // 아무것도 없으면 double
            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m; // 숫자 뒤에 m -> decimal

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}