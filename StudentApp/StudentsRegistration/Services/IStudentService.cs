using StudentsRegistration.Models;

namespace StudentsRegistration.Services
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        List<Student> DisplayAll();

        void Update(Student student);

        void DeleteById(int sid);

        List<Student> Sort(List<Student> students);
    }
}
