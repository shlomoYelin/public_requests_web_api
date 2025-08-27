using public_requests.Domain.Dtos;

namespace public_requests.Application.Requests.WorkFlows.Interfaces
{
    public interface IGetAllRequestsWorkFlow
    {
        IEnumerable<RequestDto> Get();
    }
}
