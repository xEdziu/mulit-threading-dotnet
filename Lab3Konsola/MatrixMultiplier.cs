using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Konsola
{
    internal class MatrixMultiplier
    {
        public static Matrix MultiplyParallel(Matrix A, Matrix B, int maxThreads)
        {
            if (A.Columns != B.Rows)
                throw new ArgumentException("Liczba kolumn macierzy A musi być równa liczbie wierszy B");

            Matrix result = new Matrix(A.Rows, B.Columns);
            ParallelOptions opt = new ParallelOptions()
            {
                MaxDegreeOfParallelism = maxThreads
            };

            Parallel.For(0, A.Rows, opt, i =>
            {
                for (int j = 0; j < B.Columns; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < A.Columns; k++)
                        sum += A[i, k] * B[k, j];

                    result[i, j] = sum;
                }
            });

            return result;
        }

        public static void TestMultiplication()
        {
            int size = 2;
            Matrix A = Matrix.GenerateRandom(size, size, seed: 1);
            Matrix B = Matrix.GenerateRandom(size, size, seed: 2);
            Matrix result = MultiplyParallel(A, B, 1);
            Console.WriteLine("Macierz A:");
            A.Print();
            Console.WriteLine("Macierz B:");
            B.Print();
            Console.WriteLine("Wynik mnożenia:");
            result.Print();
        }
    }
}
