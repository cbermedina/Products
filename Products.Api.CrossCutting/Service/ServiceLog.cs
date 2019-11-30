using Products.Api.CrossCutting.Interface;
using Serilog;
using System;

namespace Products.Api.CrossCutting.Service
{
    public class ServiceLog : IServiceLog
    {
        public void WriteDebug(string className, string method, decimal elapsedMs)
        {
            Log.Debug($"ClassName --> {className}: Method -> {method}: Miliseconds -> {elapsedMs}");
        }

        public void WriteError(string className, string method, Exception exception)
        {
            Log.Error($"ClassName --> {className}: Method -> {method}, Error{exception.Message}, InnerException{exception.InnerException}, StackTrace {exception.StackTrace}");
        }
    }
}
