namespace c_sharp_class_1
{//hw ex- 4
    using c_sharp_class_1.Entity;
    internal class Program
    {

        static void Main()
        {
            Web_site web_site = new Web_site("Google", "www.google.com", "Search engine", "192.168.0.1");
            System.Console.WriteLine(web_site);
        }
    }
}