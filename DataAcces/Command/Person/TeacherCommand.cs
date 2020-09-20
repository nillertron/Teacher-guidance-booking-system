using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DataAcces.Command.Person
{
    public class TeacherCommand : CommandRepository<Model.Teacher>, ITeacherCommand
    {
        public TeacherCommand(VejledningsContext context) : base(context)
        {

        }
    }
}
