namespace Lab3Konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Testowanie mnożenia macierzy
            //MatrixMultiplier.TestMultiplication();

            string machine = Environment.MachineName;
            CsvLogger logger = new();

            // Testowanie wydajności mnożenia macierzy
            int[] sizes = { 200, 500, 1000 };
            int[] threadCounts = { 1, 2, 4, 8, 16 };
            int iterations = 1;

            Console.Write("       ______    _     _                    _____ _ _   _    _       _     \r\n      |  ____|  | |   (_)          ____    / ____(_) | | |  | |     | |    \r\n __  _| |__   __| |_____ _   _    / __ \\  | |  __ _| |_| |__| |_   _| |__  \r\n \\ \\/ /  __| / _` |_  / | | | |  / / _` | | | |_ | | __|  __  | | | | '_ \\ \r\n  >  <| |___| (_| |/ /| | |_| | | | (_| | | |__| | | |_| |  | | |_| | |_) |\r\n /_/\\_\\______\\__,_/___|_|\\__,_|  \\ \\__,_|  \\_____|_|\\__|_|  |_|\\__,_|_.__/ \r\n                                  \\____/                                   \r\n                                                                           ");

            Console.WriteLine("\nTest wydajności mnożenia macierzy\n");

            for (int i = 0; i < iterations; i++)
            {
                Console.WriteLine($"\nIteracja {i + 1}/{iterations}\n");
                foreach (int size in sizes)
                {
                    Matrix A = Matrix.GenerateRandom(size, size, seed: 1);
                    Matrix B = Matrix.GenerateRandom(size, size, seed: 2);

                    Console.WriteLine($"\nRozmiar macierzy: {size}x{size}");

                    Console.WriteLine("Mnożenie macierzy używając Parallel:");
                    foreach (int threads in threadCounts)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        Matrix result = MatrixMultiplier.MultiplyParallel(A, B, threads);
                        watch.Stop();
                        Console.WriteLine($"Wątki: {threads}, czas: {watch.ElapsedMilliseconds} ms");
                        logger.Log(size, i + 1, threads, watch.ElapsedMilliseconds, "Parallel", machine);
                    }
                    Console.WriteLine("Mnożenie macierzy używając Threaded:");
                    foreach (int threads in threadCounts)
                    {
                        ThreadedMatrixMultiplier multiplier = new();
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        Matrix result = multiplier.Multiply(A, B, threads);
                        watch.Stop();
                        Console.WriteLine($"Wątki: {threads}, czas: {watch.ElapsedMilliseconds} ms");
                        logger.Log(size, i + 1, threads, watch.ElapsedMilliseconds, "Threaded", machine);
                    }
                }
            }
        }
    }
}
