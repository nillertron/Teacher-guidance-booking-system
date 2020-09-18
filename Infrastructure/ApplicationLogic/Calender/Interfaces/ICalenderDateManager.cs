using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Calender.Concretes
{
    public interface ICalenderDateManager
    {
        DateTime CurrentDisplayWeek { get; }

        Task<DateTime> Add7DaysAndGetDate();
        Task<List<DateTime>> Get5Weekdays(DateTime weekToGetDays);
        Task<List<DateTime>> GetDailyHourTimes();
        Task<DateTime> Subtract7DaysAndGetDate();
    }
}