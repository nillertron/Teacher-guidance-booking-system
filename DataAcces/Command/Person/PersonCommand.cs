namespace DataAcces.Command.Person
{
    public class PersonCommand : CommandRepository<Model.Person>, IPersonCommand
    {
        public PersonCommand(VejledningsContext context) : base(context)
        {

        }

    }
}
