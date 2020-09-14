using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Concretes
{
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(VejledningsContext context) : base(context)
        {

        }
        public async Task<Teacher> GetTeacherWithIncludes(int id)
        {
            return await context.Teachers.Where(x => x.Id == id).Include(x=>x.Timeslots).Include(x => x.HoldLines).ThenInclude(x => x.Hold).FirstOrDefaultAsync();
                
        }
    }
}
