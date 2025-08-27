using public_requests.Application.Requests.WorkFlows.Interfaces;
using public_requests.Application.Requests.WorkFlows.Tasks.Interfaces;
using public_requests.Domain.Dtos;

namespace public_requests.Application.Requests.WorkFlows
{
    public class GetAllRequestsWorkFlow : IGetAllRequestsWorkFlow
    {
        private readonly ILogger<GetAllRequestsWorkFlow> _logger;
        private readonly IGetAllRequestsTask _getAllRequestsTask;

        public GetAllRequestsWorkFlow(ILogger<GetAllRequestsWorkFlow> logger, IGetAllRequestsTask getAllRequestsTask)
        {
            _logger = logger;
            _getAllRequestsTask = getAllRequestsTask;
        }

        public IEnumerable<RequestDto> Get()
        {
			try
			{
                return _getAllRequestsTask.Get();
			}
			catch (Exception ex)
			{
                _logger.LogError($"{ex.StackTrace} - {ex.Message}");
                throw;
			}
        }
    }
}
