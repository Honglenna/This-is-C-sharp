namespace Constructor
{
    class Cat
    {
        public string Name;
        public string Color;

        public Cat()
        {
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }

        ~Cat()
        {
            System.Console.WriteLine($"{Name} : 잘가");
        }

        public void Meow()
        {
            System.Console.WriteLine($"{Name} : 야옹");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "White");
            kitty.Meow();
            System.Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat("네로", "Black");
            nero.Meow();
            System.Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
    
}


