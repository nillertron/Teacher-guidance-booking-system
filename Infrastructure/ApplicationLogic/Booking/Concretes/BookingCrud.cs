using Infrastructure.Repository.Booking.Concretes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Booking.Concretes
{
    public class BookingCrud : IBookingCrud
    {
        private readonly IBookingRepository bookingRepository;
        public BookingCrud(IBookingRepository bookingRepository)
        {
            this.bookingRepository = bookingRepository;
        }
        public async Task CreateBooking(Model.Booking booking)
        {
            await bookingRepository.Create(booking);
        }


    }
}
