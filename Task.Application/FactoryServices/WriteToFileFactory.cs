using HomeWorkTask.Application.FactoryServices.Interfaces;
using HomeWorkTask.Data.InitialData;
using HomeWorkTask.Data.Models;
using System.Collections.Generic;
using System.IO;

namespace HomeWorkTask.Application.FactoryServices
{
    public class WriteToFileFactory : IWriteToFileFactory
    {

        private string filePath = $"C:{Path.DirectorySeparatorChar}Users{Path.DirectorySeparatorChar}algir{Path.DirectorySeparatorChar}TextFile.txt";
        public void WriteToFile()
        {
            TextWriter textWriter = new StreamWriter(filePath, true);
            var eventList = new List<Event>();
            var eventData = EventInitialData.DataSeed;
            foreach (var item in eventList)
            {
                textWriter.WriteLine($"{item}");
                eventList.Add(eventData);
            }

            textWriter.Close();
        }
    }
}

