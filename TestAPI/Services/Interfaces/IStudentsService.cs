using System.Collections.Generic;
using System.Threading.Tasks;
using TestAPI.Models;

namespace TestAPI.Services.Implementations
{
    public interface IStudentsService
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task<Student> GetStudentByEmailAsync(string email);
        Task<IEnumerable<Grade>> GetStudentGradesByIdAsync(int id);
    }
}