using System.Collections.Generic;

namespace FastFood.Models
{
    public class ReponseView<T>
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public List<T> Data { get; set; }
    }
}
