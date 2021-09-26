using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task.Application.FactoryServices.Interfaces;
using Task.Data.Models;
using Task.Shared.DTOs;
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
        private int pasirinkimas = 2;

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
        public async Task<List<EventDTO>> Get()
        {
            throw new NotImplementedException();

        }
        [HttpGet("{id}")]
        public async Task<EventDTO> GetById(int id)
        {

            throw new NotImplementedException();
        }
        [HttpPost]

        public IActionResult Post(EventDTO eventItem)

        public IActionResult Post([FromBody] EventDTO eventItem)

        {
            var entity = _mapper.Map<Event>(eventItem);
            _dbFactory.Create(entity);

            //if(pasirinkimas == 1)
            //{ _consoleFactory.Create(); }

            if (pasirinkimas == 3)
            {
                _writeToFileFactory.WriteToFile();
            }
            else if (pasirinkimas == 2)
            {
                _emailFactory.Create(eventItem);
            }

            //else if(pasirinkimas == 2)
            //{ _emailFactory.Create(); }
            // if (pasirinkimas == 3)
            //{
            //    _writeToFileFactory.WriteToFile();
            //}
            //else if(pasirinkimas == 4)
            //{
            //    await _dbFactory.Create(eventItem);

            //}
            return NoContent();
        }
    }
}
