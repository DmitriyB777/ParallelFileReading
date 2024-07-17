using ParallelFileReading.Library.Classes;
using ParallelFileReading.Library.Interfaces;
using System.Diagnostics;

namespace ParallelFileReading.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUI uI = new ConsoleUI();
            IFileReader fileReader = new FileReader(uI);
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            fileReader.SpaceCount("C:\\test", 3);

            stopwatch.Stop();

            Console.WriteLine($"Execution time: {stopwatch.ElapsedMilliseconds} ms");

            Console.ReadKey();
        }
    }
}
