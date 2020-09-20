using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DataAcces.Query.Person
{
    public class StudentQuery : QueryRepository<Model.Student>, IStudentQuery
    {
        public StudentQuery(VejledningsContext context) : base(context)
        {

        }
        public async Task<Student> GetStudentWithIncludes(int id)
        {
            return await context.Students.Where(x => x.Id == id).Include(x => x.HoldLines).ThenInclude(x => x.Hold).Include(x => x.Bookings).FirstOrDefaultAsync();
        }
        public async Task<Student> GetStudentWithFutureBookings(int id)
        {
            return await context.Students.Where(x => x.Id == id).Include(x => x.Bookings.Where(x => x.StartDateTime >= DateTime.Now)).FirstOrDefaultAsync();
        }
    }
}
