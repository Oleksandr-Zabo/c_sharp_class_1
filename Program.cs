namespace c_sharp_class_1
{//lab ex- 7
    using c_sharp_class_1.Entity;
    internal class Program
    {

        static void Main()
        {
            var random = new Random();
            int[,] initialData = new int[3,3];

            for (int i = 0; i < initialData.GetLength(0); i++)
            {
                for (int j = 0; j < initialData.GetLength(1); j++)
                {
                    initialData[i, j] = random.Next(0, 10);
                }
            }

            Matrix matrix = new Matrix(initialData);
            Console.WriteLine($"Matrix: \n{matrix}");
            Console.WriteLine($"Max value: {matrix.GetMax()}");
            Console.WriteLine($"Min value: {matrix.GetMin()}");
        }
    }
}