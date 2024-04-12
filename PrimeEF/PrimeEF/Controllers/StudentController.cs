using Microsoft.AspNetCore.Mvc;
using PrimeEF.Models;
//controller is responsible for passing data to model and view
namespace PrimeEF.Controllers
{
    public class StudentController : Controller
    {
        //setting context class on controller
        private readonly StudentContext sc;
        public StudentController(StudentContext sc) 
        {
            this.sc = sc;
        }
        //this method is used for creating form in view. it uses get
        [HttpGet]
        public IActionResult InsertStudent()
        {
            return View();
        }
        [HttpPost]
        //accept form data and insert into database table
        public IActionResult InsertStudent(AddStudent s)
        {
            var st = new Student()
            {
                Id = Guid.NewGuid(),//auto generated
                Name = s.Name,
                Gender = s.Gender,
                Address = s.Address,
                Faculty = s.Faculty
            };
            sc.Students.Add(st);
            sc.SaveChanges();
            return RedirectToAction("Index");
        }
        //displaying data

        public IActionResult Index()
        {
            //data will be displayed in index.cshtml
            //data from table will be converted into list and sent to view
            var viewStd=sc.Students.ToList();

            return View(viewStd);
        }
    }
}
