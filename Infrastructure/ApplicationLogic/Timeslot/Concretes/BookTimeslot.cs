using Infrastructure.ApplicationLogic.Person.Concretes;
using Infrastructure.Repository;
using Infrastructure.Repository.Booking.Concretes;
using Infrastructure.Repository.Concretes;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Timeslot.Concretes
{
    public class BookTimeslot : IBookTimeslot
    {
        private readonly ITimeslotRepository timeslotRepository;
        private readonly IPersonState state;
        private readonly IStudentRepository studentRepository;
        private readonly IBookingRepository bookingRepository;
        public BookTimeslot(ITimeslotRepository timeslotRepository, IPersonState state, IStudentRepository studentRepository, IBookingRepository bookingRepository)
        {
            this.timeslotRepository = timeslotRepository;
            this.state = state;
            this.studentRepository = studentRepository;
            this.bookingRepository = bookingRepository;
        }
        public async Task TryBookTimeslot(Model.Timeslot timeslot, Model.Booking booking)
        {
            var student = (Student)await state.GetPersonAsync();
            booking.StudentId = student.Id;
            student.AddBooking(booking);
            await bookingRepository.Create(booking);
            var slot = await timeslotRepository.GetSingle(timeslot.Id);
            slot.BookingId = booking.Id;
            slot.Booking = booking;
            await timeslotRepository.UpdateWithConcurrencyCheck(slot);

        }
    }
}
