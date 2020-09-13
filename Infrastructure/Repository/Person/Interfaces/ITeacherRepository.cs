using Model;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Concretes
{
    public interface ITeacherRepository:IRepository<Teacher>
    {
        Task<Teacher> GetTeacherWithIncludes(int id);
    }
}