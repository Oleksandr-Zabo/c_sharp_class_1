namespace c_sharp_class_1
{//hw ex-3
    internal class Program
    {
        static void Main()
        {
            var random = new Random();
            var originalArray = new int[10];
            for (int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = random.Next(1, 10);
            }
            Console.WriteLine("Original array: ");
            foreach (int element in originalArray)
            {
                Console.Write(element + " ");
            }
            
            var filterArray = new int[3];
            for (int i = 0; i < filterArray.Length; i++)
            {
                filterArray[i] = random.Next(1, 10);
            }

            Console.WriteLine();
            Console.WriteLine("Filter array: ");
            foreach (int element in filterArray)
            {
                Console.Write(element + " ");
            }

            int[] resultArray = FilterArray(originalArray, filterArray);
            Console.WriteLine();
            Console.WriteLine("Filtered array: ");
            foreach (int element in resultArray)
            {
                Console.Write(element + " ");
            }
        }

        static int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            int[] tempArray = new int[originalArray.Length];
            int index = 0;

            foreach (int element in originalArray)
            {
                bool found = false;
                foreach (int filterElement in filterArray)
                {
                    if (element == filterElement)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    tempArray[index++] = element;
                }
            }

            int[] resultArray = new int[index];
            Array.Copy(tempArray, resultArray, index);
            return resultArray;
        }
    }

}
