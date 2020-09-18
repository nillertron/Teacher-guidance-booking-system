using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

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
        public bool AddTimeslot(Timeslot slot)
        {

            if (Timeslots.Any(x => x.StartDateTime - slot.StartDateTime < TimeSpan.FromSeconds(30) && x.StartDateTime - slot.StartDateTime >= TimeSpan.FromSeconds(0)))
                return false;
            if (Timeslots.Any(x => x.StartDateTime - slot.StartDateTime > TimeSpan.FromSeconds(-30) && x.StartDateTime - slot.StartDateTime <= TimeSpan.FromSeconds(0)))
                return false;
                Timeslots.Add(slot);
            return true;
                
        }
    }
}
