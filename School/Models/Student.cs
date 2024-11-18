namespace School.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
        public List<Subject> subjects { get; set; }
    }
}
