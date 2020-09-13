using Model;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Cookie.Concretes
{
    public interface ICookieCRUD
    {
        Task CreateCookie(string key, Model.Person person, int expiredays);
        Task DeleteCookie(string key);
        Task<StoredCookie> GetCookieFromValue(string value);
        Task<string> GetCookieValue(string key);
    }
}