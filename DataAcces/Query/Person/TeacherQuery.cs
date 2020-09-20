using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DataAcces.Query.Person
{
    public class TeacherQuery : QueryRepository<Model.Teacher>, ITeacherQuery
    {
        public TeacherQuery(VejledningsContext context) : base(context)
        {

        }
        public async Task<Teacher> GetTeacherWithIncludes(int id)
        {
            return await context.Teachers.Where(x => x.Id == id).Include(x => x.Timeslots).Include(x => x.HoldLines).ThenInclude(x => x.Hold).FirstOrDefaultAsync();

        }
        public async Task<Teacher> GetTeacherWithFutureTimeslots(int id)
        {
            return await context.Teachers.Where(x => x.Id == id).Include(x => x.Timeslots.Where(y => y.StartDateTime >= DateTime.Now)).FirstOrDefaultAsync();
        }
    }
}
