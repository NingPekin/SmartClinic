namespace SmartClinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10_edit_foreignkey_appointmentoccupiedTime : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "PatientId", "dbo.Patients");
            DropIndex("dbo.Appointments", new[] { "PatientId" });
            RenameColumn(table: "dbo.Appointments", name: "PatientId", newName: "Patient_Id");
            AlterColumn("dbo.Appointments", "Patient_Id", c => c.Int());
            CreateIndex("dbo.Appointments", "Patient_Id");
            AddForeignKey("dbo.Appointments", "Patient_Id", "dbo.Patients", "Id");
            DropColumn("dbo.Appointments", "DocterId");
            DropColumn("dbo.OccupiedTimes", "DocterId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OccupiedTimes", "DocterId", c => c.Int(nullable: false));
            AddColumn("dbo.Appointments", "DocterId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Appointments", "Patient_Id", "dbo.Patients");
            DropIndex("dbo.Appointments", new[] { "Patient_Id" });
            AlterColumn("dbo.Appointments", "Patient_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Appointments", name: "Patient_Id", newName: "PatientId");
            CreateIndex("dbo.Appointments", "PatientId");
            AddForeignKey("dbo.Appointments", "PatientId", "dbo.Patients", "Id", cascadeDelete: true);
        }
    }
}
