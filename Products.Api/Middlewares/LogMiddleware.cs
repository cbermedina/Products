using Microsoft.AspNetCore.Builder;

namespace Products.Api.Middlewares
{
    /// <summary>
    /// Log Middleware
    /// </summary>
    public static class LogMiddleware
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseLogApplicationInsights(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<Log>();
            return builder;
        }

    }
}
