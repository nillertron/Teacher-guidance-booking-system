using System;
using System.Collections.Generic;
using System.Text;
public enum PersonType
{
    Student,
    Teacher
}
public enum LoginState
{
    LoggedOff,
    LoggedIn
}
namespace Model
{

    public abstract class Person:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<HoldLinjer> HoldLines { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Person()
        {
            HoldLines = new List<HoldLinjer>();
        }
    }
}
