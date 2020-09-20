using System.Threading.Tasks;

namespace DataAcces.Command.Timeslot
{
    public interface ITimeslotCommand:ICommandRepository<Model.Timeslot>
    {
        Task UpdateWithConcurrencyCheck(Model.Timeslot entity);
    }
}