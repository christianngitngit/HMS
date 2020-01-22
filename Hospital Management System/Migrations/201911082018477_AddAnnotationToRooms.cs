namespace HMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationToRooms : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rooms", "RoomNo", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rooms", "RoomNo", c => c.String());
        }
    }
}
