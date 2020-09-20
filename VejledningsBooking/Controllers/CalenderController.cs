using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Infrastructure.ApplicationLogic.Calender.Concretes;
using Infrastructure.ApplicationLogic.Hold.Concretes;
using Infrastructure.ApplicationLogic.Person.Concretes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model;
using VejledningsBooking.ViewModel;

namespace VejledningsBooking.Controllers
{
    public class CalenderController : Controller
    {
        private readonly IHoldCRUD holdCRUD;
        private readonly ICalenderCRUD calenderCRUD;
        private readonly IPersonState personState;
        private readonly ICalenderDateManager calenderDateManager;
        public CalenderController(IHoldCRUD holdCRUD, ICalenderCRUD calenderCRUD, IPersonState personState, ICalenderDateManager calenderDateManager)
        {
            this.holdCRUD = holdCRUD;
            this.calenderCRUD = calenderCRUD;
            this.personState = personState;
            this.calenderDateManager = calenderDateManager;
        }
        public async Task<IActionResult> Index(int? holdId)
        {
            var model = new CalenderViewModel();
            if (holdId == null)
            {
                model.SelectedPerson = await personState.GetPersonAsync();

            }
            else
            {
                var hold = await holdCRUD.GetHoldFromId((int)holdId);
                model.SelectedCalender = await calenderCRUD.Get(hold);
                model.Dates = await calenderDateManager.Get5Weekdays(DateTime.Now);
                model.Hours = await calenderDateManager.GetDailyHourTimes();
                model.SelectedPerson = await personState.GetPersonAsync();
            }
            return View(model);

        }
        public async Task<IActionResult> View(int? calenderId)
        {
            if (calenderId == null)
                return View();
            if (calenderId != null)
            {
                var model = new CalenderViewModel();
                model.SelectedCalender = await calenderCRUD.Get((int)calenderId);
                model.Dates = await calenderDateManager.Get5Weekdays(DateTime.Now);
                model.Hours = await calenderDateManager.GetDailyHourTimes();
                model.SelectedPerson = await personState.GetPersonAsync();
                return View("Index",model);
            }
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Index([Bind] CalenderViewModel model)
        {
            var hold = await holdCRUD.GetHoldFromId(model.SelectedHoldId);
            model.SelectedCalender = await calenderCRUD.Get(hold);
            model.Dates = await calenderDateManager.Get5Weekdays(DateTime.Now);
            model.Hours = await calenderDateManager.GetDailyHourTimes();
            model.SelectedPerson = await personState.GetPersonAsync();
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> NextWeek(int week, int holdId)
        {
            var model = new CalenderViewModel();
            var hold = await holdCRUD.GetHoldFromId(holdId);
            model.SelectedCalender = await calenderCRUD.Get(hold);
            model.SelectedPerson = await personState.GetPersonAsync();
            if (!hold.HoldLinjer.Any(x => x.Person.Id == model.SelectedPerson.Id))
                return BadRequest("You do not belong here :(");
            model.SelectedHoldId = hold.Id;
            model.CurrentWeek = week;
            model.Dates = await calenderDateManager.Get5Weekdays(await calenderDateManager.Add7DaysAndGetDate(week));
            model.Hours = await calenderDateManager.GetDailyHourTimes();
            return View("Index",model);
        }
        [HttpGet]
        public async Task<IActionResult> PrevWeek(int week, int holdId)
        {
            var model = new CalenderViewModel();
            var hold = await holdCRUD.GetHoldFromId(holdId);
            model.SelectedPerson = await personState.GetPersonAsync();
            if (!hold.HoldLinjer.Any(x => x.Person.Id == model.SelectedPerson.Id))
                return BadRequest("You do not belong here :(");
            model.SelectedHoldId = hold.Id;
            model.CurrentWeek = week;
            model.SelectedCalender = await calenderCRUD.Get(hold);
            model.Dates = await calenderDateManager.Get5Weekdays(await calenderDateManager.Subtract7DaysAndGetDate(week));
            model.Hours = await calenderDateManager.GetDailyHourTimes();
            return View("Index",model);
        }
        public async Task<IActionResult> Create()
        {
            var model = new CreateCalenderViewModel { HoldList = await holdCRUD.GetHoldWithoutSchema() };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind] CreateCalenderViewModel model)
        {
            if(ModelState.IsValid)
            {
                var holdList = await holdCRUD.GetAllHold();
               await model.Calender.AddHold(model.SelectedIndicies, holdList);
                try
                {
                    await calenderCRUD.Create(model.Calender);
                    return RedirectToAction(nameof(Index));

                }
                catch (Exception ex)
                {

                    ModelState.AddModelError(string.Empty, ex.Message);
                    return RedirectToAction(nameof(Create));

                }


            }
            return View();
        }
    }
}
