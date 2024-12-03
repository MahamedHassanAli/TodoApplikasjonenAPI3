using Serilog;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace TodoApplikasjonenAPI3.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                // Log feilmeldingen i Serilog
                Log.Error(ex, "En feil oppstod på serveren.");

                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Response.ContentType = "text/plain";

                await context.Response.WriteAsync("En feil oppstod på serveren. Prøv igjen senere.");
            }
        }
    }
}
