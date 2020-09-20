using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Query.Booking
{
    public class BookingQuery : QueryRepository<Model.Booking>, IBookingQuery
    {
        public BookingQuery(VejledningsContext context) : base(context)
        {

        }
        public async Task<Model.Booking> GetWithInclude(int id)
        {
            return await context.Bookings.Where(x => x.Id == id).Include(x => x.Student).FirstOrDefaultAsync();
        }
    }
}
