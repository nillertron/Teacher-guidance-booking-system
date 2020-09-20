using System.Threading.Tasks;

namespace DataAcces.Query.Calender
{
    public interface ICalenderQuery:IQueryRepository<Model.Calender>
    {
        Task<Model.Calender> GetCalenderWithIncludes(Model.Hold hold);
        Task<Model.Calender> GetCalenderWithIncludes(int id);
    }
}