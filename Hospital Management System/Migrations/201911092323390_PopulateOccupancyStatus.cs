namespace HMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateOccupancyStatus : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO OccupancyStatus (Id, Status, Active) VALUES (1, 'Vacant', 'True')");
            Sql(@"INSERT INTO OccupancyStatus (Id, Status, Active) VALUES (2, 'Reserved', 'True')");
            Sql(@"INSERT INTO OccupancyStatus (Id, Status, Active) VALUES (3, 'Occupied', 'True')");
            Sql(@"INSERT INTO OccupancyStatus (Id, Status, Active) VALUES (4, 'Under Maintenance', 'True')");
        }
        
        public override void Down()
        {
        }
    }
}
