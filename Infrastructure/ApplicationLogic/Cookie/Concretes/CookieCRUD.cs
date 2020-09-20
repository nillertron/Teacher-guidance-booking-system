using DataAcces.Command.Cookie;
using DataAcces.Query.Cookie;
using Microsoft.AspNetCore.Http;
using Model;
using System;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Cookie.Concretes
{
    public class CookieCRUD : ICookieCRUD
    {
        private readonly IHttpContextAccessor httpContext;
        private readonly ICookieCommand cookieCommand;
        private readonly ICookieQuery cookieQuery;
        public CookieCRUD(IHttpContextAccessor httpContext, ICookieQuery cookieQuery, ICookieCommand cookieCommand)
        {
            this.httpContext = httpContext;
            this.cookieCommand = cookieCommand;
            this.cookieQuery = cookieQuery;
        }
        public async Task CreateCookie(string key, Model.Person person, int expiredays)
        {
            var options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(expiredays);
            var value = Guid.NewGuid().ToString();
            var dbCookie = new StoredCookie { Value = value, PersonId = person.Id};
            await cookieCommand.Create(dbCookie);
            httpContext.HttpContext.Response.Cookies.Append(key, value, options);
        }
        public async Task<string> GetCookieValue(string key)
        {
            var cookie = httpContext.HttpContext.Request.Cookies[key];
            if (cookie == null)
                return null;
            return cookie;
        }
        public async Task<Model.StoredCookie> GetCookieFromValue(string value)
        {
            return await cookieQuery.GetCookieEntityWithUser(value);
        }
        public async Task DeleteCookie(string key)
        {
            httpContext.HttpContext.Response.Cookies.Delete(key);
        }
    }
}
