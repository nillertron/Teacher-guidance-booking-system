using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.ApplicationLogic.Person;
using Infrastructure.ApplicationLogic.Person.Concretes;
using Microsoft.AspNetCore.Mvc;
using Model;
using VejledningsBooking.ViewModel;

namespace VejledningsBooking.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonCRUD personCRUD;
        private readonly IPersonState personState;
        public PersonController(IPersonCRUD personCRUD, IPersonState personState)
        {
            this.personCRUD = personCRUD;
            this.personState = personState;
        }
        public async Task<IActionResult> CreateStudent()
        {
            return View(new Student());
        }
        public async Task<IActionResult> CreateTeacher()
        {
            return View(new Teacher());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateStudent([Bind] Student model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await personCRUD.CreatePerson(model);
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError(string.Empty, ex.Message);
                    return View();
                }
                return RedirectToAction("Index", "Home");


            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> CreateTeacher([Bind] Teacher model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await personCRUD.CreatePerson(model);
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError(string.Empty, ex.Message);
                    return View();
                }
                return RedirectToAction("Index", "Home");
            }
            return NotFound();
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind] LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await personState.AttemptLogin(model.Username, model.Password);
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                    return View();
                }
            }
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await personState.LogOff();
            return RedirectToAction("Index", "Home");
        }
    }
}
