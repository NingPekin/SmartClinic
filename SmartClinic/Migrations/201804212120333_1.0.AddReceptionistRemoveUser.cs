namespace SmartClinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10AddReceptionistRemoveUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Patient_Id", "dbo.Patients");
            DropIndex("dbo.Users", new[] { "Patient_Id" });
            CreateTable(
                "dbo.Receptionists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Patients", "Email", c => c.String());
            AddColumn("dbo.Patients", "Password", c => c.String());
            AddColumn("dbo.Patients", "UserType", c => c.Int(nullable: false));
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        UserType = c.Int(nullable: false),
                        LastLoginTime = c.DateTime(nullable: false),
                        Patient_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Patients", "UserType");
            DropColumn("dbo.Patients", "Password");
            DropColumn("dbo.Patients", "Email");
            DropTable("dbo.Receptionists");
            CreateIndex("dbo.Users", "Patient_Id");
            AddForeignKey("dbo.Users", "Patient_Id", "dbo.Patients", "Id");
        }
    }
}
