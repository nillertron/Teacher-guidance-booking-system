using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAcces.Query.Hold
{
    public interface IHoldQuery:IQueryRepository<Model.Hold>
    {
        Task<List<Model.Hold>> GetAllHoldWithoutSchema();
        Task<Model.Hold> GetHoldWithIncludes(int id);
    }
}