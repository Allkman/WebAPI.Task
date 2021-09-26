using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Task.Data.FactoryServices.Interfaces;
using Task.Data.Models;

namespace Task.Data.FactoryServices
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

        public void Post(IEnumerable<Event> events)
        {
            using (_db)
            {
                foreach (var item in events)
                {
                    _db.Events.Add(item);
                }
                _db.SaveChanges();
            }
        }
    }
}
