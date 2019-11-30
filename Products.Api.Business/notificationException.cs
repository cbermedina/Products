using System;

namespace Products.Api.Business
{
    public class NotificationException : Exception
    {
        public NotificationException(string className, string method, Exception exception) {
            ClassName = className;
            Method = method;
            Exception = exception;
        }

        public string ClassName { get; set; }
        public string Method { get; set; }
        public Exception Exception { get; set; }
    }
}
