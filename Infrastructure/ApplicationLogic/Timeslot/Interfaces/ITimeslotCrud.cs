using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Timeslot.Concretes
{
    public interface ITimeslotCrud
    {
        Task BookTimeslot(Model.Timeslot timeslot);
    }
}