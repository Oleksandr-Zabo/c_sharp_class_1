public class c_sharp_class_1
{//lab ex-2
    public static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isFibonacci = IsFibonacci(number);
        Console.WriteLine($"{number} is Fibonacci: {isFibonacci}");
    }

    public static bool IsFibonacci(int number)
    {
        if (number < 0) return false;

        int a = 0;
        int b = 1;

        while (b < number)
        {
            int temp = b;
            b = a + b;
            a = temp;
        }

        return b == number || a == number;
    }
}



