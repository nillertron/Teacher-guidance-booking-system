using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VejledningsBooking.ViewModel
{
    public class CreateBookingViewModel
    {
        public Booking TheBooking { get; set; } = new Booking();
        public Timeslot TheTimeslot { get; set; } = new Timeslot();
        public Person ThePerson { get; set; }
        public Calender SelectedCalender { get; set; }
        public string dt1 { get; set; }
        public string dt2 { get; set; }
        public Timeslot SearchTimeslotFromid(int id)
        {
            return SelectedCalender.Timeslots.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
