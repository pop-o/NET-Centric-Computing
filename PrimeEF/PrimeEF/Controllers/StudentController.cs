using Microsoft.AspNetCore.Mvc;
using PrimeEF.Models;
using System.Diagnostics.Eventing.Reader;
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
        //action method for update operation
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            //check if id sent from view is matched with database record or not
            //if matched send the data to set method od EditStudent
            var editData=sc.Students.FirstOrDefault(x => x.Id == id);
            if(editData != null)
            {
                //if id mathced with db table record
                var editStd = new EditStudent()
                {
                    Id=editData.Id,
                    Name=editData.Name,
                    Gender=editData.Gender,
                    Address=editData.Address,
                    Faculty=editData.Faculty
                };
                return View(editStd);
            }
            else
            {
                return RedirectToAction("Index");
            }
            
           

        }
        [HttpPost]
        public IActionResult Edit(EditStudent es) 
        {
            //checking if id of editStudent persit or not in database
            //save changes in database
            var editStds = sc.Students.Find(es.Id);
            if(editStds != null )
            {
                editStds.Id = es.Id;
                editStds.Name = es.Name;
                editStds.Gender = es.Gender;
                editStds.Address = es.Address;  
                editStds.Faculty = es.Faculty;
                sc.Students.Add(editStds);
                sc.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        

    }
    
}
