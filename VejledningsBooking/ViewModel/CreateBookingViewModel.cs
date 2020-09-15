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
    }
}
