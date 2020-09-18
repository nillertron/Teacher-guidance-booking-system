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
            slot.StartDateTime = new DateTime(2020, 09, 18, 23, 30, 00);
            slot.EndDateTime = slot.StartDateTime.AddMinutes(30);
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
        [TestMethod]
        public void SingleOoCollectionTest()
        {
            var start = new DateTime(2020, 09, 18, 15, 30, 00);
            var slot = new Timeslot { CalendarId = 1, StartDateTime = start, EndDateTime = start.AddDays(2), TeacherId = 1 };
            var slotList = slot.DetermineSingleOrCollectionTimeslots();

            Assert.IsTrue(slotList.Count == 1);
        }
        
    }
}