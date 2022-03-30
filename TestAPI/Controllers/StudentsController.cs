using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestAPI.Models;
using TestAPI.Services.Implementations;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsService _studentsService;

        public StudentsController(IStudentsService studentsService)
        {
            _studentsService = studentsService;
        }

        [HttpGet("")]
        public async Task<IEnumerable<Student>> GetAllStudents() { return await _studentsService.GetAllStudentsAsync(); }

        [HttpGet("{email}")]
        public async Task<Student> GetStudentByEmail(string email) { return await _studentsService.GetStudentByEmailAsync(email); }

        [HttpGet("{id:int}")]
        public async Task<IEnumerable<Grade>> GetStudentGradesByIdAsync(int id) { return await _studentsService.GetStudentGradesByIdAsync(id); }

    }
}
