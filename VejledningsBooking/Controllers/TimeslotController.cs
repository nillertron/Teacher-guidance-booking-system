using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.ApplicationLogic.Timeslot.Concretes;
using Microsoft.AspNetCore.Mvc;
using VejledningsBooking.ViewModel;

namespace VejledningsBooking.Controllers
{
    public class TimeslotController : Controller
    {
        private readonly IBookTimeslot bookTimeslot;
        public TimeslotController(IBookTimeslot bookTimeSlot)
        {
            this.bookTimeslot = bookTimeSlot;
        }
        public IActionResult Index()
        {
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
