namespace Enum
{
    class Program
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

        static void Main(string[] args)
        {
            System.Console.WriteLine((int)DialogResult.YES);
            System.Console.WriteLine((int)DialogResult.NO);
            System.Console.WriteLine((int)DialogResult.CANCEL);
            System.Console.WriteLine((int)DialogResult.CONFIRM);
            System.Console.WriteLine((int)DialogResult.OK);
        }


    }
}

