using Microsoft.VisualBasic;

namespace StudentsRegistration.Models
{
    public class Student
    {

        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Mobno { get; set; }

        public string? Address { get; set; }

        public DateTime AdmDate { get; set; }

        public double Fees { get; set; }

        public string? status { get; set; }

        public Student() { }
        public Student(string name, string email, string mobno, string address, DateTime admdate, double fees, string status)
        {
            Name = name;
            Email = email;
            Mobno = mobno;
            Address = address;
            this.AdmDate = admdate;
            this.Fees = fees;
            this.status = status;
        }

        public Student(int id, string name, string email, string mobno, string address, DateTime admdate, double fees, string status)
        {
            this.Id = id;
            Name = name;
            Email = email;
            Mobno = mobno;
            Address = address;
            this.AdmDate = admdate;
            this.Fees = fees;
            this.status = status;
        }

       


    }
}
