using HomeWorkTask.Data.Models;
using HomeWorkTask.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTask.Application.FactoryServices.Interfaces
{
    public interface IWriteToFileFactory
    {
        List<Event> Get();
        void Post(EventDTO eventDTO);
    }
}
