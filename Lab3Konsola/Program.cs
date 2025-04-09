namespace Lab3Konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string machine = Environment.MachineName;
            CsvLogger logger = new();

            // Testowanie wydajności mnożenia macierzy
            int[] sizes = { 200, 500, 1000 };
            int[] threadCounts = { 1, 2, 4, 6, 8, 10, 12, 16 };
            int iterations = 10;

            Console.Write("       ______    _     _                    _____ _ _   _    _       _     \r\n      |  ____|  | |   (_)          ____    / ____(_) | | |  | |     | |    \r\n __  _| |__   __| |_____ _   _    / __ \\  | |  __ _| |_| |__| |_   _| |__  \r\n \\ \\/ /  __| / _` |_  / | | | |  / / _` | | | |_ | | __|  __  | | | | '_ \\ \r\n  >  <| |___| (_| |/ /| | |_| | | | (_| | | |__| | | |_| |  | | |_| | |_) |\r\n /_/\\_\\______\\__,_/___|_|\\__,_|  \\ \\__,_|  \\_____|_|\\__|_|  |_|\\__,_|_.__/ \r\n                                  \\____/                                   \r\n                                                                           ");

            Console.WriteLine("\nTest wydajności mnożenia macierzy\n");

            foreach (int size in sizes)
            {
                Console.WriteLine($"\nRozmiar macierzy: {size}x{size}");
                Matrix A = Matrix.GenerateRandom(size, size, seed: 1);
                Matrix B = Matrix.GenerateRandom(size, size, seed: 2);

                foreach (int threads in threadCounts)
                {
                    // Obliczanie średniego czasu dla Parallel
                    long totalParallelTime = 0;
                    for (int i = 0; i < iterations; i++)
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        Matrix result = MatrixMultiplier.MultiplyParallel(A, B, threads);
                        watch.Stop();
                        totalParallelTime += watch.ElapsedMilliseconds;
                    }
                    long averageParallelTime = totalParallelTime / iterations;
                    Console.WriteLine($"[Parallel] Wątki: {threads}, średni czas: {averageParallelTime} ms");
                    logger.Log(size, threads, averageParallelTime, "Parallel", machine);

                    // Obliczanie średniego czasu dla Threaded
                    long totalThreadedTime = 0;
                    for (int i = 0; i < iterations; i++)
                    {
                        ThreadedMatrixMultiplier multiplier = new();
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        Matrix result = multiplier.Multiply(A, B, threads);
                        watch.Stop();
                        totalThreadedTime += watch.ElapsedMilliseconds;
                    }
                    long averageThreadedTime = totalThreadedTime / iterations;
                    Console.WriteLine($"[Threaded] Wątki: {threads}, średni czas: {averageThreadedTime} ms");
                    logger.Log(size, threads, averageThreadedTime, "Threaded", machine);
                }
            }
        }
    }
}
