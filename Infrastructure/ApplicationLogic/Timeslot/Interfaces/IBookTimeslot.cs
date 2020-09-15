using Model;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Timeslot.Concretes
{
    public interface IBookTimeslot
    {
        Task TryBookTimeslot(Model.Timeslot timeslot, Booking booking);
    }
}