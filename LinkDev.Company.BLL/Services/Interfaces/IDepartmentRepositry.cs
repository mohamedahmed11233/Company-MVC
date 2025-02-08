using LinkDev.Company.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.Company.BLL.Services.Interfaces
{
    public interface IDepartmentRepositry
    {
        ICollection<Department> GetAll();
        Department Get(int id);
        int Add(Department NewDepartment);
        int Delete(Department department);
        int Update(Department NewDepartment);

    }
}
