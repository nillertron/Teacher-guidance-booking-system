using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.ApplicationLogic.Timeslot.Concretes;
using Microsoft.AspNetCore.Mvc;
using VejledningsBooking.ViewModel;

namespace VejledningsBooking.Controllers
{
    public class BookingController : Controller
    {
        private readonly ITimeslotCrud timeslotCrud;
        public BookingController(ITimeslotCrud timeslotCrud)
        {
            this.timeslotCrud = timeslotCrud;
        }
        [HttpGet]
        public async Task<IActionResult> TimeslotAjaxGet(int id)
        {
            try
            {
                var obj = await timeslotCrud.GetFromId(id);
                var dto = new CreateBookingViewModel { SelectedCalender = obj.Calendar, ThePerson = obj.Teacher, TheTimeslot = obj };
                dto.TheTimeslot.Booking = null;
                dto.TheTimeslot.Calendar = null;
                dto.TheTimeslot.Teacher = null;
                return StatusCode(200, dto);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
