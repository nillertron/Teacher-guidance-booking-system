using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(VejledningsContext context) : base(context)
        {

        }
        public async Task<bool> UserNameExists(string userName)
        {
            return await table.AnyAsync(x => x.Username.ToLower() == userName.ToLower());
        }
        public async Task<bool> PasswordExists(string passWord)
        {
            return await table.AnyAsync(x => x.Password.ToLower() == passWord.ToLower());
        }
        public async Task<Person> GetUserFromNameAndPassword(string username, string password)
        {
            return table.Where(x => x.Username.ToLower() == username.ToLower() && x.Password.ToLower() == password.ToLower()).FirstOrDefault();
        }
        public async Task<Person> GetPersonFromUserName(string username)
        {
            return table.Where(x => x.Username.ToLower() == username.ToLower()).FirstOrDefault();
        }
    }
}
