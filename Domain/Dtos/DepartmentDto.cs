namespace public_requests.Domain.Dtos
{
    public class DepartmentDto
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = default!;
        public ICollection<RequestDto> Requests { get; set; } = new List<RequestDto>();
    }
}
