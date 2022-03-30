using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Models;

namespace TestAPI.Services.Implementations
{
    public class StudentsService : IStudentsService
    {
        private readonly AppDbContext _context;

        public StudentsService(AppDbContext context)
        {
            _context = context;
            _context.ChangeTracker.LazyLoadingEnabled = false;
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync() { return await _context.Students.Include(s => s.Grades).Include(x => x.Subjects).ToListAsync(); }

        public async Task<Student> GetStudentByEmailAsync(string email) { return await _context.Students.Include(x => x.Grades).Include(x => x.Subjects).FirstAsync(x => x.Email == email); }

        public async Task<IEnumerable<Grade>> GetStudentGradesByIdAsync(int id)
        {
            return await _context.Grades.Where(x => x.StudentId == id).Select(x => new Grade()
            {
                SubjectName = x.SubjectName,
                Grade1 = x.Grade1
            }).ToListAsync();
        }
    }
}
