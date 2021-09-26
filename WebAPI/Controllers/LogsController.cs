using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTOs;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogsController : ControllerBase
    {
        
        private readonly ILogger<LogsController> _logger;

        public LogsController(ILogger<LogsController> logger, )
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<EventDTO> GetById(int id)
        {

            throw new NotImplementedException();
        }
        [HttpPost]
        public async Task<EventDTO> Post()
        {
            throw new NotImplementedException();
        }
    }
}
