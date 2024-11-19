using System;

namespace c_sharp_class_1.Entity
{
    internal class Matrix
    {
        private int[,] data;
        private int rows;
        private int columns;

        
        public Matrix()
        {
            rows = 0;
            columns = 0;
            data = new int[rows, columns];
        }

        
        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            data = new int[rows, columns];
        }

        
        public Matrix(int[,] initialData)
        {
            rows = initialData.GetLength(0);
            columns = initialData.GetLength(1);
            data = initialData;
        }

        
        public void SetElement(int row, int column, int value)
        {
            if (row >= 0 && row < rows && column >= 0 && column < columns)
            {
                data[row, column] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
        }

        
        public int GetElement(int row, int column)
        {
            if (row >= 0 && row < rows && column >= 0 && column < columns)
            {
                return data[row, column];
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
        }

        
        public void DisplayMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(data[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result += data[i, j] + "\t";
                }
                result += "\n";
            }
            return result;
        }

        
        public int GetMax()
        {
            int max = data[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (data[i, j] > max)
                    {
                        max = data[i, j];
                    }
                }
            }
            return max;
        }

        
        public int GetMin()
        {
            int min = data[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (data[i, j] < min)
                    {
                        min = data[i, j];
                    }
                }
            }
            return min;
        }
    }

}
