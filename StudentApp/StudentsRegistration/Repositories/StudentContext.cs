using Microsoft.EntityFrameworkCore;
using StudentsRegistration.Models;

namespace StudentsRegistration.Repositories
{
    public class StudentContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string db = @"server=localhost;port=3306;username=root;password=root;database=cdac24";
            optionsBuilder.UseMySQL(db);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>(entity=>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Mobno).IsRequired();
                entity.Property(e => e.Address).IsRequired();
                entity.Property(e => e.AdmDate).IsRequired();
                entity.Property(e => e.Fees).IsRequired();
                entity.Property(e => e.status).IsRequired();
            });

            modelBuilder.Entity<Student>().ToTable("students");

        }
    }
}
