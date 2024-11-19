public class c_sharp_class_1
{//lab ex-1 
    public static void Main()
    {
        try
        {
            Console.Write("Enter start of range: ");
            int start = Convert.ToInt32(Console.ReadLine()); // Start of the range
            Console.Write("Enter end of range: ");
            int end = Convert.ToInt32(Console.ReadLine());   // End of the range
            if (start > end) {
                throw new Exception("Start of range should be less than end of range");
            }
            long product = CalculateProductInRange(start, end);
            Console.WriteLine($"The product of numbers from {start} to {end} is {product}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
       
    }

    public static long CalculateProductInRange(int start, int end)
    {
        long product = 1;
        for (int i = start; i <= end; i++)
        {
            product *= i;
        }
        return product;
    }
}



