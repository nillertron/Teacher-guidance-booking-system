using DataAcces.Command.Booking;
using DataAcces.Command.Timeslot;
using DataAcces.Query.Person;
using DataAcces.Query.Timeslot;
using Infrastructure.ApplicationLogic.Person.Concretes;
using System;
using System.Threading.Tasks;

namespace Infrastructure.ApplicationLogic.Timeslot.Concretes
{
    public class BookTimeslot : IBookTimeslot
    {
        private readonly IPersonState state;
        private readonly IStudentQuery studentQuery;
        private readonly IBookingCommand bookingCommand;
        private readonly ITimeslotCommand timeslotCommand;
        private readonly ITimeslotQuery timeslotQuery;
        public BookTimeslot( IPersonState state, IStudentQuery studentQuery, IBookingCommand bookingCommand, ITimeslotQuery timeslotQuery, ITimeslotCommand timeslotCommand)
        {
            this.state = state;
            this.studentQuery = studentQuery;
            this.bookingCommand = bookingCommand;
            this.timeslotQuery = timeslotQuery;
            this.timeslotCommand = timeslotCommand;

        }
        public async Task TryBookTimeslot(Model.Timeslot timeslot, Model.Booking booking)
        {
            if (timeslot.StartDateTime < DateTime.Now)
                throw new Exception("Cannot book old date");
            var studentId = await state.GetPersonIdAsync();
            booking.StudentId = studentId;
            var student = await studentQuery.GetStudentWithFutureBookings(studentId);
            student.AddBooking(booking);
            await bookingCommand.Create(booking);
            var slot = await timeslotQuery.GetSingle(timeslot.Id);
            slot.BookingId = booking.Id;
            slot.Booking = booking;
            await timeslotCommand.UpdateWithConcurrencyCheck(slot);

        }
    }
}
