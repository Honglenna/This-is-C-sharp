namespace RefReturn
{
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            System.Console.WriteLine($"Price : {price}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();
            System.Console.WriteLine($"Ref local Price : {ref_local_price}");
            System.Console.WriteLine($"Normal local Price : {normal_local_price}");

            ref_local_price = 200;
            carrot.PrintPrice();
            System.Console.WriteLine($"Ref local Price : {ref_local_price}");
            System.Console.WriteLine($"Normal local Price : {normal_local_price}");
            
        }

    }
    
}
