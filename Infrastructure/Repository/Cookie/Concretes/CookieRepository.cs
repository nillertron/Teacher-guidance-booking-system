using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Cookie.Concretes
{
    public class CookieRepository : Repository<StoredCookie>, ICookieRepository
    {
        public CookieRepository(VejledningsContext context) : base(context)
        {

        }
        public async Task<StoredCookie> GetCookieEntityWithUser(string value)
        {
            var cookie = new Model.StoredCookie();
            await Task.Run(async () =>
            {
            cookie = table.Where(x => x.Value == value).Include(x => x.Person).FirstOrDefault();

            });
            return cookie;
        }
    }
}
