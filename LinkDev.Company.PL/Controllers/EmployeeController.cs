using LinkDev.Company.BLL.Services.Interfaces;
using LinkDev.Company.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LinkDev.Company.PL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository repo;
        private readonly IDepartmentRepositry _departmentRepositry;

        public EmployeeController(IEmployeeRepository repositry ,IDepartmentRepositry departmentRepositry)
        {
            repo = repositry;
            _departmentRepositry = departmentRepositry;
        }
        [HttpGet]
        public IActionResult Index(string searchValue)
        {
            var department =Enumerable.Empty<Employee>();
            if (searchValue == null)
            {
                 department = repo.GetAll();
            }
            else
            {
                department =repo.GetEmpByName(searchValue);
            }  
            return View(department);
        }

        [HttpGet]
        public IActionResult Create()
        {
           var departments = _departmentRepositry.GetAll() ?? new List<Department>();
            
            ViewBag.Departments = new SelectList(departments, "Id", "Name");

            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee department)
        {
            if (ModelState.IsValid)
            {
                var result = repo.Add(department);
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }

        public IActionResult Details(int? id)
        {
            if (id is null)
                return BadRequest();
            var department = repo.Get(id.Value);
            if (department is null)
                return NotFound();
            return View(department);
        }
        [HttpGet]

        public IActionResult Edit(int? id)
        {
            return Details(id);
        }
        [HttpPost]
        public IActionResult Edit(Employee dep)
        {
            if (ModelState.IsValid)
            {
                var department = repo.Update(dep);
                if (department > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(dep);

        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            return Details(id);
        }

        [HttpPost]
        public IActionResult Delete([FromRoute] int id, Employee department)
        {
            if (id != department.Id)
            {
                return BadRequest();
            }
            try
            {
                repo.Delete(department);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(department);
        }

    }
}
