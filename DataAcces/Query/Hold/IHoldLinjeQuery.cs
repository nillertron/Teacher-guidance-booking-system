using Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAcces.Query.Hold
{
    public interface IHoldLinjeQuery:IQueryRepository<Model.HoldLinjer>
    {
        Task<List<HoldLinjer>> GetHoldLinjeListFromPerson(Model.Person person);
    }
}