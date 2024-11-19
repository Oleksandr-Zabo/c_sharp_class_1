namespace c_sharp_class_1
{//lab ex- 6
    using c_sharp_class_1.Entity;
    internal class Program
    {

        static void Main()
        {
            var airplane = new Airplane("Boeing 747", "Boeing", 1969, "Commercial Jet");

            System.Console.WriteLine(airplane); 
        }
    }
}


