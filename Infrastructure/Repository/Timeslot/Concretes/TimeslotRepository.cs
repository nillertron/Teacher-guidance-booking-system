using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class TimeslotRepository : Repository<Timeslot>, ITimeslotRepository
    {
        public TimeslotRepository(VejledningsContext context) : base(context)
        {

        }
        public async Task<Timeslot> GetWithIncludes(int id)
        {
            return await context.Timeslots.Where(x => x.Id == id).Include(x => x.Booking).Include(x => x.Teacher).Include(x => x.Calendar).FirstOrDefaultAsync();
        }
        public override async Task Update(Timeslot entity)
        {
            context.Entry(entity).State = EntityState.Modified;

            try
            {
                context.Timeslots.Update(entity);
                await context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw;
            }

        }

    }
}
