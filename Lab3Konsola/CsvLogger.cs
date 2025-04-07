using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Konsola
{
    internal class CsvLogger
    {
        private readonly string filePath;
        private bool headerWritten = false;

        public CsvLogger(string fileName = "results.csv")
        {
            string folder = Path.Combine(Directory.GetCurrentDirectory(), "wyniki");
            Directory.CreateDirectory(folder);
            filePath = Path.Combine(folder, fileName);
        }

        public void Log(int matrixSize, int iteration, int threads, long timeMs, string method, string machineName)
        {
            if (!headerWritten && !File.Exists(filePath))
            {
                File.AppendAllText(filePath, "Machine,MatrixSize,Iteration,Threads,TimeMs,Method\n");
                headerWritten = true;
            }

            string line = $"{machineName},{matrixSize},{iteration},{threads},{timeMs},{method}\n";
            File.AppendAllText(filePath, line);
        }
    }
}
