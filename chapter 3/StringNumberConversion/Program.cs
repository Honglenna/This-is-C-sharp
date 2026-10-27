namespace StringNumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            string b = a.ToString();
            System.Console.WriteLine(b);

            float c = 3.14f;
            string d = c.ToString();
            System.Console.WriteLine(d);

            string e = "123456";
            int f = Convert.ToInt32(e);
            System.Console.WriteLine(f);

            string g = "1.2345";
            float h = float.Parse(g);
            System.Console.WriteLine(h);

        }
    }
}

