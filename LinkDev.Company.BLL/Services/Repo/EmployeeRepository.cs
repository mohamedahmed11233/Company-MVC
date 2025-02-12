using LinkDev.Company.BLL.Services.Interfaces;
using LinkDev.Company.DAL.Models;
using LinkDev.Company.DAL.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.Company.BLL.Services.Repo
{
    public class EmployeeRepository : GenericRepository<Employee>
    {
       

        public EmployeeRepository(Context context):base(context)
        {
            
        }
     
    }
}
