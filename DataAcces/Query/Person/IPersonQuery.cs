using System.Threading.Tasks;

namespace DataAcces.Query.Person
{
    public interface IPersonQuery:IQueryRepository<Model.Person>
    {
        Task<Model.Person> GetPersonFromUserName(string username);
        Task<Model.Person> GetUserFromNameAndPassword(string username, string password);
        Task<bool> PasswordExists(string passWord);
        Task<bool> UserNameExists(string userName);
    }
}