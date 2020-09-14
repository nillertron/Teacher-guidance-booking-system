using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Calender.Concretes
{
    public interface ICalenderDateManager
    {
        Task<List<DateTime>> Get5Weekdays(DateTime weekToGetDays);
        Task<List<DateTime>> GetDailyHourTimes();
    }
}