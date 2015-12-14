namespace DavieCleaningService_OfficeMaster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Position : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "FirstName", c => c.String());
            AddColumn("dbo.Employees", "LastName", c => c.String());
            AddColumn("dbo.Employees", "PositionId", c => c.String());
            DropColumn("dbo.Employees", "Name");
            DropColumn("dbo.Employees", "Position");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Position", c => c.String());
            AddColumn("dbo.Employees", "Name", c => c.String());
            DropColumn("dbo.Employees", "PositionId");
            DropColumn("dbo.Employees", "LastName");
            DropColumn("dbo.Employees", "FirstName");
        }
    }
}
