using Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Hold.Concretes
{
    public interface IHoldLinjeRepository:IRepository<HoldLinjer>
    {
        Task<List<HoldLinjer>> GetHoldLinjeListFromPerson(Person person);
    }
}