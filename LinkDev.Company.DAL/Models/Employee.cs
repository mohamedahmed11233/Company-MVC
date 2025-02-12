using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.Company.DAL.Models
{
    public class Employee :BaseModel
    {
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }
        public string? ImageName { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public Department? Department { get; set; }
        public int? DepartmentId { get; set; }
    }
}
