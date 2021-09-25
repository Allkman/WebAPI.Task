using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Data.Models;

namespace Task.Data.FactoryServices.Interfaces
{
    public interface IDbFactory
    {
        IEnumerable<Event> Get();
        Event GetById(int id);
        void Post(IEnumerable<Event> events);
    }
}
