using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Booking : BaseEntity
    {
        public Student Student { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

    }
}
