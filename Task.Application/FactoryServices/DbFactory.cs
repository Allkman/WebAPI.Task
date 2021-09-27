using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using HomeWorkTask.Application.FactoryServices.Interfaces;
using HomeWorkTask.Data;
using HomeWorkTask.Data.Models;
using System.Threading.Tasks;
using AutoMapper;
using HomeWorkTask.Shared.DTOs;

namespace HomeWorkTask.Application.FactoryServices
{
    public class DbFactory : IDbFactory
    {
        private readonly HomeWorkTaskDbContext _db;
        private readonly IMapper _mapper;

        public DbFactory(HomeWorkTaskDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public Task<IEnumerable<EventDTO>> GetEvents()
        {
            var eventList = _db.Events
                .Include(a => a.Location)
                .ThenInclude(b => b.User);
            var model = _mapper.Map<IEnumerable<EventDTO>>(eventList);

            return Task.FromResult(model);
        }
        public async Task<EventDTO> GetEventById(int id)
        {
            var entity = await _db.Events.Where(x => x.Id == id)
                 .Include(a => a.Location)
                 .ThenInclude(b => b.User)
                 .ToListAsync();

            var model = _mapper.Map<EventDTO>(entity.FirstOrDefault());

            return model;
        }

        public async Task CreateEvent(EventDTO eventDTO)
        {
            Event model = _mapper.Map<Event>(eventDTO);
            _db.Events.Add(model);

            await _db.SaveChangesAsync();
        }
    }
}
