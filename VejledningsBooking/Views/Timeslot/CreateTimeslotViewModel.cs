using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VejledningsBooking.Views.Timeslot
{
    public class CreateTimeslotViewModel
    {
        public Model.Timeslot Timeslot { get; set; } = new Model.Timeslot();
        public int CalenderId { get; set; }
    }
}
