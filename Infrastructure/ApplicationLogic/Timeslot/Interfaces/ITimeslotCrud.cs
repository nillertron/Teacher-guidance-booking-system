using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Timeslot.Concretes
{
    public interface ITimeslotCrud
    {
        Task Create(Model.Timeslot slot);
    }
}