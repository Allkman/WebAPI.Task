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
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogsController : ControllerBase
    {

        private readonly ILogger<LogsController> _logger;
        private readonly IMapper _mapper;
        private readonly IDbFactory _dbFactory;
        private readonly IEmailFactory _emailFactory;
        private readonly IConsoleFactory _consoleFactory;
        private readonly IWriteToFileFactory _writeToFileFactory;
        private readonly OptionsService _optionsService;
        private int pasirinkimas = 4;

        public LogsController(ILogger<LogsController> logger,
            IMapper mapper,

            IDbFactory dbFactory,
            IEmailFactory emailFactory,
            IConsoleFactory consoleFactory,
            IWriteToFileFactory writeToFileFactory)
        {
            _logger = logger;
            _mapper = mapper;
            _dbFactory = dbFactory;
            _emailFactory = emailFactory;
            _consoleFactory = consoleFactory;
            _writeToFileFactory = writeToFileFactory;
        }

        [HttpGet]
        public async Task<List<HomeWorkTask.Shared.DTOs.EventDTO>> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<HomeWorkTask.Shared.DTOs.EventDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EventDTO eventItem)
        {
            
            if(pasirinkimas == 1)
            { 
               //_consoleFactory.Create();
            }
            else if (pasirinkimas == 2)
            {
                await _emailFactory.Create(eventItem);
            }
            else if (pasirinkimas == 3)
            {
                _writeToFileFactory.WriteToFile();
            }
            if (pasirinkimas == 4)
            {
                await _dbFactory.CreateEvent(eventItem);
            }

            return NoContent();
        }
    }
}
