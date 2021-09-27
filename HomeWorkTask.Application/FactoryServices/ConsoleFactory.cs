using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HomeWorkTask.Application.FactoryServices.Interfaces;
using HomeWorkTask.Shared.DTOs;

namespace HomeWorkTask.Application.yServices
{
    public class ConsoleFactory : IConsoleFactory
    {
        public object Log { get; private set; }

        public void Create(EventDTO eventDTO)
        {
            string consoleBody = JsonSerializer.Serialize(eventDTO);

            Console.WriteLine(consoleBody);

        }


    }
}
