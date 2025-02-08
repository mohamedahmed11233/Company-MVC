using LinkDev.Company.BLL.Services.Interfaces;
using LinkDev.Company.DAL.Models;
using LinkDev.Company.DAL.Persistance.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.Company.BLL.Services.Repo
{
    public class DepartmentRepository : IDepartmentRepositry
    {
        private readonly Context context;

        public DepartmentRepository(Context _context)
        {
            context = _context;
        }
        public int Add(Department NewDepartment)
        {
            context.Departments.Add(NewDepartment);

            return context.SaveChanges();

        }

        public int Delete(Department department)
        {
            context.Departments.Remove(department);
            return context.SaveChanges();
        }

        public Department Get(int id)
        {

            return context.Departments.FirstOrDefault(x => x.Id == id);


        }

        public ICollection<Department> GetAll()
        {
            return context.Departments.ToList();
        }

        public int Update(Department NewDepartment)
        {
            context.Departments.Update(NewDepartment);
            return context.SaveChanges();

        }
    }
}
