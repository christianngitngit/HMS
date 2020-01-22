namespace HMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOccupancyStatusToRooms : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "OccupancyStatusId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Rooms", "OccupancyStatusId");
            AddForeignKey("dbo.Rooms", "OccupancyStatusId", "dbo.OccupancyStatus", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "OccupancyStatusId", "dbo.OccupancyStatus");
            DropIndex("dbo.Rooms", new[] { "OccupancyStatusId" });
            DropColumn("dbo.Rooms", "OccupancyStatusId");
        }
    }
}
