using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Calender.Concretes
{
    public interface ICalenderCRUD
    {
        Task Create(Model.Calender model);
        Task<Model.Calender> Get(Model.Hold hold);
        Task<List<Model.Calender>> GetAll();
    }
}