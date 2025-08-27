using public_requests.Application.Requests.Models;
using public_requests.Domain.Dtos;

namespace public_requests.Application.Requests.WorkFlows.Tasks.Interfaces
{
    public interface ICreateRequestTask
    {
        RequestDto Create(CreateNewRequestModel model);
    }
}
