using StudentsRegistration.Models;

namespace StudentsRegistration.Repositories
{
    public interface IStudentRepo
    {
        void AddStudent(Student student);

        List<Student> DisplayAll();

        void Update(Student student);

        void DeleteById(int id);

        List<Student> Sort(List<Student> student);

    }
}
