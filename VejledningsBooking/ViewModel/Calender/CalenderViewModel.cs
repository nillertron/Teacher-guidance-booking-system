using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VejledningsBooking.ViewModel
{

    public class CalenderViewModel
    {
        public Hold SelectedHold { get; set; }
        public int SelectedHoldId { get; set; }
        public Calender SelectedCalender { get; set; }
        public List<DateTime> Dates { get; set; }
        public List<DateTime> Hours { get; set; }
        public Person SelectedPerson { get; set; }
        public int CurrentWeek { get; set; } = 0;
        public int NextWeek => CurrentWeek+1;
        public int PreviousWeek => CurrentWeek-1;
        public string GetDateFormatted(int index)
        {
            var stringToReturn = Dates[index].Date.ToString("dd-MM-yyyy");
            stringToReturn += "\n";
            stringToReturn += Dates[index].DayOfWeek.ToString();
            return stringToReturn;
        }

        
    }
}
