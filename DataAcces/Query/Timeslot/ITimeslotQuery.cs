using System.Threading.Tasks;

namespace DataAcces.Query.Timeslot
{
    public interface ITimeslotQuery:IQueryRepository<Model.Timeslot>
    {
        Task<Model.Timeslot> GetWithIncludes(int id);
    }
}