using HomeWorkTask.Shared.DTOs;
using System.Threading.Tasks;

namespace WebAPI.MyOptionsSettings.Interfaces
{
    public interface IMyOptionsConfigurationReader
    {
        Task ReadOptionsSettings(int selection, EventDTO eventItem);
    }
}
