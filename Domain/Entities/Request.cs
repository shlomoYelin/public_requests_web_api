namespace public_requests.Domain.Entities
{
    public class Request
    {
        public int RequestId { get; set; }
        public string FullName { get; set; } = default!;
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int DepartmentId { get; set; }
        public string Description { get; set; } = default!;
        public DateTime? CreatedAt { get; set; }

        public Department? Department { get; set; }
    }
}
