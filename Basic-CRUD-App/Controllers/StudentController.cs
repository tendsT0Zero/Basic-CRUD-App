using Basic_CRUD_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic_CRUD_App.Controllers
{
    public class StudentController : Controller
    {


        private static List<Student> students = new List<Student> {
                new Student
                {
                    Name= "John Doe",
                    Email = "jhon@gmail.com",
                    Description="A software engineer with 5 years of experience in web development.",
                    ProgrammingLanguages = new List<string> { "C#", "JavaScript", "Python" }
                },
                new Student
                {
                    Name= "Jane Smith",
                    Email = "smith@hotmail.com",
                    Description="A data scientist with a passion for machine learning.",
                    ProgrammingLanguages = new List<string> { "Python", "R", "SQL" }
                },
                new Student
                {
                    Name= "Alice Johnson",
                    Email = "johnson@gmail.com",
                    Description="A front-end developer with a knack for creating beautiful user interfaces.",
                    ProgrammingLanguages = new List<string> { "HTML", "CSS", "JavaScript" }
                }

         };
        public string Index()
        {
            return "Welcome to learn Basic CRUD operations using only Array";
        }

        public IActionResult Read()
        {
            
            return View(students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                students.Add(student);
                return RedirectToAction("Read");
            }
            return View(student);
        }
    }
}
