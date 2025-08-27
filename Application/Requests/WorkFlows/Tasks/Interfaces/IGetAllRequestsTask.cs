using public_requests.Domain.Dtos;

namespace public_requests.Application.Requests.WorkFlows.Tasks.Interfaces
{
    public interface IGetAllRequestsTask
    {
        IEnumerable<RequestDto> Get();
    }
}
