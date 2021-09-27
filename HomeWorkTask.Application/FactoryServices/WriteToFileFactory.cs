using AutoMapper;
using HomeWorkTask.Application.FactoryServices.Interfaces;
using HomeWorkTask.Data.InitialData;
using HomeWorkTask.Data.Models;
using HomeWorkTask.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace HomeWorkTask.Application.FactoryServices
{
    public class WriteToFileFactory : IWriteToFileFactory
    {
        private readonly IMapper _mapper;
        private string filePath = $"{Environment.CurrentDirectory}{Path.DirectorySeparatorChar}LogData.txt";
        private object eventDTO;
        public WriteToFileFactory(IMapper mapper)
        {
            this._mapper = mapper;
        }
        public List<Event> Get()
        {
            var eventList = new List<Event> { };

            using (var file = new StreamReader(filePath))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Event item = JsonSerializer.Deserialize<Event>(ln);
                    eventList.Add(item);
                    counter++;
                }
            }

            return eventList;
        }

        public void Post(EventDTO eventDTO)
        {
            Event model = _mapper.Map<Event>(eventDTO);
            TextWriter textWriter = new StreamWriter(filePath, true);

            textWriter.WriteLine($"{JsonSerializer.Serialize(model)}");

            textWriter.Close();
        }
    }
}

