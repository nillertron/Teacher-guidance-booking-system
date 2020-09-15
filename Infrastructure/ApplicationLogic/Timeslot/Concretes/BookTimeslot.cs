using Infrastructure.ApplicationLogic.Person.Concretes;
using Infrastructure.Repository;
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
        private readonly IPersonRepository personRepository;
        public BookTimeslot(ITimeslotRepository timeslotRepository, IPersonState state, IPersonRepository personRepository)
        {
            this.timeslotRepository = timeslotRepository;
            this.state = state;
            this.personRepository = personRepository;
        }
        public async Task TryBookTimeslot(Model.Timeslot timeslot, Model.Booking booking)
        {
            var person = state.person;
            var student = (Student)person;
            student.AddBooking(booking);
            booking.StudentId = student.Id;
            var slot = await timeslotRepository.GetSingle(timeslot.Id);
            slot.Booking = booking;
            await timeslotRepository.Update(slot);

        }
    }
}
