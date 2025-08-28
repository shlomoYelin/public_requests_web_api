using Microsoft.AspNetCore.Mvc;
using public_requests.Application.MonthlyReport.WorkFlows.Interfaces;
using public_requests.Application.Requests.Models;
using public_requests.Application.Requests.WorkFlows.Interfaces;

namespace public_requests.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly ICreateNewRequestWorkFlow _createNewRequestWorkFlow;
        private readonly IGetAllRequestsWorkFlow _getAllRequestsWorkFlow;
        private readonly IGetMonthlyReportResultWorkFlow _getMonthlyReportResultWorkFlow;

        public RequestController(ICreateNewRequestWorkFlow createNewRequestWorkFlow, IGetAllRequestsWorkFlow getAllRequestsWorkFlow, IGetMonthlyReportResultWorkFlow getMonthlyReportResultWorkFlow)
        {
            _createNewRequestWorkFlow = createNewRequestWorkFlow;
            _getAllRequestsWorkFlow = getAllRequestsWorkFlow;
            _getMonthlyReportResultWorkFlow = getMonthlyReportResultWorkFlow;
        }

        [HttpGet]
        public IActionResult GetAllRequests()
        {
            var result = _getAllRequestsWorkFlow.Get();
            return Ok(result);
        }
        
        [HttpGet]
        public IActionResult GetMonthlyReportResult()
        {
            var result = _getMonthlyReportResultWorkFlow.Get();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateNewRequest([FromBody] CreateNewRequestModel model)
        {
            var result = _createNewRequestWorkFlow.Create(model);

            return Ok(result);
        }
    }
}
