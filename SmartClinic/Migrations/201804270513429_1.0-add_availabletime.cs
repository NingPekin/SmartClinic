namespace SmartClinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_availabletime : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AvailableTimes",
                c => new
                    {
                        AvailableId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Time = c.String(),
                        Doctor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.AvailableId)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Id)
                .Index(t => t.Doctor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AvailableTimes", "Doctor_Id", "dbo.Doctors");
            DropIndex("dbo.AvailableTimes", new[] { "Doctor_Id" });
            DropTable("dbo.AvailableTimes");
        }
    }
}
