using Model;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface IPersonRepository:IRepository<Person>
    {
        Task<bool> PasswordExists(string passWord);
        Task<bool> UserNameExists(string userName);
        Task<Person> GetUserFromNameAndPassword(string username, string password);
        Task<Person> GetPersonFromUserName(string username);
    }
}