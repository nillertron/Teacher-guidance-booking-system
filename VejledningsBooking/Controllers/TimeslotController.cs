using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.ApplicationLogic.Timeslot.Concretes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using VejledningsBooking.ViewModel;
using VejledningsBooking.Views.Timeslot;

namespace VejledningsBooking.Controllers
{
    public class TimeslotController : Controller
    {
        private readonly IBookTimeslot bookTimeslot;
        private readonly ITimeslotCrud timeslotCrud;
        public TimeslotController(IBookTimeslot bookTimeSlot, ITimeslotCrud timeslotCrud)
        {
            this.bookTimeslot = bookTimeSlot;
            this.timeslotCrud = timeslotCrud;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Timeslot", "CalenderId")] CreateTimeslotViewModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    
                    await timeslotCrud.Create(model.Timeslot);
                    // return RedirectToAction("View", "Calender", new { calenderId = model.Timeslot.CalendarId });
                    return StatusCode(200);
                }
                catch (Exception ex)
                {
                    
                    return BadRequest(new { Message = ex.Message });
                }
            }
            return BadRequest(new { Message = "state not valid" });
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> AttachBooking([Bind]CreateBookingViewModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {

                    model.TheBooking.StartDateTime = DateTime.Parse(model.dt1);
                    model.TheBooking.EndDateTime = DateTime.Parse(model.dt2);
                    model.TheTimeslot.StartDateTime = DateTime.Parse(model.dt1);
                    model.TheTimeslot.EndDateTime = DateTime.Parse(model.dt2);

                    await bookTimeslot.TryBookTimeslot(model.TheTimeslot, model.TheBooking);
                    return StatusCode(200);

                }
                catch (DbUpdateConcurrencyException ex)
                {
                    return BadRequest(new { Message = ex.Message });

                }
                catch (Exception ex)
                {

                    return BadRequest(new { Message = ex.Message });
                }

            }
            return BadRequest(new { Message = "State not valid" });
        }
    }
}
