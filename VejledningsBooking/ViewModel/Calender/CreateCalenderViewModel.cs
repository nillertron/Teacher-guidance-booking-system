using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VejledningsBooking.ViewModel
{
    public class CreateCalenderViewModel
    {
        public Calender Calender { get; set; }
        public List<Hold> HoldList { get; set; }

        public List<int> SelectedIndicies { get; set; }
    }
}
