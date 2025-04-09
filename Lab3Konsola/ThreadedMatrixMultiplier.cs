using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Konsola
{
    internal class ThreadedMatrixMultiplier
    {
        private Matrix A, B, Result;
        private int CurrentRow = 0;

        public Matrix Multiply(Matrix a, Matrix b, int threads)
        {
            if (a.Columns != b.Rows)
                throw new ArgumentException("Nieprawidłowe rozmiary macierzy do mnożenia");

            A = a;
            B = b;
            Result = new Matrix(A.Rows, B.Columns);

            Thread[] threadPool = new Thread[threads];

            for (int i = 0; i < threads; i++)
            {
                threadPool[i] = new Thread(Worker);
                threadPool[i].Start();  
            }

            foreach (Thread t in threadPool)
                t.Join();

            return Result;
        }

        private void Worker()
        {
            while (true)
            {
                int row = Interlocked.Increment(ref CurrentRow) - 1;

                if (row >= A.Rows)
                    return;

                for (int j = 0; j < B.Columns; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < A.Columns; k++)
                    {
                        sum += A[row, k] * B[k, j];
                    }

                    Result[row, j] = sum;
                }
            }
        }

    }
}
