namespace HMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSpecializationToDoctorTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "SpecializationId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doctors", "SpecializationId");
        }
    }
}
