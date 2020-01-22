namespace HMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRoomNoToStringInRoomsTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rooms", "RoomNo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rooms", "RoomNo", c => c.Int(nullable: false));
        }
    }
}
