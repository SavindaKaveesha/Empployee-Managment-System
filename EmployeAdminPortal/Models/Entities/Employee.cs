namespace EmployeAdminPortal.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? phone { get; set; }
        public decimal Salary { get; set; }
    }
}
