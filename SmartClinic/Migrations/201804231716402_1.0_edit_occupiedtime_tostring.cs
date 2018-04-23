namespace SmartClinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10_edit_occupiedtime_tostring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OccupiedTimes", "Time", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OccupiedTimes", "Time", c => c.Int(nullable: false));
        }
    }
}
