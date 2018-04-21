namespace SmartClinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10_User_Add_LastLoginTime_Column : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "LastLoginTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "LastLoginTime");
        }
    }
}
