namespace HMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRoomType : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO RoomTypes (Id, RoomTypeDescription) VALUES (1, 'Male Ward')");
            Sql(@"INSERT INTO RoomTypes (Id, RoomTypeDescription) VALUES (2, 'Female Ward')");
            Sql(@"INSERT INTO RoomTypes (Id, RoomTypeDescription) VALUES (3, 'OB Ward')");
            Sql(@"INSERT INTO RoomTypes (Id, RoomTypeDescription) VALUES (4, 'Pedia Ward')");
            Sql(@"INSERT INTO RoomTypes (Id, RoomTypeDescription) VALUES (5, 'Semi-Private')");
            Sql(@"INSERT INTO RoomTypes (Id, RoomTypeDescription) VALUES (6, 'Private')");
            Sql(@"INSERT INTO RoomTypes (Id, RoomTypeDescription) VALUES (7, 'Private Deluxe')");
            Sql(@"INSERT INTO RoomTypes (Id, RoomTypeDescription) VALUES (8, 'Suite')");
            Sql(@"INSERT INTO RoomTypes (Id, RoomTypeDescription) VALUES (9, 'Executive Suite')");
        }
        
        public override void Down()
        {
        }
    }
}
