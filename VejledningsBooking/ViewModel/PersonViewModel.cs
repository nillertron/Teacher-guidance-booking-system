using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VejledningsBooking.ViewModel
{
    public class PersonViewModel
    {
        public Person Person { get; set; } = new Student();
        public PersonType personType { get; set; }
    }
}
