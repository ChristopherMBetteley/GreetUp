namespace GreetUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeToAttendeeCount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "EventAttendee", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "EventAttendee");
        }
    }
}
