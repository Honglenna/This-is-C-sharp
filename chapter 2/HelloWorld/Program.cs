using static System.Console;

namespace HelloWold
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : Hello.exe 홍석우");
                return;
            }

            WriteLine("Hello, {0}!", args[0]);
        }
    }
}

