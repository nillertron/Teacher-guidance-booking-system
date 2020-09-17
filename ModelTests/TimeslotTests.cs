using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Tests
{
    [TestClass()]
    public class TimeslotTests
    {
        [TestMethod()]
        public void SetDatesTest()
        {
            var slot = new Timeslot();
            var date1 = new DateTime(2020, 09, 16, 23, 30, 00);
            var date2 = date1.AddMinutes(30);
            bool exceptionThrown = false;
            try
            {
                slot.ValidateDates();

            }
            catch (Exception ex)
            {
                exceptionThrown = true;
            }
            Assert.IsFalse(exceptionThrown);
        }
    }
}