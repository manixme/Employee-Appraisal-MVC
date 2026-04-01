using EPASP.Models;
using EPASP.Data;
using Microsoft.EntityFrameworkCore;

namespace EPASP.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public int Salary { get; set; }

        public int Rating { get; set; }

        public bool IsActive { get; set; }
    }
}
