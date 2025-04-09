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
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string pcName = Environment.MachineName;
            fileName = $"{pcName}_{timestamp}_{fileName}";
            string folder = Path.Combine(Directory.GetCurrentDirectory(), "wyniki");
            Directory.CreateDirectory(folder);
            filePath = Path.Combine(folder, fileName);
        }

        public void Log(int matrixSize, int threads, long timeMs, string method, string machineName)
        {
            if (!headerWritten && !File.Exists(filePath))
            {
                File.AppendAllText(filePath, "Machine,MatrixSize,Threads,AvgTimeMs,Method\n");
                headerWritten = true;
            }

            string line = $"{machineName},{matrixSize},{threads},{timeMs},{method}\n";
            File.AppendAllText(filePath, line);
        }
    }
}
