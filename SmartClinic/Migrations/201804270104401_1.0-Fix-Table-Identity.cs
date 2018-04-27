namespace SmartClinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10FixTableIdentity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.AvailableTimes", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.OccupiedTimes", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.Appointments", "Patient_Id", "dbo.Patients");

            DropIndex("dbo.Appointments", "Doctor_Id");
            DropIndex("dbo.AvailableTimes", "Doctor_Id");
            DropIndex("dbo.OccupiedTimes", "Doctor_Id");
            DropIndex("dbo.Appointments", "Patient_Id");

            DropPrimaryKey("dbo.Receptionists");
            DropPrimaryKey("dbo.OccupiedTimes");
            DropPrimaryKey("dbo.AvailableTimes");
            DropPrimaryKey("dbo.Patients");
            DropPrimaryKey("dbo.Doctors");
            DropPrimaryKey("dbo.Appointments");

            Sql("alter table dbo.Appointments drop column ID; alter table dbo.Appointments add ID int primary key not null identity(1,1);");
            Sql("alter table dbo.Patients drop column ID; alter table dbo.Patients add ID int not null primary key identity(1,1);");
            Sql("alter table dbo.AvailableTimes drop column AvailableId; alter table dbo.AvailableTimes add AvailableId int not null primary key identity(1,1);");
            Sql("alter table dbo.OccupiedTimes drop column OccupiedId; alter table dbo.OccupiedTimes add OccupiedId int not null primary key identity(1,1);");
            Sql("alter table dbo.Receptionists drop column ID; alter table dbo.Receptionists add ID int not null primary key identity(1,1);");
            Sql("alter table dbo.Doctors drop column ID; alter table dbo.Doctors add ID int not null primary key identity(1,1);");

            AddForeignKey("dbo.Appointments", "Doctor_Id", "dbo.Doctors", "Id");
            AddForeignKey("dbo.AvailableTimes", "Doctor_Id", "dbo.Doctors", "Id");
            AddForeignKey("dbo.OccupiedTimes", "Doctor_Id", "dbo.Doctors", "Id");
            AddForeignKey("dbo.Appointments", "Patient_Id", "dbo.Patients", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "Patient_Id", "dbo.Patients");
            DropForeignKey("dbo.OccupiedTimes", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.AvailableTimes", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.Appointments", "Doctor_Id", "dbo.Doctors");
            DropPrimaryKey("dbo.Receptionists");
            DropPrimaryKey("dbo.OccupiedTimes");
            DropPrimaryKey("dbo.AvailableTimes");
            DropPrimaryKey("dbo.Patients");
            DropPrimaryKey("dbo.Doctors");
            DropPrimaryKey("dbo.Appointments");
            AlterColumn("dbo.Receptionists", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.OccupiedTimes", "OccupiedId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.AvailableTimes", "AvailableId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Patients", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Doctors", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Appointments", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Receptionists", "Id");
            AddPrimaryKey("dbo.OccupiedTimes", "OccupiedId");
            AddPrimaryKey("dbo.AvailableTimes", "AvailableId");
            AddPrimaryKey("dbo.Patients", "Id");
            AddPrimaryKey("dbo.Doctors", "Id");
            AddPrimaryKey("dbo.Appointments", "Id");
            AddForeignKey("dbo.Appointments", "Patient_Id", "dbo.Patients", "Id");
            AddForeignKey("dbo.OccupiedTimes", "Doctor_Id", "dbo.Doctors", "Id");
            AddForeignKey("dbo.AvailableTimes", "Doctor_Id", "dbo.Doctors", "Id");
            AddForeignKey("dbo.Appointments", "Doctor_Id", "dbo.Doctors", "Id");
        }
    }
}
