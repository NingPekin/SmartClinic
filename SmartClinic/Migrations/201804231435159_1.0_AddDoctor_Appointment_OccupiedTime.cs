namespace SmartClinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10_AddDoctor_Appointment_OccupiedTime : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        DocterId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Time = c.Int(nullable: false),
                        Doctor_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Id)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.Doctor_Id);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Department = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OccupiedTimes",
                c => new
                    {
                        OccupiedId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Time = c.Int(nullable: false),
                        DocterId = c.Int(nullable: false),
                        Doctor_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.OccupiedId)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Id)
                .Index(t => t.Doctor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OccupiedTimes", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.Appointments", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Appointments", "Doctor_Id", "dbo.Doctors");
            DropIndex("dbo.OccupiedTimes", new[] { "Doctor_Id" });
            DropIndex("dbo.Appointments", new[] { "Doctor_Id" });
            DropIndex("dbo.Appointments", new[] { "PatientId" });
            DropTable("dbo.OccupiedTimes");
            DropTable("dbo.Doctors");
            DropTable("dbo.Appointments");
        }
    }
}
