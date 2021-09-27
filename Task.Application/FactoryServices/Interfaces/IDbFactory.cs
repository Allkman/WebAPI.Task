using System.Collections.Generic;
using System.Threading.Tasks;
using HomeWorkTask.Shared.DTOs;

namespace HomeWorkTask.Application.FactoryServices.Interfaces
{
    public interface IDbFactory
    {
        Task<IEnumerable<EventDTO>> GetEvents();
        Task<EventDTO> GetEventById(int id);
        Task CreateEvent(EventDTO eventDTO);
    }
}
