using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Command.Booking
{
    public class BookingCommand : CommandRepository<Model.Booking>, IBookingCommand
    {
        public BookingCommand(VejledningsContext context) : base(context)
        {

        }
    }
}
