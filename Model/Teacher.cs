using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Teacher:Person
    {
        public string Speciality { get; set; }
        public List<Timeslot> Timeslots { get; set; }
        public Teacher()
        {
            Timeslots = new List<Timeslot>();
        }
    }
}
