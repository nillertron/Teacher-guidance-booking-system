using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Student:Person
    {
        public readonly List<Booking> Bookings;
        public Student()
        {
            Bookings = new List<Booking>();
        }
        public void AddBooking(Booking booking)
        {
            if(GetFutureBookingCount() >= 2)
            {
                throw new Exception("Too many future bookings. Max allowed is 2");
            }
            else
            {
                Bookings.Add(booking);
            }
        }
        private int GetFutureBookingCount()
        {
            var list = Bookings.Where(x => x.StartDateTime > DateTime.Now).ToList();
            return list.Count;
        }
    }
}
