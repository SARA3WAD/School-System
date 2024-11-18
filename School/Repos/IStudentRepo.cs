using School.Dto;

namespace School.Repos
{
    public interface IStudentRepo
    {
        public void AddStudent(StudentDto student);
        public void AddStudentSubject(StudentDto student);
        public List<StudentDto> GetAllStudentwithSubject();
        public StudentDto GetById(int id);

    }
}
