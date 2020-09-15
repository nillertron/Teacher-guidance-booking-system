using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VejledningsBooking.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Create()
        {
            return PartialView();
        }
    }
}
