namespace Enum2
{
    class Program
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

        static void Main(string[] args)
        {
            DialogResult result = DialogResult.YES;

            System.Console.WriteLine(result == DialogResult.YES);
            System.Console.WriteLine(result == DialogResult.NO);
            System.Console.WriteLine(result == DialogResult.CANCEL);
            System.Console.WriteLine(result == DialogResult.CONFIRM);
            System.Console.WriteLine(result == DialogResult.OK);
        }
    }
}

