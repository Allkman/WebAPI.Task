using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Data.Models;

namespace Task.Application.FactoryServices.Interfaces
{
    public interface IDbFactory
    {
        IEnumerable<Event> Get();
        Event GetById(int id);
        void Create(Event events);
    }
}
