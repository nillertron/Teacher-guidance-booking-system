using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Hold.Concretes
{
    public interface IHoldCRUD
    {
        Task<List<Model.Hold>> GetAllHold();
        Task<List<Model.Hold>> GetAllHoldForPerson(Model.Person person);
        Task<Model.Hold> GetHoldFromId(int id);
        Task<List<Model.Hold>> GetHoldWithoutSchema();


    }
}