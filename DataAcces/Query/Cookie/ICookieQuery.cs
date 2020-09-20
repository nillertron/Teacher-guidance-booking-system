using Model;
using System.Threading.Tasks;

namespace DataAcces.Query.Cookie
{
    public interface ICookieQuery:IQueryRepository<StoredCookie>
    {
        Task<StoredCookie> GetCookieEntityWithUser(string value);
    }
}