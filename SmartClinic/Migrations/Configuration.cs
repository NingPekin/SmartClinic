namespace SmartClinic.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SmartClinic.DataObject.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SmartClinic.DataObject.ProjectContext context)
        {
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //Add Default Doctors
            context.Doctor.AddOrUpdate(a => a.Id,
                new DataObject.Doctor() { Name = "Zohreh Moeini", Department="Sergury"},
                new DataObject.Doctor() { Name = "Farzaneh Fallahi", Department="Cardiologist" },
                new DataObject.Doctor() { Name = "Ning Wei", Department= "Pediatrix" }
                );
        }
    }
}
