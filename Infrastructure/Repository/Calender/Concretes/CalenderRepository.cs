using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Calender.Concretes
{
    public class CalenderRepository : Repository<Model.Calender>, ICalenderRepository
    {
        public CalenderRepository(VejledningsContext context) : base(context)
        {

        }
        public async Task<Model.Calender> GetCalenderWithIncludes(Model.Hold hold)
        {
             var calender = await context.Calenders.Where(x => x.Hold.Contains(hold)).Include(x => x.Timeslots).ThenInclude(x => x.Booking).ThenInclude(x=>x.Student).Include(x=>x.Timeslots).ThenInclude(x=>x.Teacher).Include(x=>x.Hold).AsNoTracking().FirstOrDefaultAsync();
           
            if(calender != null)
            {
                foreach (var ts in calender.Timeslots)
                {
                    context.Entry(ts).Property("RowVersion").OriginalValue = ts.RowVersion;

                }
            }

            return calender;
        }
        public async Task<Model.Calender> GetCalenderWithIncludes(int id)
        {
            var calender = await context.Calenders.Where(x => x.Id == id).Include(x => x.Timeslots).ThenInclude(x => x.Booking).ThenInclude(x => x.Student).Include(x => x.Timeslots).ThenInclude(x => x.Teacher).Include(x => x.Hold).AsNoTracking().FirstOrDefaultAsync();
            if (calender != null)
            {
                foreach (var ts in calender.Timeslots)
                {
                    context.Entry(ts).Property("RowVersion").OriginalValue = ts.RowVersion;

                }
            }

            return calender;
        }
    }
}
