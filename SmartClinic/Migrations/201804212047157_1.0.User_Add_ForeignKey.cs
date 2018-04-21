namespace SmartClinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10User_Add_ForeignKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Patient_Id", c => c.Int());
            CreateIndex("dbo.Users", "Patient_Id");
            AddForeignKey("dbo.Users", "Patient_Id", "dbo.Patients", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Patient_Id", "dbo.Patients");
            DropIndex("dbo.Users", new[] { "Patient_Id" });
            DropColumn("dbo.Users", "Patient_Id");
        }
    }
}
