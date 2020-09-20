using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DataAcces.Query.Timeslot
{
    public class TimeslotQuery : QueryRepository<Model.Timeslot>, ITimeslotQuery
    {
        public TimeslotQuery(VejledningsContext context) : base(context)
        {

        }
        public async Task<Model.Timeslot> GetWithIncludes(int id)
        {
            return await context.Timeslots.Where(x => x.Id == id).Include(x => x.Booking).Include(x => x.Teacher).Include(x => x.Calendar).FirstOrDefaultAsync();
        }

    }
}
