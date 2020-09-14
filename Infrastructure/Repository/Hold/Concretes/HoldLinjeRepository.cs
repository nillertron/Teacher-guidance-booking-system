using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Hold.Concretes
{
   public class HoldLinjeRepository : Repository<Model.HoldLinjer>, IHoldLinjeRepository
    {
        public HoldLinjeRepository(VejledningsContext context) : base(context)
        {

        }
        public async Task<List<Model.HoldLinjer>> GetHoldLinjeListFromPerson(Model.Person person)
        {
            return await context.HoldLinjer.Where(x => x.Person == person).ToListAsync();

        }
    }
}
