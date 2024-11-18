using Microsoft.EntityFrameworkCore;
using School.Dto;
using School.Models;

namespace School.Repos
{
    public class StudentRepo:IStudentRepo
    {
        private readonly AppDbContextL _context;

        public StudentRepo(AppDbContextL context)
        {
            _context = context;
        }
        public void AddStudent(StudentDto student)
        {
            Student s1 = new Student
            {
                StudentName = student.StudentName,
                StudentAge = student.StudentAge
            };
            _context.students.Add(s1);
            _context.SaveChanges();
        }
        public void AddStudentSubject(StudentDto student)
        {
            Student s1 = new Student
            {
                StudentName = student.StudentName,
                StudentAge = student.StudentAge,
                subjects = student.subjectDtos.Select(i => new Subject
                {
                    SubjectName = i.SubjectName
                }).ToList()
            };
            _context.students.Add(s1);
            _context.SaveChanges();
        }
        public List<StudentDto> GetAllStudentwithSubject()
        {
            var s = _context.students.Include(i => i.subjects).Select(i => new StudentDto
            {
                StudentName = i.StudentName,
                StudentAge = i.StudentAge,
                subjectDtos = i.subjects.Select(i => new SubjectDto
                {
                    SubjectName = i.SubjectName
                }).ToList(),
            }).ToList();
            return s;
            
        }
        public StudentDto GetById(int id)
        {
            var s = _context.students.Include(i => i.subjects).FirstOrDefault(i => i.StudentId == id);
            return new StudentDto
            {
                StudentName = s.StudentName,
                StudentAge = s.StudentAge,
                subjectDtos = s.subjects.Select(i => new SubjectDto
                {
                    SubjectName = i.SubjectName
                }).ToList()


            };
        }
    }
}
