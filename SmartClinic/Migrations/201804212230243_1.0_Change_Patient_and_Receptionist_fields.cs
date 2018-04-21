namespace SmartClinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10_Change_Patient_and_Receptionist_fields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Receptionists", "FirstName", c => c.String());
            AddColumn("dbo.Receptionists", "LastName", c => c.String());
            DropColumn("dbo.Patients", "UserType");
            DropColumn("dbo.Receptionists", "UserType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Receptionists", "UserType", c => c.Int(nullable: false));
            AddColumn("dbo.Patients", "UserType", c => c.Int(nullable: false));
            DropColumn("dbo.Receptionists", "LastName");
            DropColumn("dbo.Receptionists", "FirstName");
        }
    }
}
