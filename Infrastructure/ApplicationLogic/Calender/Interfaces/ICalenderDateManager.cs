using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Calender.Concretes
{
    public interface ICalenderDateManager
    {
        Task<DateTime> Add7DaysAndGetDate(int howManyWeeksToAdd);
        Task<List<DateTime>> Get5Weekdays(DateTime weekToGetDays);
        Task<List<DateTime>> GetDailyHourTimes();
        Task<DateTime> Subtract7DaysAndGetDate(int howManyWeeksToSubtract);
    }
}