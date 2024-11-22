namespace c_sharp_class_1
{//hw ex-1
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter lenth of square: ");
                string? input = Console.ReadLine();
                if (input == null)
                {
                    throw new Exception("input is null");
                }

                int n = Convert.ToInt32(input);
                if (n < 0)
                {
                    throw new Exception("input is negative");
                }

                Console.WriteLine("Enter char: ");
                input = Console.ReadLine();
                if (input == null || input.Length != 1)
                {
                    throw new Exception("input is null or not char");
                }
                char c  = Convert.ToChar(input);
                print_square(n, c);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void print_square(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(c);
                Console.WriteLine();
            }
        }
    }
}


