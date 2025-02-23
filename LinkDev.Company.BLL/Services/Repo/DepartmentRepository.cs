using LinkDev.Company.BLL.Services.Interfaces;
using LinkDev.Company.DAL.Models;
using LinkDev.Company.DAL.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.Company.BLL.Services.Repo
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepositry
    {
        public DepartmentRepository(Context context) : base(context)
        {
        }
    }
}
