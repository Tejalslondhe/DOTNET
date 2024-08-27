using StudentsRegistration.Models;

namespace StudentsRegistration.Repositories
{
    public class StudentRepo : IStudentRepo
    {
        public void AddStudent(Student student)
        {
            using (var context = new StudentContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
                        
            }
        }

        public void DeleteById(int sid)
        {
            using (var context = new StudentContext())
            {
                context.Students.Remove(context.Students.Find(sid));
                context.SaveChanges();

            }
        }

        public List<Student> DisplayAll()
        {
            using(var context = new StudentContext())
            {
                var students = from student
                              in context.Students
                               select student;
                return students.ToList<Student>();
            }
            
        }

        /*public List<Student> GetByStatus(string status)
        {
            using (var context = new StudentContext())
            {
                return context.Students.Where(s=>s.status == status ).ToList<Student>(); 

            }

        }*/


        public List<Student> Sort(List<Student> students)
        {
            using(var context = new StudentContext())
            {
                return context.Students.OrderBy(s => s.status).ToList();
                 
            }
        }

        public void Update(Student student)
        {
            using (var context = new StudentContext())
            {
                var newStud = context.Students.Find(student.Id);
                if (newStud != null)
                {
                    newStud.Name = student.Name;
                    newStud.Email = student.Email;
                    newStud.Mobno = student.Mobno;
                    newStud.Address = student.Address;
                    newStud.AdmDate = student.AdmDate;
                    newStud.Fees = student.Fees;
                    
                }

                context.SaveChanges();

            }
        }

    }
}
