using Model;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Cookie.Concretes
{
    public interface ICookieRepository:IRepository<StoredCookie>
    {
        Task<StoredCookie> GetCookieEntityWithUser(string value);
    }
}