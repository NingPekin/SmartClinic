namespace SmartClinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10_listoccupiedtime_listappointment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.OccupiedTimes", "Doctor_Id", "dbo.Doctors");
            DropIndex("dbo.Appointments", new[] { "Doctor_Id" });
            DropIndex("dbo.OccupiedTimes", new[] { "Doctor_Id" });
            DropPrimaryKey("dbo.Doctors");
            AlterColumn("dbo.Appointments", "Doctor_Id", c => c.Int());
            AlterColumn("dbo.Doctors", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.OccupiedTimes", "Doctor_Id", c => c.Int());
            AddPrimaryKey("dbo.Doctors", "Id");
            CreateIndex("dbo.Appointments", "Doctor_Id");
            CreateIndex("dbo.OccupiedTimes", "Doctor_Id");
            AddForeignKey("dbo.Appointments", "Doctor_Id", "dbo.Doctors", "Id");
            AddForeignKey("dbo.OccupiedTimes", "Doctor_Id", "dbo.Doctors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OccupiedTimes", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.Appointments", "Doctor_Id", "dbo.Doctors");
            DropIndex("dbo.OccupiedTimes", new[] { "Doctor_Id" });
            DropIndex("dbo.Appointments", new[] { "Doctor_Id" });
            DropPrimaryKey("dbo.Doctors");
            AlterColumn("dbo.OccupiedTimes", "Doctor_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Doctors", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Appointments", "Doctor_Id", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Doctors", "Id");
            CreateIndex("dbo.OccupiedTimes", "Doctor_Id");
            CreateIndex("dbo.Appointments", "Doctor_Id");
            AddForeignKey("dbo.OccupiedTimes", "Doctor_Id", "dbo.Doctors", "Id");
            AddForeignKey("dbo.Appointments", "Doctor_Id", "dbo.Doctors", "Id");
        }
    }
}
