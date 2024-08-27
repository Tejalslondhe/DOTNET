using Microsoft.AspNetCore.Mvc;
using StudentsRegistration.Services;
using StudentsRegistration.Models;

namespace StudentsRegistration.Controllers
{
    public class StudentsController : Controller
    {
        private IStudentService studentService;

        public StudentsController(IStudentService studentService)
        {
           this.studentService = studentService;
        }

        public IActionResult Index()
        {
            /*List<Student> students = studentService.DisplayAll();
            return View(students);*/
            return View();
        }

        public IActionResult DisplayAll()
        {
            List<Student> students = studentService.DisplayAll();
            return View(students);
        }

        

        
        [HttpGet]
        public IActionResult DeleteById()
        {
            return View();

        }

        [HttpPost]
        public IActionResult DeleteById(int id)
        {
            studentService.DeleteById(id);
           return View();
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(string name,string email,string mobno,string address,
            string admdate,string fees,string status)
        {
            DateTime dt = DateTime.Parse(admdate);
            double fee = double.Parse(fees);
            

            Student student = new Student(name,email,mobno,address,dt,fee,status);
            studentService.AddStudent(student);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(string id,string name, string email, string mobno, string address,
            string admdate, string fees, string status)
        {
            int i = int.Parse(id);
            DateTime dt = DateTime.Parse(admdate);
            double fee = double.Parse(fees);

            Student student = new Student(i,name, email, mobno, address, dt, fee, status);
            studentService.Update(student);
            return RedirectToAction("Index");
        }




    }
}
