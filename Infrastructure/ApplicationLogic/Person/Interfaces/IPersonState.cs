using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Person.Concretes
{
    public interface IPersonState
    {
        Model.Person person { get; }
        Task AttemptLogin(string username, string password);
        Task<LoginState> GetLoginState();
        Task<PersonType> GetUserType();
    }
}