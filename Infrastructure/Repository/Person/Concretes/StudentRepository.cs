using Model;
using System;
using System.Collections.Generic;
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
            return await GetSingle(id, (b => b.Bookings), (b => b.HoldLines));
        }
    }
}
