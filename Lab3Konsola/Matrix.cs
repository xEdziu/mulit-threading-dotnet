using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab3Konsola
{
    internal class Matrix
    {
        public int Rows { get; }
        public int Columns { get; }
        public double[,] Data;

        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Columns = cols;
            Data = new double[rows, cols];
        }

        public double this[int row, int col]
        {
            get => Data[row, col];
            set => Data[row, col] = value;
        }

        public static Matrix GenerateRandom(int rows, int cols, int seed = 0)
        {
            var rand = seed == 0 ? new Random() : new Random(seed);
            var matrix = new Matrix(rows, cols);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = rand.NextDouble() * 100;
            return matrix;
        }


        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write($"{Data[i, j],10:F2} ");
                }
                Console.WriteLine();
            }
        }
    }
}

    
