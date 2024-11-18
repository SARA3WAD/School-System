using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Dto;
using School.Repos;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo _repo;

        public StudentController(IStudentRepo repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult AddStudent(StudentDto student)
        {
            _repo.AddStudent(student);
            return Ok();
        }
        [HttpPost("Add Subject From Student")]
        public IActionResult AddStudentSubject(StudentDto student)
        {
            _repo.AddStudentSubject(student);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAllStudentwithSubject()
        {
            var s = _repo.GetAllStudentwithSubject();
            return Ok(s);
        }
        [HttpGet("Get By id")]
        public IActionResult GetById(int id)
        {
            var s = _repo.GetById(id);
            return Ok(s);
        }

    }
}
