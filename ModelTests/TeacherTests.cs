using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Tests
{
    [TestClass()]
    public class TeacherTests
    {

        [TestMethod()]
        public void AddTimeslotTest()
        {
            var start = new DateTime(2020, 09, 18, 10, 00, 00);
            var teacher = new Teacher();
            var ts = new Timeslot { StartDateTime = start, EndDateTime = start };
            teacher.AddTimeslot(ts);
            var tjek = teacher.AddTimeslot(ts);

            Assert.IsFalse(tjek);
        }

        [TestMethod()]
        public void AddTimeslotTest2()
        {
            var start = new DateTime(2020, 09, 18, 10, 00, 00);
            var teacher = new Teacher();
            var ts = new Timeslot { StartDateTime = start, EndDateTime = start };
            var ts2 = new Timeslot { StartDateTime = start.AddMinutes(30) };
             teacher.AddTimeslot(ts);
            var tjek = teacher.AddTimeslot(ts2);

            Assert.IsTrue(tjek);
        }
        [TestMethod()]
        public void AddTimeslotTest3()
        {
            var start = new DateTime(2020, 09, 18, 10, 00, 00);
            var teacher = new Teacher();
            var ts = new Timeslot { StartDateTime = start, EndDateTime = start };
            teacher.AddTimeslot(ts);
            ts.StartDateTime = ts.StartDateTime.AddHours(-1);
            var tjek = teacher.AddTimeslot(ts);

            Assert.IsFalse(tjek);
        }
        [TestMethod()]
        public void AddTimeslotTest4()
        {
            var start = new DateTime(2020, 09, 18, 10, 00, 00);
            var teacher = new Teacher();
            var ts = new Timeslot { StartDateTime = start, EndDateTime = start };
            teacher.AddTimeslot(ts);
            ts.StartDateTime = ts.StartDateTime.AddMinutes(-1);
            var tjek = teacher.AddTimeslot(ts);

            Assert.IsFalse(tjek);
        }
        [TestMethod()]
        public void AddTimeslotTest5()
        {
            var start = new DateTime(2020, 09, 18, 10, 00, 00);
            var teacher = new Teacher();
            var ts = new Timeslot { StartDateTime = start, EndDateTime = start };
            teacher.AddTimeslot(ts);
            ts.StartDateTime = ts.StartDateTime.AddSeconds(20);
            var tjek = teacher.AddTimeslot(ts);

            Assert.IsFalse(tjek);
        }
    }
}