using Model;
using System.Threading.Tasks;

namespace DataAcces.Query.Person
{
    public interface ITeacherQuery:IQueryRepository<Model.Teacher>
    {
        Task<Teacher> GetTeacherWithFutureTimeslots(int id);
        Task<Teacher> GetTeacherWithIncludes(int id);
    }
}