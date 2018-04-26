using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SmartClinic.DataObject
{
    public class ProjectContext : DbContext
    {
        public ProjectContext() : base("name=SmartClinic")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Receptionist> Receptionist { get; set; }

        public DbSet<Doctor> Doctor { get; set; }

        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<OccupiedTime> OccupiedTime { get; set; }
        public DbSet<AvailableTime> AvailableTime { get; set; }

        //public DbSet<User> User { get; set; }
    }
}