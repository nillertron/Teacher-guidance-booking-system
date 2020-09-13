using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Person.Concretes
{
    public class PersonCRUD : IPersonCRUD
    {
        private readonly IPersonRepository repository;
        public PersonCRUD(IPersonRepository repo)
        {
            this.repository = repo;
        }
        public async Task CreatePerson(Model.Person person)
        {
            if (await repository.UserNameExists(person.Username))
                throw new Exception("Username is taken");
            await repository.Create(person);
        }

    }
}
