using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelFileReading.Library.Interfaces
{
    public interface IFileReader
    {
        void SpaceCount(string folderPath, int countFiles);
        void SpaceCount(string folderPath);
    }
}
