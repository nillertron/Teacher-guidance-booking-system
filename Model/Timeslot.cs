using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class Timeslot : BaseEntity
    {
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int CalendarId { get; set; }
        public Calender Calendar { get; set; }
        public int? BookingId { get; set; } = null;
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
        public void RemoveSeconds()
        {
            StartDateTime = new DateTime(StartDateTime.Year, StartDateTime.Month, StartDateTime.Day, StartDateTime.Hour, StartDateTime.Minute, 0);
            EndDateTime = new DateTime(EndDateTime.Year, EndDateTime.Month, EndDateTime.Day, EndDateTime.Hour, EndDateTime.Minute, 0);
        }
        public List<Timeslot> DetermineSingleOrCollectionTimeslots()
        {
            var slotList = new List<Timeslot>();
            var timeDif =  EndDateTime - StartDateTime;
            if (timeDif > TimeSpan.FromMinutes(31))
            {
                var amountOfSlots = timeDif / TimeSpan.FromMinutes(30);
                var initStartTime = StartDateTime;
                var initEndTime = StartDateTime + TimeSpan.FromMinutes(30);
                for (int i = 0; i < amountOfSlots; i++)
                {
                    var slot = CreateTimeslot(initStartTime, initEndTime);
                    if(DetermineIfTimeslotTimeIsVaild(slot) && !IsWeekend(slot))
                    {
                        slotList.Add(slot);

                    }
                    initStartTime += TimeSpan.FromMinutes(30);
                    initEndTime += TimeSpan.FromMinutes(30);
                }
            }
            else
            {
                slotList.Add(this);
            }
            return slotList;
        }
        private Timeslot CreateTimeslot(DateTime startDate, DateTime endDate)
        {
            return new Timeslot { StartDateTime = startDate, EndDateTime = endDate, CalendarId = this.CalendarId, TeacherId = this.TeacherId };
        }
        private bool DetermineIfTimeslotTimeIsVaild(Timeslot slot)
        {
            var maxTime = new DateTime(1, 1, 1, 15, 31, 00);
            var minTime = new DateTime(1, 1, 1, 07, 59, 00);
            if (slot.StartDateTime.TimeOfDay < maxTime.TimeOfDay && slot.StartDateTime.TimeOfDay > minTime.TimeOfDay)
                return true;
            else
                return false;
        }
        private bool IsWeekend(Timeslot slot)
        {
            if (slot.StartDateTime.DayOfWeek == DayOfWeek.Saturday || slot.StartDateTime.DayOfWeek == DayOfWeek.Sunday)
                return true;
            return false;
        }
    }
}
