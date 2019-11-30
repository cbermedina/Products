using System;

namespace Products.Api.CrossCutting.Interface
{
    public interface IServiceLog
    {
        void WriteDebug(string className, string method, decimal elapsedMs);
        void WriteError(string className, string method, Exception errorMessage);
    }
}
