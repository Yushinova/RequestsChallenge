using Azure.Messaging;
using Microsoft.AspNetCore.Mvc;
using RequestsChallenge.Model;
using System.Diagnostics.Metrics;

namespace RequestsChallenge.Api
{
    [Route("api/request")]
    [ApiController]
    public class RequestController: ControllerBase
    {
        private readonly RequestService _requestService;
        public RequestController(RequestService request)
        {
            _requestService = request;
        }
        [HttpGet]
        public async Task<List<RequestInfo>> GetAllAsync()
        {
            return await _requestService.ListAllAsync(); ;
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAllAsync()
        {
            await _requestService.DeleteAllDataAsync();
            return new ObjectResult(new StringMessage( Message: "Deleted"));
        }
    }
}
