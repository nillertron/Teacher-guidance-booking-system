using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Query.Hold
{
    public class HoldQuery : QueryRepository<Model.Hold>, IHoldQuery
    {
        public HoldQuery(VejledningsContext context) : base(context)
        {

        }
        public async Task<Model.Hold> GetHoldWithIncludes(int id)
        {
            return await context.Hold.Where(x => x.Id == id).Include(x => x.HoldLinjer).ThenInclude(x => x.Person).FirstOrDefaultAsync();
        }
        public async Task<List<Model.Hold>> GetAllHoldWithoutSchema()
        {
            return await context.Hold.Where(x => x.Calender == null).ToListAsync();
        }
    }
}
