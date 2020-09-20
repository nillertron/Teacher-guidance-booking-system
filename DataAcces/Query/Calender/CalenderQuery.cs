using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Query.Calender
{
    public class CalenderQuery : QueryRepository<Model.Calender>, ICalenderQuery
    {
        public CalenderQuery(VejledningsContext context) : base(context)
        {

        }
        public async Task<Model.Calender> GetCalenderWithIncludes(Model.Hold hold)
        {
            var calender = await context.Calenders.Where(x => x.Hold.Contains(hold)).Include(x => x.Timeslots).ThenInclude(x => x.Booking).ThenInclude(x => x.Student).Include(x => x.Timeslots).ThenInclude(x => x.Teacher).Include(x => x.Hold).AsNoTracking().FirstOrDefaultAsync();

            return calender;
        }
        public async Task<Model.Calender> GetCalenderWithIncludes(int id)
        {
            var calender = await context.Calenders.Where(x => x.Id == id).Include(x => x.Timeslots).ThenInclude(x => x.Booking).ThenInclude(x => x.Student).Include(x => x.Timeslots).ThenInclude(x => x.Teacher).Include(x => x.Hold).FirstOrDefaultAsync();

            return calender;
        }
    }
}
