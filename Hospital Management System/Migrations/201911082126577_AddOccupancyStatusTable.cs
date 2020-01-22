namespace HMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOccupancyStatusTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OccupancyStatus",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Status = c.String(nullable: false, maxLength: 20),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OccupancyStatus");
        }
    }
}
