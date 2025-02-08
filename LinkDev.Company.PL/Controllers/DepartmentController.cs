using LinkDev.Company.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LinkDev.Company.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepositry repo;

        public DepartmentController( IDepartmentRepositry repositry)
        {
            repo = repositry;
        }
        public IActionResult Index()
        {
            var department = repo.GetAll();
            
            return View(department);
        }
    }
}
