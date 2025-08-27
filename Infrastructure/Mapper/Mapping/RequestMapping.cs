using AutoMapper;
using public_requests.Application.Requests.Models;
using public_requests.Domain.Dtos;
using public_requests.Domain.Entities;

namespace public_requests.Infrastructure.Mapper.Mapping
{
    public class RequestMapping: Profile
    {
        public RequestMapping()
        {
            CreateMap<CreateNewRequestModel, Request>();

            CreateMap<RequestDto, Request>();
            CreateMap<Request, RequestDto>();
        }
    }
}
