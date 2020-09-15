using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class Timeslot : BaseEntity, IRowVersion
    {
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int CalendarId { get; set; }
        public Calender Calendar { get; set; }
        public Booking Booking { get; set; }
        public DateTime StartDateTime { get; set; } = DateTime.Now;

        public DateTime EndDateTime { get; set; } = DateTime.Now;
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public void ValidateDates()
        {
            ValidateDates(StartDateTime, EndDateTime);
            ValdidateTime(StartDateTime);
            ValdidateTime(EndDateTime);

        }
        private void ValdidateTime(DateTime date)
        {
            var minutString = date.ToString("mm");
            if (minutString != "00" && minutString != "30")
                throw new Exception("Minutes must be either 00 or 30");
        }
        private void ValidateDates(DateTime startDateTime, DateTime endDateTIme)
        {
            if (startDateTime < DateTime.Now)
                throw new Exception("Start day must be in the future");
            if (startDateTime > endDateTIme)
                throw new Exception("Start date cannot be greater than end date");
        }
       
    }
}
