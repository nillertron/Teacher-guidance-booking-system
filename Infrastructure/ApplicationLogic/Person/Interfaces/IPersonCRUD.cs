using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Person.Concretes
{
    public interface IPersonCRUD
    {
        Task CreatePerson(Model.Person person);
    }
}