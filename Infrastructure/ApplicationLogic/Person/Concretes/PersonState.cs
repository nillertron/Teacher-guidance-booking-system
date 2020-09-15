using Infrastructure.ApplicationLogic.Cookie.Concretes;
using Infrastructure.Repository;
using Infrastructure.Repository.Concretes;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Person.Concretes
{
    public class PersonState : IPersonState
    {
        private bool IsLoggedIn = false;
        private readonly IPersonRepository personRepository;
        public Model.Person person { get; private set; }
        private readonly ICookieCRUD cookieCRUD;
        private readonly ITeacherRepository teacherRepository;
        private readonly IStudentRepository studentRepository;
        public PersonState(IPersonRepository personRepository, ICookieCRUD cookieCrud, ITeacherRepository teacherRepo, IStudentRepository studenRepo)
        {
            this.personRepository = personRepository;
            this.cookieCRUD = cookieCrud;
            this.teacherRepository = teacherRepo;
            this.studentRepository = studenRepo;
            CheckForCookie();
        }
        private async Task CheckForCookie()
        {
            var cookieValue = await cookieCRUD.GetCookieValue("login");
            if(cookieValue!=null)
            {
                var cookie = await cookieCRUD.GetCookieFromValue(cookieValue);
                person = cookie.Person;
                await GetAttachedEntities();

            }
        }
        public async Task AttemptLogin(string username, string password)
        {
            this.person = await personRepository.GetUserFromNameAndPassword(username, password);
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
                try
                {
                    person = await studentRepository.GetStudentWithIncludes(person.Id);

                }
                catch (Exception ex)
                {

                    
                }
            }
            else if(type == PersonType.Teacher)
            {
                person = await teacherRepository.GetTeacherWithIncludes(person.Id);
            }
        }
        public async Task<LoginState> GetLoginState()
        {
            if (person != null)
                return LoginState.LoggedIn;
            else
                return LoginState.LoggedOff;
        }
        public async Task<PersonType> GetUserType()
        {
            if (person.GetType() == typeof(Model.Teacher))
                return PersonType.Teacher;
            else
                return PersonType.Student;
        }
    }
}
