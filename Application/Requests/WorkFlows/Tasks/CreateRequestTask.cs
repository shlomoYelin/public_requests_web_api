using AutoMapper;
using public_requests.Application.Data.Request.Command;
using public_requests.Application.Requests.Models;
using public_requests.Application.Requests.WorkFlows.Tasks.Interfaces;
using public_requests.Domain.Dtos;
using public_requests.Domain.Entities;

namespace public_requests.Application.Requests.WorkFlows.Tasks
{
    public class CreateRequestTask : ICreateRequestTask
    {
        private readonly IMapper _mapper;
        private readonly ICreateRequestCommand _createRequestCommand;

        public CreateRequestTask(IMapper mapper, ICreateRequestCommand createRequestCommand)
        {
            _mapper = mapper;
            _createRequestCommand = createRequestCommand;
        }

        public RequestDto Create(CreateNewRequestModel model)
        {
            var request  = _mapper.Map<Request>(model);

            request = _createRequestCommand.Create(request);

            return _mapper.Map<RequestDto>(request);
        }
    }
}
