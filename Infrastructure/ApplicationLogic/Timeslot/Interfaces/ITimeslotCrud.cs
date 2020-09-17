using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Timeslot.Concretes
{
    public interface ITimeslotCrud
    {
        Task Create(Model.Timeslot slot);
        Task<Model.Timeslot> GetFromId(int id);
    }
}