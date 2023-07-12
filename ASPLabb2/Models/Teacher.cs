namespace ASPLabb2.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public List<Course> Courses { get; set; }
    }
}
