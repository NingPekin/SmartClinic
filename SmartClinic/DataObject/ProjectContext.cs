using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SmartClinic.DataObject
{
    public class ProjectContext : DbContext
    {
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Receptionist> Receptionist { get; set; }

        //public DbSet<User> User { get; set; }
    }
}