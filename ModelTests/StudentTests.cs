using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Tests
{
    [TestClass()]
    public class StudentTests
    {

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void AddBookingTest()
        {
            var person = new Student();
            person.AddBooking(new Booking { StartDateTime = DateTime.Now });
            person.AddBooking(new Booking { StartDateTime = DateTime.Now });
        }
        [TestMethod()]
        public void OldDate()
        {
            var person = new Student();
            try
            {
                person.AddBooking(new Booking { StartDateTime = DateTime.Now.AddDays(-5) });
                person.AddBooking(new Booking { StartDateTime = DateTime.Now });
            }
            catch (Exception ex)
            {

                Assert.Fail("Failed with exception: " + ex.Message);
            }

        }
        [TestMethod()]
        public void FuturedATE()
        {
            var person = new Student();
            try
            {
                person.AddBooking(new Booking { StartDateTime = DateTime.Now.AddDays(5) });
                person.AddBooking(new Booking { StartDateTime = DateTime.Now });
            }
            catch (Exception ex)
            {

                Assert.Fail("Failed with exception: " + ex.Message);
            }

        }
    }
}