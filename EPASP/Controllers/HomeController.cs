using EPASP.Models;
using EPASP.Data;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;

namespace EPASP.Controllers
{
    
    public class HomeController : Controller
    {
        public readonly EmployeeDbContext _context;
        
        public HomeController(EmployeeDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            var employee = _context.Employees.ToList();
            
            return View(employee);
        }
        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var employee = _context.Employees.Find(Id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        
        public IActionResult Delete(int Id)
        {
            var employee = _context.Employees.Find(Id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
