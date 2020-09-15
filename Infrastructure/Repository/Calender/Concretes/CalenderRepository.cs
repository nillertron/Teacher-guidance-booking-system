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
            var calender = new Model.Calender();
            await Task.Run(async () =>
            {
                calender = await context.Calenders.Where(x => x.Hold.Contains(hold)).Include(x => x.Timeslots).ThenInclude(x => x.Booking).ThenInclude(x => x.Student).Include(x => x.Timeslots).ThenInclude(x => x.Teacher).FirstOrDefaultAsync();

            });
            return calender;
        }
    }
}
