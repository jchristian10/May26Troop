using StudentSchedule.DbContexts;
using StudentSchedule.Models;
using StudentSchedule.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentSchedule.Controllers
{
    public class StudentController : Controller
    {

        private IStudentRepository _repo;

        public StudentController():this(new StudentRepository())
        {
        }

        public StudentController(IStudentRepository repo)
        {
            _repo = repo;
        }

        //Creating an instance of our DbContext and thus an instance of the lists inside it
        //private StudentDbContext _db = new StudentDbContext();

        // GET: Student
        public ActionResult Index()
        {
            var students = from m in _repo.ListStudents() select m;
            return View(students.ToList());
        }

        
        //This ActionResult allows you to open up a view with text boxes where you can create a student and add them to the Database
        public ActionResult Create()
        {
            return View();
        }
        //This Action Request takes the inputed student and passes that inforamtion to the database, as well as showing the user an updated list
        [HttpPost]
        public ActionResult Create (Student student)
        {
            if (ModelState.IsValid)
            {
                _repo.CreateStudent(student);
                return RedirectToAction("Index");
            }
            return View();
        }
        //This allows the user to edit a student in the database.  This returns the AddStudent view and populates the text boxes with the student's data
        public ActionResult Edit(int id)
        {
            var student = _repo.FindStudent(id);
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if(ModelState.IsValid)
            {
                _repo.UpdateStudent(student);
                return RedirectToAction("Index");
            }
            return View();
        }
        //This allows you to delete a student from the database
        public ActionResult Delete (int id)
        {
            var student = _repo.FindStudent(id);
            return View(student);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally (int id)
        {
            _repo.DeleteStudent(id);
            return RedirectToAction("Index");
        }

    }
}