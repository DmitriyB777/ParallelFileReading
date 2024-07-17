using ParallelFileReading.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelFileReading.Library.Classes
{
    public class ConsoleUI : IUI
    {
        public void Output(string output)
        {
            Console.WriteLine(output);
        }
    }
}