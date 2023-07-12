namespace ASPLabb2.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }

    }
}
