namespace c_sharp_class_1
{//lab ex- 4
    using c_sharp_class_1.Entity;
    internal class Program
    {
        
        static void Main()
        {
            var city = new Entity.City("New York", "USA", 8_500_000, 212);
            city[0] = "Manhattan";
            city[1] = "Brooklyn";
            city[2] = "Queens";
            System.Console.WriteLine(city);
        }
    }
}


