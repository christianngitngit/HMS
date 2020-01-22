namespace HMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeGenderFromPatientTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "Gender", c => c.String(nullable: false, maxLength: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "Gender");
        }
    }
}
