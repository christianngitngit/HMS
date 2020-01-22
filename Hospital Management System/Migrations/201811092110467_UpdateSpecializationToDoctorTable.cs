namespace HMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSpecializationToDoctorTable : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Doctors", "SpecializationId");
            AddForeignKey("dbo.Doctors", "SpecializationId", "dbo.Specializations", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "SpecializationId", "dbo.Specializations");
            DropIndex("dbo.Doctors", new[] { "SpecializationId" });
        }
    }
}
