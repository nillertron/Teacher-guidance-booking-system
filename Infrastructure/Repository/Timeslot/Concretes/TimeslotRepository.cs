using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class TimeslotRepository : Repository<Timeslot>, ITimeslotRepository
    {
        public TimeslotRepository(VejledningsContext context) : base(context)
        {

        }

        public override async Task Update(Timeslot entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await base.Update(entity);
        }
        public override async Task Delete(Timeslot entity)
        {

            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await base.Delete(entity);
        }

    }
}
