using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Person.Concretes
{
    public interface IPersonState
    {
        Task AttemptLogin(string username, string password);
        Task<LoginState> GetLoginState();
        Task<PersonType> GetUserType();
        Task<Model.Person> GetPersonAsync();
        Task LogOff();
    }
}