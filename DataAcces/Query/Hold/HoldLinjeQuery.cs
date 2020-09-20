using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Query.Hold
{
    public class HoldLinjeQuery : QueryRepository<Model.HoldLinjer>, IHoldLinjeQuery
    {
        public HoldLinjeQuery(VejledningsContext context) : base(context)
        {

        }
        public async Task<List<Model.HoldLinjer>> GetHoldLinjeListFromPerson(Model.Person person)
        {
            return await context.HoldLinjer.Where(x => x.Person == person).ToListAsync();

        }
    }
}
