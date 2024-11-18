using EmployeAdminPortal.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeAdminPortal.Data
{
    public class ApplicationDbContext : DbContext //Inherit
    {
        //Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
