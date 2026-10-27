namespace LocalFunction
{
    class Program
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90) // A - Z ASCII value (65 ~ 90)
                    return arr[i];
                else // a - z ASCII value (97 ~ 122)
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine(ToLowerString("Hello"));
            System.Console.WriteLine(ToLowerString("Good Morning"));
            System.Console.WriteLine(ToLowerString("This is C#"));
        }
    }
}