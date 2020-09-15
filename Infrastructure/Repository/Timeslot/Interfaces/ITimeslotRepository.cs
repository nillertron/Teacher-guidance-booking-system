using Model;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface ITimeslotRepository:IRepository<Timeslot>
    {
        Task Delete(Timeslot entity);
        Task Update(Timeslot entity);
    }
}