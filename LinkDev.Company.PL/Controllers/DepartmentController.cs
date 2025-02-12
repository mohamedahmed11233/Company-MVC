using LinkDev.Company.BLL.Services.Interfaces;
using LinkDev.Company.BLL.Services.Repo;
using LinkDev.Company.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace LinkDev.Company.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepositry repo;

        public DepartmentController(IDepartmentRepositry repositry)
        {
            repo = repositry;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var department = repo.GetAll();

            return View(department);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
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
        public IActionResult Edit(Department dep)
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
        public IActionResult Delete([FromRoute] int id, Department department)
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
