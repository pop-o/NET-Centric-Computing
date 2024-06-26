using Microsoft.AspNetCore.Mvc;
using Pre.Models;

namespace Pre.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext sc;
        public StudentController(StudentContext sc)
        {
            this.sc = sc;
        }
        [HttpGet]
        public IActionResult InsertStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InsertStudent(Student s)
        {
            var stud = new Student()
            {
                Id = Guid.NewGuid(),
                Name = s.Name
            };
            sc.Students.Add(stud);
            sc.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            var st = sc.Students.ToList();
            return View(st);
        }
    }
}
