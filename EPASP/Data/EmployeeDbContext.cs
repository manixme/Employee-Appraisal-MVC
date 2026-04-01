using EPASP.Models;
using EPASP.Data;
using Microsoft.EntityFrameworkCore;

namespace EPASP.Data
{
    public class EmployeeDbContext: DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext>options): base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
