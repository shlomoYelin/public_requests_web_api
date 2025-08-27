using Microsoft.AspNetCore.Mvc;
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

        public RequestController(ICreateNewRequestWorkFlow createNewRequestWorkFlow, IGetAllRequestsWorkFlow getAllRequestsWorkFlow)
        {
            _createNewRequestWorkFlow = createNewRequestWorkFlow;
            _getAllRequestsWorkFlow = getAllRequestsWorkFlow;
        }

        [HttpGet]
        public IActionResult GetAllRequests()
        {
            var result = _getAllRequestsWorkFlow.Get();

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
