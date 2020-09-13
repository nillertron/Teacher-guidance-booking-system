using Model;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Concretes
{
    public interface IStudentRepository:IRepository<Student>
    {
        Task<Student> GetStudentWithIncludes(int id);
    }
}