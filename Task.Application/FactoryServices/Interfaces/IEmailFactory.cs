using Task.Shared.DTOs;

namespace Task.Application.FactoryServices.Interfaces
{
    public interface IEmailFactory
    {
        void Create(EventDTO instance);
    }
}
