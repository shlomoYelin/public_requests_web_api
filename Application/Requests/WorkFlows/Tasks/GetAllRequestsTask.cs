using public_requests.Application.Data.Request.Query;
using public_requests.Application.Requests.WorkFlows.Tasks.Interfaces;
using public_requests.Domain.Dtos;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace public_requests.Application.Requests.WorkFlows.Tasks
{
    public class GetAllRequestsTask : IGetAllRequestsTask
    {
        private readonly IGetAllRequestsQuery _getAllRequestsQuery;
        private readonly IMapper _mapper;

        public GetAllRequestsTask(IGetAllRequestsQuery getAllRequestsQuery, IMapper mapper)
        {
            _getAllRequestsQuery = getAllRequestsQuery;
            _mapper = mapper;
        }

        public IEnumerable<RequestDto> Get()
        {
            var result = _getAllRequestsQuery.Get().AsNoTracking().ToList();

            return _mapper.Map<List<RequestDto>>(result);
        }
    }
}
