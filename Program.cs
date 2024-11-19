public class c_sharp_class_1
{//lab ex.-3
    public static void Main()
    {
        try
        {
            var random = new Random();
            var array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Enter type of sort(true- growing, false- decreasing): ");
            string? input = Console.ReadLine();
            if (input != "true" || input != "false")
            {
            }
            bool ascending = Convert.ToBoolean(input);

            SortArray(array, ascending);

            Console.WriteLine("Sorted array:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
        catch (Exception ex)
        {

            Console.WriteLine($"Error: {ex.Message}");
        }
        
    }

    public static void SortArray(int[] array, bool ascending)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (ascending ? array[j] > array[j + 1] : array[j] < array[j + 1])
                {
                    // Swap array[j] and array[j + 1]
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    
                }
            }
        }
    }
}



