using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Dto;
using School.Repos;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectRepo _repo;
        public SubjectController(ISubjectRepo repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult AddSubject(SubjectDto subject)
        {
            _repo.AddSubject(subject);
            return Ok();
        }
    }
}
