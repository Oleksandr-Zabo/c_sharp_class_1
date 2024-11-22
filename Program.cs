namespace c_sharp_class_1
{//hw ex-2
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter number: ");
                string? input = Console.ReadLine();
                if (input == null)
                {
                    throw new Exception("input is null");
                }

                int number = Convert.ToInt32(input);
                if (number < 0)
                {
                    throw new Exception("input is negative");
                }

                is_palindrome(number);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void is_palindrome(int number) {
            int n = number;
            int reverse = 0;
            while (n > 0)
            {
                int remainder = n % 10;
                reverse = reverse * 10 + remainder;
                n /= 10;
            }
            if (number == reverse)
            {
                Console.WriteLine("Number is a palindrome.");
            }
            else
            {
                Console.WriteLine("Number is not a palindrome.");
            }
        }
    }
}


