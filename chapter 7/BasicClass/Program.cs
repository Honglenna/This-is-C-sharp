namespace BasicClass
{
    class Cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            System.Console.WriteLine($"{Name} : Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.Color = "White";
            kitty.Name = "Kitty";
            kitty.Meow();
            System.Console.WriteLine($"{kitty.Name} : {kitty.Color}");

             Cat nero = new Cat();
            nero.Color = "Black";
            nero.Name = "Nero";
            nero.Meow();
            System.Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}
