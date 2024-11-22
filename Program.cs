namespace c_sharp_class_1
{//hw ex- 6
    using c_sharp_class_1.Entity;
    internal class Program
    {
        static void Main()
        {
            Shop shop = new Shop("Boots", "Ukraine, Kyiv", "Sale boots", "+380674375287", "email@shop.com");
            Console.WriteLine($"Shop name: {shop.Name}");
            Console.WriteLine($"Shop email: {shop.Email}");
            Console.WriteLine();
            Console.WriteLine(shop);
        }
    }
}


