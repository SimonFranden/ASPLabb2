namespace ASPLabb2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int ClassId { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }

    }
}
