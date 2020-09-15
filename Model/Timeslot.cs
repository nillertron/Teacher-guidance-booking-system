﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class Timeslot : BaseEntity, IRowVersion
    {
        public Teacher Teacher { get; set; }
        public Calender Calendar { get; set; }
        public Booking Booking { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

       
    }
}
