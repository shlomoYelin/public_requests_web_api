using Microsoft.AspNetCore.Mvc;
using public_requests.Application.Requests.Models;
using public_requests.Application.Requests.WorkFlows.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace public_requests.API.Controllers
{
    [Route("api/[controller]")]
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

        // GET api/<RequestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public IActionResult CreateNewRequest([FromBody] CreateNewRequestModel model)
        {
            var result = _createNewRequestWorkFlow.Create(model);

            return Ok(result);
        }

        // PUT api/<RequestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RequestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
