using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Model
{
    public class Student:Person
    {
        public List<Booking> Bookings { get; private set; }
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
                CheckForDuplicateBooking(booking);
                Bookings.Add(booking);
            }
        }
        private void CheckForDuplicateBooking(Booking booking)
        {
            if(Bookings.Any(x=>x.StartDateTime - booking.StartDateTime < TimeSpan.FromSeconds(30) && x.StartDateTime - booking.StartDateTime > TimeSpan.FromSeconds(-30)))
            {
                throw new Exception("Duplicate booking!");
            }
        }
        private int GetFutureBookingCount()
        {
            var list = Bookings.Where(x => x.StartDateTime > DateTime.Now).ToList();
            return list.Count;
        }
    }
}
