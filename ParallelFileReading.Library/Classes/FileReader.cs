using ParallelFileReading.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelFileReading.Library.Classes
{
    public class FileReader : IFileReader
    {
        private readonly IUI _uI;

        public FileReader(IUI uI)
        {
            _uI = uI;
        }

        public void SpaceCount(string folderPath, int countFiles)
        {
            string[] files = Directory.GetFiles(folderPath).Take(countFiles).ToArray();

            List<Task> tasks = new List<Task>();

            foreach (string file in files)
            {
                tasks.Add(Task.Run(() => 
                {
                    int spaceCount = CountSpacesInFile(file);
                    _uI.Output($"File {file} contains {spaceCount} spaces.");
                }));
            }

            Task.WaitAll(tasks.ToArray());
        }

        public void SpaceCount(string folderPath)
        {
            SpaceCount(folderPath, Directory.GetFiles(folderPath).Length);
        }

        private int CountSpacesInFile(string filePath)
        {
            int spaceCount = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    spaceCount += line.Split(' ').Length - 1;
                }
            }

            return spaceCount;
        }
    }
}
