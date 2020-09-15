using Infrastructure.Repository;
using Infrastructure.Repository.Booking.Concretes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Timeslot.Concretes
{
    public class TimeslotCrud : ITimeslotCrud
    {
        private readonly ITimeslotRepository timeslotRepository;
        private readonly IBookingRepository bookingRepository;
        public TimeslotCrud(ITimeslotRepository timeslotRepository, IBookingRepository bookingRepository)
        {
            this.timeslotRepository = timeslotRepository;
            this.bookingRepository = bookingRepository;
        }
        public async Task BookTimeslot(Model.Timeslot timeslot)
        {
            await timeslotRepository.Update(timeslot);
        }
    }
}
