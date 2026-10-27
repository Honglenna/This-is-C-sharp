namespace SwapByValue
{
    class Program
    {
        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"Swap before x : {x}, y : {y}");
            Swap(x,y);
            Console.WriteLine($"Swap after x : {x}, y : {y}");
        }
    }
}

