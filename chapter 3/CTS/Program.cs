namespace CTS
{
    class Program
    {
        static void Main(string[] args)
        {
             Int32 a = 123;
             int b = 456;

             System.Console.WriteLine("a type:{0}, value:{1}", a.GetType().ToString(), a);
             System.Console.WriteLine("b type:{0}, value:{1}", b.GetType().ToString(), b);

            String c = "abc";
            string d = "def";

            System.Console.WriteLine("c type:{0}, value:{1}", c.GetType().ToString(), c);
            System.Console.WriteLine("d type:{0}, value:{1}", d.GetType().ToString(), d);
        }
    }
}
