using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Hold.Concretes
{
    public class HoldRepository : Repository<Model.Hold>, IHoldRepository
    {
        public HoldRepository(VejledningsContext context) : base(context)
        {

        }
        public async Task<Model.Hold> GetHoldWithIncludes(int id)
        {
            return await context.Hold.Where(x => x.Id == id).Include(x => x.HoldLinjer).ThenInclude(x => x.Person).FirstOrDefaultAsync();
        }
    }
}
