namespace Ctm_Col.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class COlumnaddedtorecibosDeducibles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReciboDeducibles", "Taxi_Id", c => c.Int());
            CreateIndex("dbo.ReciboDeducibles", "Taxi_Id");
            AddForeignKey("dbo.ReciboDeducibles", "Taxi_Id", "dbo.Taxis", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReciboDeducibles", "Taxi_Id", "dbo.Taxis");
            DropIndex("dbo.ReciboDeducibles", new[] { "Taxi_Id" });
            DropColumn("dbo.ReciboDeducibles", "Taxi_Id");
        }
    }
}
