namespace public_requests.Application.Requests.Models
{
    public class CreateNewRequestModel
    {
        public string FullName { get; set; } = default!;
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int DepartmentId { get; set; }
        public string Description { get; set; } = default!;
    }
}
