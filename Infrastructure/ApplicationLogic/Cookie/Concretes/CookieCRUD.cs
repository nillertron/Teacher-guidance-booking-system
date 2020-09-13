using Infrastructure.Repository;
using Infrastructure.Repository.Cookie.Concretes;
using Microsoft.AspNetCore.Http;
using Model;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Cookie.Concretes
{
    public class CookieCRUD : ICookieCRUD
    {
        private readonly IHttpContextAccessor httpContext;
        private readonly ICookieRepository cookieRepo;
        public CookieCRUD(IHttpContextAccessor httpContext, ICookieRepository cookieRepo)
        {
            this.httpContext = httpContext;
            this.cookieRepo = cookieRepo;
        }
        public async Task CreateCookie(string key, Model.Person person, int expiredays)
        {
            var options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(expiredays);
            var value = Guid.NewGuid().ToString();
            var dbCookie = new StoredCookie { Value = value, Person = person };
            await cookieRepo.Create(dbCookie);
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
            return await cookieRepo.GetCookieEntityWithUser(value);
        }
        public async Task DeleteCookie(string key)
        {
            httpContext.HttpContext.Response.Cookies.Delete(key);
        }
    }
}
