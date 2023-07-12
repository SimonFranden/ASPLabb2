using ASPLabb2.Models;

namespace ASPLabb2.ViewModels
{
    public class StudentTeachers
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
