using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Application.FactoryServices.Interfaces;
using Task.Data.InitialData;
using Task.Data.Models;

namespace Task.Application.FactoryServices
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

