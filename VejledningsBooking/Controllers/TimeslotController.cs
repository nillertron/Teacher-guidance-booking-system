using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.ApplicationLogic.Timeslot.Concretes;
using Microsoft.AspNetCore.Mvc;
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
                    return RedirectToAction("View", "Calender", new { calenderId = model.Timeslot.CalendarId });
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> AttachBooking([Bind]CreateBookingViewModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    await bookTimeslot.TryBookTimeslot(model.TheTimeslot, model.TheBooking);
                    var hold = model.TheTimeslot.Calendar.Hold[0];
                    return RedirectToAction("Index", "Calender", new { holdId = hold.Id });

                }
                catch (Exception ex)
                {

                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            return RedirectToAction("Index", "Calender");
        }
    }
}
