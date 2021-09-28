using HomeWorkTask.Application.FactoryServices.Interfaces;
using HomeWorkTask.Shared.DTOs;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.MyOptionsSettings.Interfaces;

namespace WebAPI.MyOptionsSettings
{
    public class MyOptionsConfigurationReader : IMyOptionsConfigurationReader
    {
        private readonly IOptions<MyOptionsSettings> _myOptionsSettings;

        private readonly IConsoleFactory _consoleFactory;
        private readonly IEmailFactory _emailFactory;
        private readonly IWriteToFileFactory _writeToFileFactory;
        private readonly IDbFactory _dbFactory;

        public MyOptionsConfigurationReader(
            IOptions<MyOptionsSettings> myOptionsSettings,

            IConsoleFactory consoleFactory,
            IEmailFactory emailFactory,
            IWriteToFileFactory writeToFileFactory,
            IDbFactory dbFactory)
        {
            _myOptionsSettings = myOptionsSettings;

            _consoleFactory = consoleFactory;
            _emailFactory = emailFactory;
            _writeToFileFactory = writeToFileFactory;
            _dbFactory = dbFactory;
        }
        public async Task ReadOptionsSettings(int selection, EventDTO eventItem)
        {
            if (selection == 1)
            {
               _consoleFactory.Create(eventItem);
            }
            else if (selection == 2)
            {
                await _emailFactory.Create(eventItem);
            }
            else if (selection == 3)
            {
                _writeToFileFactory.Post(eventItem);
            }
            if (selection == 4)
            {
                await _dbFactory.CreateEvent(eventItem);
            }
        }
    }
}
