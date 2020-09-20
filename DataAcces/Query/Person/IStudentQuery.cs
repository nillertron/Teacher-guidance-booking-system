using Model;
using System.Threading.Tasks;

namespace DataAcces.Query.Person
{
    public interface IStudentQuery:IQueryRepository<Model.Student>
    {
        Task<Student> GetStudentWithFutureBookings(int id);
        Task<Student> GetStudentWithIncludes(int id);
    }
}