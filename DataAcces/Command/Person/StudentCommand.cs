namespace DataAcces.Command.Person
{
    public class StudentCommand : CommandRepository<Model.Student>, IStudentCommand
    {
        public StudentCommand(VejledningsContext context) : base(context)
        {

        }
    }
}
