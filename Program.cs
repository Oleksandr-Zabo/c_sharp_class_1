namespace c_sharp_class_1
{//hw ex- 5
    using c_sharp_class_1.Entity;
    internal class Program
    {
        static void Main()
        {
            var journal = new Journal("Journal", 2021, "Description", "+123321", "email@dot.com");
            Console.WriteLine(journal);

        }
    }
}