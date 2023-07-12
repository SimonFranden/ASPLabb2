using ASPLabb2.Models;
using Microsoft.EntityFrameworkCore;
using ASPLabb2.ViewModels;

namespace ASPLabb2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder
            .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ASPLabb2DB;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true");

        public DbSet<Class> Classes => Set<Class>();
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Teacher> Teachers => Set<Teacher>();
        public DbSet<StudentCourse> StudentCourses => Set<StudentCourse>();




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>().HasData(
                new Class { Id = 1, ClassName = "1A"},
                new Class { Id = 2, ClassName = "2B" },
                new Class { Id = 3, ClassName = "3B" },
                new Class { Id = 4, ClassName = "1B" },
                new Class { Id = 5, ClassName = "2B" },
                new Class { Id = 6, ClassName = "3B" }
            );

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { Id = 1, FName = "Elon", LName = "Musk" },
                new Teacher { Id = 2, FName = "Bill", LName = "Gates" },
                new Teacher { Id = 3, FName = "Mark", LName = "Zuckerberg" },
                new Teacher { Id = 4, FName = "Reidar", LName = "Nilsen" },
                new Teacher { Id = 5, FName = "Tobias", LName = "Landén" }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, CourseName = "Programmering 1", TeacherId = 4 },
                new Course { Id = 2, CourseName = "Matte", TeacherId = 2 },
                new Course { Id = 3, CourseName = "Programmering 2", TeacherId = 3 }

            );

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, FName = "Sven", LName = "Svensson", ClassId = 1},
                new Student { Id = 2, FName = "Olof", LName = "Olofsson", ClassId = 1 },
                new Student { Id = 3, FName = "Sten", LName = "Stensson", ClassId = 4 },
                new Student { Id = 4, FName = "Gustaf", LName = "Gustafsson", ClassId = 4},
                new Student { Id = 5, FName = "Clark", LName = "Olofsson", ClassId = 4}
            );

            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne(s => s.Student)
                .WithMany(sc => sc.StudentCourses)
                .HasForeignKey(s => s.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(c => c.Course)
                .WithMany(sc => sc.StudentCourses)
                .HasForeignKey(c => c.CourseId);

            modelBuilder.Entity<StudentCourse>().HasData(
                new StudentCourse { StudentId = 1, CourseId = 1},
                new StudentCourse { StudentId = 1, CourseId = 2 },
                new StudentCourse { StudentId = 1, CourseId = 3 },
                new StudentCourse { StudentId = 2, CourseId = 2 },
                new StudentCourse { StudentId = 2, CourseId = 3 },
                new StudentCourse { StudentId = 3, CourseId = 1 },
                new StudentCourse { StudentId = 3, CourseId = 2 },
                new StudentCourse { StudentId = 3, CourseId = 3 },
                new StudentCourse { StudentId = 4, CourseId = 2 },
                new StudentCourse { StudentId = 4, CourseId = 3 },
                new StudentCourse { StudentId = 5, CourseId = 1 },
                new StudentCourse { StudentId = 5, CourseId = 3 }

            );

        }





        



        
    }
}
