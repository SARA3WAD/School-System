namespace School.Dto
{
    public class StudentDto
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
        public List<SubjectDto> subjectDtos { get; set; }
    }
}
