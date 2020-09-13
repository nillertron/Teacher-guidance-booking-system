using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Calender : BaseEntity
    {
        public List<Hold> Hold { get; set; }
        public List<Timeslot> Timeslots { get; set; }
        public Calender()
        {
            Hold = new List<Hold>();
            Timeslots = new List<Timeslot>();
        }
    }
}
