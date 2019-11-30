using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System.IO;
using System.Threading.Tasks;

namespace Products.Api.Middlewares
{
    public class Log
    {

        private readonly RequestDelegate _next;

        public Log(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var requestBodyStream = new MemoryStream();
            var originalRequestBody = context.Request.Body;

            await context.Request.Body.CopyToAsync(requestBodyStream);
            requestBodyStream.Seek(0, SeekOrigin.Begin);

            var url = UriHelper.GetDisplayUrl(context.Request);
            var requestBodyText = new StreamReader(requestBodyStream).ReadToEnd();

            requestBodyStream.Seek(0, SeekOrigin.Begin);
            context.Request.Body = requestBodyStream;

            await _next(context);

            context.Request.Body = originalRequestBody;

            Tracerequest(requestBodyText, url, context.Request.Method);

        }

        private void Tracerequest(string payload, string url, string method)
        {

            //var telemetry = new TraceTelemetry(url);

            //telemetry.Properties.Add("Body", payload);
            //telemetry.Properties.Add("Method", method);
            //_telemetryClient.TrackTrace(telemetry);
        }


    }
}
