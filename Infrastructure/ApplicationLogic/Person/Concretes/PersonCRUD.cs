using DataAcces.Command.Person;
using DataAcces.Query.Person;
using System;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Person.Concretes
{
    public class PersonCRUD : IPersonCRUD
    {
        private readonly IPersonCommand personCommand;
        private readonly IPersonQuery personQuery;

        public PersonCRUD(IPersonCommand personCommand, IPersonQuery personQuery)
        {
            this.personCommand = personCommand;
            this.personQuery = personQuery;
        }
        public async Task CreatePerson(Model.Person person)
        {
            if (await personQuery.UserNameExists(person.Username))
                throw new Exception("Username is taken");
            await personCommand.Create(person);
        }

    }
}
