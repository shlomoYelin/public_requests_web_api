namespace public_requests.Domain.Models
{
    public class ResultModel<T>
    {
        public bool Succese { get; set; }
        public string? ErrorMessage { get; set; }
        public T? Model { get; set; }
    }
}
