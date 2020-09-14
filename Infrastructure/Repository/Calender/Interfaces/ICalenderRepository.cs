using System.Threading.Tasks;

namespace Infrastructure.Repository.Calender.Concretes
{
    public interface ICalenderRepository:IRepository<Model.Calender>
    {
        Task<Model.Calender> GetCalenderWithIncludes(Model.Hold hold);
    }
}