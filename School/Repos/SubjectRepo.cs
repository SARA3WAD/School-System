using School.Dto;
using School.Models;

namespace School.Repos
{
    // sara
    public class SubjectRepo:ISubjectRepo
    {
        private readonly AppDbContextL _context;

        public SubjectRepo(AppDbContextL context)
        {
            _context = context;
        }
        public void AddSubject(SubjectDto subject)
        {
            Subject s1 = new Subject
            {
                SubjectName = subject.SubjectName
            };
            _context.subjects.Add(s1);
            _context.SaveChanges();
        } 
    }
}
