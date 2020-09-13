using Model;
using System;
using System.Collections.Generic;
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
            return await GetSingle(id, (b => b.Timeslots), (b => b.HoldLines));
        }
    }
}
