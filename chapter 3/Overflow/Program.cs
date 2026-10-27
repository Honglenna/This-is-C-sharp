namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue; // uint 의 최대값 : 4,294,967,295

            // vitamin quiz 3-2
            // int a = int.MaxValue;
            // int의 최소값인 -2147483648이 된다.


            System.Console.WriteLine(a);

            a = a + 1;

            System.Console.WriteLine(a);

        }
    }
}

