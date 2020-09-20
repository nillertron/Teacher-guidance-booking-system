using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Query.Cookie
{
    public class CookieQuery : QueryRepository<Model.StoredCookie>, ICookieQuery
    {
        public CookieQuery(VejledningsContext context) : base(context)
        {

        }
        public async Task<StoredCookie> GetCookieEntityWithUser(string value)
        {
            return table.Where(x => x.Value == value).Include(x => x.Person).FirstOrDefault();

        }
    }
}
