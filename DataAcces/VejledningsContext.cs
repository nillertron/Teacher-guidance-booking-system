using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DataAcces
{
    public class VejledningsContext : DbContext
    {
        public VejledningsContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Calender> Calenders { get; set; }
        public DbSet<Hold> Hold { get; set; }
        public DbSet<HoldLinjer> HoldLinjer { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Timeslot> Timeslots { get; set; }
        public DbSet<StoredCookie> StoredCookies { get; set; }
        
    }
}
