using public_requests.Application.Requests.Models;
using public_requests.Domain.Dtos;
using public_requests.Domain.Models;

namespace public_requests.Application.Requests.WorkFlows.Interfaces
{
    public interface ICreateNewRequestWorkFlow
    {
        ResultModel<RequestDto> Create(CreateNewRequestModel model);
    }
}
