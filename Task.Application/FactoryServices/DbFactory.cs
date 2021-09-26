using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Task.Application.FactoryServices.Interfaces;
using Task.Data;
using Task.Data.Models;

namespace Task.Application.FactoryServices
{
    public class DbFactory : IDbFactory
    {
        private readonly TaskDbContext _db;

        public DbFactory(TaskDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Event> Get()
        {
            return _db.Events
                .Include(a => a.Location)
                .ThenInclude(b => b.User)
                .ToList();
        }
        public Event GetById(int id)
        {
            return _db.Events.Where(x => x.Id == id)
                 .Include(a => a.Location)
                 .ThenInclude(b => b.User)
                 .FirstOrDefault<Event>();
        }

        public void Create(Event eventItem)
        {
            _db.Events.Add(eventItem);
            _db.SaveChanges();
        }
    }
}
