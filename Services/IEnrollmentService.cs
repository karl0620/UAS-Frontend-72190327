using System.Collections.Generic;
using System.Threading.Tasks;
using UAS.Models;

namespace UAS.Services
{
    public interface IEnrollmentService
    {
        Task<IEnumerable<Enrollment>> GetById(int id);
    }
}