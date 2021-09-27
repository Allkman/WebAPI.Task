using HomeWorkTask.Shared.DTOs;
using System.Threading.Tasks;

namespace HomeWorkTask.Application.FactoryServices.Interfaces
{
    public interface IEmailFactory
    {
        Task Create(EventDTO instance);
    }
}
