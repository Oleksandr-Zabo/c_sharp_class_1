namespace c_sharp_class_1
{//lab ex- 5
    using c_sharp_class_1.Entity;
    internal class Program
    {

        static void Main()
        {
            string[] job_description = new string[] { "Develop", "Test", "Deploy" };
            Employee employee = new Employee("John Doe", new DateTime(1985, 5, 15), "+123456789", "john.doe@example.com", position: "Software Developer", job_description);
            Console.WriteLine(employee);
        }
    }
}


