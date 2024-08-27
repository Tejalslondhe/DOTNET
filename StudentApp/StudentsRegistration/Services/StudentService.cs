using StudentsRegistration.Models;
using StudentsRegistration.Repositories;

namespace StudentsRegistration.Services
{
    public class StudentService : IStudentService
    {
        private IStudentRepo studRepo = new StudentRepo();
        public void AddStudent(Student student)
        {
           studRepo.AddStudent(student); 
        }

        public void DeleteById(int sid)
        {
            studRepo.DeleteById(sid);
        }

        public List<Student> DisplayAll()
        {
            return studRepo.DisplayAll();
        }

                

        public List<Student> Sort(List<Student> students)
        {
            return studRepo.Sort(students);
        }

        public void Update(Student student)
        {
            studRepo.Update(student);
        }
    }
}
