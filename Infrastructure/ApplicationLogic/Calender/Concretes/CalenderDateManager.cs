using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Calender.Concretes
{
    public class CalenderDateManager : ICalenderDateManager
    {
        public async Task<List<DateTime>> Get5Weekdays(DateTime weekToGetDays)
        {
            var monday = await FindMondayInWeek(weekToGetDays);
            return await Produce5Days(monday);
        }
        private async Task<DateTime> FindMondayInWeek(DateTime weekDate)
        {
            if (weekDate.DayOfWeek == DayOfWeek.Monday)
            {
                return weekDate;
            }
            else
            {
                for (int i = 0; i < 6; i++)
                {
                    weekDate = weekDate.AddDays(-1);
                    if (weekDate.DayOfWeek == DayOfWeek.Monday)
                    {
                        return weekDate;
                    }
                }
            }
            throw new IndexOutOfRangeException("Could not find monday :(");
        }
        private async Task<List<DateTime>> Produce5Days(DateTime startDate)
        {
            var list = new List<DateTime>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(startDate.AddDays(i));
            }
            return list;
        }

        public async Task<List<DateTime>> GetDailyHourTimes()
        {
            var list = new List<DateTime>();
            var init = Convert.ToDateTime("08:00:00 AM");
            list.Add(init);
            for(int i = 0; i<15; i++)
            {
                init = init.AddMinutes(30);
                list.Add(init);
            }
            return list;
        }
    }
}
