using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Booking.Concretes
{
    public class BookingRepository : Repository<Model.Booking>, IBookingRepository
    {
        public BookingRepository(VejledningsContext context) : base(context)
        {

        }

        public async Task<Model.Booking> GetBooking(int id)
        {
            var booking = new Model.Booking();
            await Task.Run(async () =>
            {
                booking = await context.Bookings.Where(x => x.Id == id).Include(x => x.Student).FirstOrDefaultAsync();
            });
            return booking;
        }

    }
}
