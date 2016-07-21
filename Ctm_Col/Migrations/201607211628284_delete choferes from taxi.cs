namespace Ctm_Col.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletechoferesfromtaxi : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Chofers", "Taxi_Id", "dbo.Taxis");
            DropIndex("dbo.Chofers", new[] { "Taxi_Id" });
            DropColumn("dbo.Chofers", "Taxi_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Chofers", "Taxi_Id", c => c.Int());
            CreateIndex("dbo.Chofers", "Taxi_Id");
            AddForeignKey("dbo.Chofers", "Taxi_Id", "dbo.Taxis", "Id");
        }
    }
}
