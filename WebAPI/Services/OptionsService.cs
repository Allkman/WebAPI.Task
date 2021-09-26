using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.MyOptionsSettings;

namespace WebAPI.Services
{
    public class OptionsService : IOptionsService
    {
        private readonly ConsoleOptionsSettings _consoleOptions;
        private readonly EmailOptionsSettings _emailOptions;
        private readonly WriteToFileOptionsSettings _writeToFileOptions;
        private readonly EfDbOptionsSettings _efDbOptions;
        private bool isOption = false;

        public OptionsService(
            IOptions<ConsoleOptionsSettings> consoleOptions,
            IOptions<EmailOptionsSettings> emailOptions,
            IOptions<WriteToFileOptionsSettings> writeToFileOptions,
            IOptions<EfDbOptionsSettings> efDbOptions         
            

            )
        {
            _consoleOptions = consoleOptions.Value;
            _emailOptions = emailOptions.Value;
            _writeToFileOptions = writeToFileOptions.Value;
            _efDbOptions = efDbOptions.Value;
        }


        public void ReadOptionsSettings()
        {
            //if (!isOption = false)
            //{
            //    //ConsoleFactory
            //    return;
            //}
            //if (true)
            //{
            //    //EmailFactory
            //}
        }
    }
}
