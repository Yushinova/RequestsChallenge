using RequestsChallenge.Model;

namespace RequestsChallenge.Api
{
    public class RequestMiddleware
    {
        private readonly RequestDelegate _next;
        public RequestMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var request = context.RequestServices.GetRequiredService<RequestService>();
            var time = DateTime.UtcNow;
            await _next(context);
            await request.AddAsync(context.Request, context.Response, time);
        }
    }
}
