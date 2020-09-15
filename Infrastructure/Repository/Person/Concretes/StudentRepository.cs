using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Concretes
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(VejledningsContext context) : base(context)
        {

        }
        public async Task<Student> GetStudentWithIncludes(int id)
        {
            return await context.Students.Where(x => x.Id == id).Include(x=>x.HoldLines).ThenInclude(x=>x.Hold).FirstOrDefaultAsync();
        }
    }
}
