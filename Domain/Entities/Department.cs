namespace public_requests.Domain.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = default!;
        public ICollection<Request> Requests { get; set; } = new List<Request>();
    }
}
