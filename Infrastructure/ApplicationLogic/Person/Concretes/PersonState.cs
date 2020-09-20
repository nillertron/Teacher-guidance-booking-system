using DataAcces.Command.Person;
using DataAcces.Query.Person;
using Infrastructure.ApplicationLogic.Cookie.Concretes;
using System;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Person.Concretes
{
    public class PersonState : IPersonState
    {
        private readonly IPersonCommand personCommand;
        private readonly IPersonQuery personQuery;
        private readonly ITeacherCommand teacherCommand;
        private readonly ITeacherQuery teacherQuery;
        private readonly IStudentCommand studentCommand;
        private readonly IStudentQuery studentQuery;
        private readonly ICookieCRUD cookieCRUD;

        private Model.Person person;

        private bool FirstRender = true;
        public PersonState(ICookieCRUD cookieCrud, IPersonCommand personCommand, IPersonQuery personQuery, ITeacherQuery teacherQuery, ITeacherCommand teacherCommand, IStudentQuery studentQuery, IStudentCommand studentCommand)
        {
            this.cookieCRUD = cookieCrud;
            this.personQuery = personQuery;
            this.personCommand = personCommand;
            this.teacherCommand = teacherCommand;
            this.teacherQuery = teacherQuery;
            this.studentCommand = studentCommand;
            this.studentQuery = studentQuery;
        }
        public async Task<Model.Person> GetPersonAsync()
        {
            if(person == null)
            {
                await CheckForCookie(true);
                if (person == null)
                    throw new Exception("Person not logged in");

            }
            return person;

        }
        public async Task<int> GetPersonIdAsync()
        {
            if(person == null)
            {
                await CheckForCookie(false);
                if (person == null)
                    throw new Exception("Person not logged in");
            }
            return person.Id;
        }
        private async Task CheckForCookie(bool getAttachedEntities)
        {
            var cookieValue = await cookieCRUD.GetCookieValue("login");
            if(cookieValue!=null)
            {
                var cookie = await cookieCRUD.GetCookieFromValue(cookieValue);
                person = cookie.Person;
                if(getAttachedEntities)
                await GetAttachedEntities();
                FirstRender = false;
            }
        }
        public async Task AttemptLogin(string username, string password)
        {
            this.person = await personQuery.GetUserFromNameAndPassword(username, password);
            if (this.person == null)
                throw new Exception("Credentials failed");
            else
            {
                await cookieCRUD.CreateCookie("login", this.person, 30);
                await GetAttachedEntities();
            }
        }
        private async Task GetAttachedEntities()
        {
            var type = await GetUserType();
            if(type == PersonType.Student)
            {
                    person = await studentQuery.GetStudentWithIncludes(person.Id);


            }
            else if(type == PersonType.Teacher)
            {
                person = await teacherQuery.GetTeacherWithIncludes(person.Id);
            }
        }
        public async Task<LoginState> GetLoginState()
        {
            await CheckForCookie(true);
            if (person != null)
                return LoginState.LoggedIn;
            else
                return LoginState.LoggedOff;
        }
        public async Task<PersonType> GetUserType()
        {
            if (FirstRender)
            {
                FirstRender = false;
                await CheckForCookie(true);
            }
            if (person != null)
            {
                if (person.GetType() == typeof(Model.Teacher))
                    return PersonType.Teacher;
                else
                    return PersonType.Student;
            }
            else throw new Exception("Not logged in");

        }
        public async Task LogOff()
        {
            await CheckForCookie(false);
            if(person != null)
            {
                await cookieCRUD.DeleteCookie("login");
            }
        }
    }
}
