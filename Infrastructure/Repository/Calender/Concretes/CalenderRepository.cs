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
            return await context.Calenders.Where(x => x.Hold.Contains(hold)).Include(x => x.Timeslots).ThenInclude(x => x.Booking).ThenInclude(x=>x.Student).Include(x=>x.Timeslots).ThenInclude(x=>x.Teacher).Include(x=>x.Hold).FirstOrDefaultAsync();
        }
        public async Task<Model.Calender> GetCalenderWithIncludes(int id)
        {
            return await context.Calenders.Where(x => x.Id == id).Include(x => x.Timeslots).ThenInclude(x => x.Booking).ThenInclude(x => x.Student).Include(x => x.Timeslots).ThenInclude(x => x.Teacher).Include(x => x.Hold).FirstOrDefaultAsync();
        }
    }
}
