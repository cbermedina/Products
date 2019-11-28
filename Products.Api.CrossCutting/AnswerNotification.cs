namespace Products.Api.CrossCutting
{
    using System.Net;
    public class AnswerNotification<T> where T : class
    {
        /// <summary>
        /// Codigo respuesta peticion
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }
        /// <summary>
        /// Mensaje respuesta
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Respuesta Paramétrica Peticion
        /// </summary>
        public T Response { get; set; }

        /// <summary>
        /// Obtiene respuesta dinámica
        /// </summary>
        /// <param name="httpStatusCode"></param>
        /// <param name="message"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static AnswerNotification<T> GetAnswer(HttpStatusCode httpStatusCode, string message, T response)
        {
            return new AnswerNotification<T> { StatusCode = httpStatusCode, Message = message, Response = response };
        }
    }
}
