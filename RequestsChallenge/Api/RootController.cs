using Microsoft.AspNetCore.Mvc;

namespace RequestsChallenge.Api
{
    [Route("api")]
    [ApiController]
    public class RootController: ControllerBase
    {
        // GET /api
        [HttpGet]
        public StringMessage Root()
        {
            return new StringMessage(Message: "server is running");
        }

        // GET /api/ping
        [HttpGet("ping")]
        public StringMessage Ping()
        {
            return new StringMessage(Message: "pong");
        }
    }
}
