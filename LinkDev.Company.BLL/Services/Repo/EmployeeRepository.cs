using LinkDev.Company.BLL.Services.Interfaces;
using LinkDev.Company.DAL.Models;
using LinkDev.Company.DAL.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.Company.BLL.Services.Repo
{
    public class EmployeeRepository : GenericRepository<Employee>,IEmployeeRepository
    {
       

        public EmployeeRepository(Context context):base(context)
        {
            
        }

        public IQueryable<Employee> GetEmpByName(string name)
        {
            return dbContext.Employees.Where(e=> e.Name == name).Include(d=>d.Department);
        }
    }
}
