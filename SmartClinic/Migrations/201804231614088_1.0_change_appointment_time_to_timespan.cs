namespace SmartClinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10_change_appointment_time_to_timespan : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Appointments", "Time", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Appointments", "Time", c => c.Int(nullable: false));
        }
    }
}
