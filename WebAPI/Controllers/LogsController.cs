using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWorkTask.Application.FactoryServices.Interfaces;
using HomeWorkTask.Data.Models;
using HomeWorkTask.Shared.DTOs;
using WebAPI.MyOptionsSettings.Interfaces;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogsController : ControllerBase
    {

        private readonly ILogger<LogsController> _logger;
        private readonly IDbFactory _dbFactory;
        private readonly IEmailFactory _emailFactory;
        private readonly IConsoleFactory _consoleFactory;
        private readonly IWriteToFileFactory _writeToFileFactory;
        private readonly IMyOptionsConfigurationReader _myOptionsConfigurationReader;

        public LogsController(ILogger<LogsController> logger,
            IMapper mapper,

            IDbFactory dbFactory,
            IEmailFactory emailFactory,
            IConsoleFactory consoleFactory,
            IWriteToFileFactory writeToFileFactory,
            IMyOptionsConfigurationReader myOptionsConfigurationReader
            )
        {
            _logger = logger;
            _dbFactory = dbFactory;
            _emailFactory = emailFactory;
            _consoleFactory = consoleFactory;
            _writeToFileFactory = writeToFileFactory;
            _myOptionsConfigurationReader = myOptionsConfigurationReader;
        }

        [HttpGet]
        public async Task<IEnumerable<EventDTO>> Get()
        {
            //if (pasirinkimas ==4)
            //{
            var eventsList = await _dbFactory.GetEvents();
            //}
            return eventsList;
        }

        [HttpGet("{id}")]
        public async Task<EventDTO> GetById(int id)
        {
            var eventItem = await _dbFactory.GetEventById(id);

            return eventItem;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EventDTO eventItem)
        {
            await _myOptionsConfigurationReader.ReadOptionsSettings(1, eventItem);
            //if (pasirinkimas == 1)
            //{
            //    _consoleFactory.Create(eventItem);
            //}
            //else if (pasirinkimas == 2)
            //{
            //    await _emailFactory.Create(eventItem);
            //}
            //else if (pasirinkimas == 3)
            //{
            //    _writeToFileFactory.Post(eventItem);
            //}
            //if (pasirinkimas == 4)
            //{
            //    await _dbFactory.CreateEvent(eventItem);
            //}


            return NoContent();
        }
    }
}
