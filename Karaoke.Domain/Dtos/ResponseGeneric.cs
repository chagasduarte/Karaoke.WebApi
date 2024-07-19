using System.Net;
using System.Dynamic;

namespace Karaoke.Domain.Dtos
{
    public class ResponseGeneric<T> where T : class
    {
        public HttpStatusCode StatusCode { get; set; }
        public T? ReturnData { get; set; }
        public ExpandoObject? ReturnError { get; set; }
    }
}
