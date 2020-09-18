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
        public async Task UpdateWithConcurrencyCheck(Timeslot entity)
        {
           var result = context.Database.ExecuteSqlRaw("Update Timeslots set BookingId = {0} where Id = {1} AND RowVersion = {2}", entity.BookingId, entity.Id, entity.RowVersion);
            if (result < 1)
                throw new Exception("Concurrency exception");
        }



    }
}
