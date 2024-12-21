using Microsoft.AspNetCore.Mvc;
using RequestsChallenge.Model;
using static System.Net.Mime.MediaTypeNames;

namespace RequestsChallenge.Api
{
    public class ErrorMiddleware
    {
        private readonly RequestDelegate _next;
        public ErrorMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            
            await _next(context);
            if (context.Response.StatusCode == 400)
            {
                await context.Response.WriteAsync(new ErrorMessage(Type: "400", Message: "Bad Request").ToString());
            }
            else if (context.Response.StatusCode == 403)
            {
                await context.Response.WriteAsync(new ErrorMessage(Type:"403", Message: "Forbidden").ToString());
            }
            else if (context.Response.StatusCode == 404)
            {
                await context.Response.WriteAsync(new ErrorMessage(Type: "404", Message: "Not Found").ToString());
            }
            else if (context.Response.StatusCode == 502)
            {
                await context.Response.WriteAsync(new ErrorMessage(Type: "502", Message: "Bad gateway").ToString());
            }
            else if (context.Response.StatusCode == 500)
            {
                await context.Response.WriteAsync(new ErrorMessage(Type: "500", Message: "Internal server error").ToString());
            }
        }
    }
}
