using System.Collections.Generic;
using System.Threading.Tasks;
using UAS.Models;

namespace UAS.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> GetById(string id);
        Task<Student> Update(Student obj);
        Task Delete(string id);
        Task<Student> Add(Student obj);
    }
}