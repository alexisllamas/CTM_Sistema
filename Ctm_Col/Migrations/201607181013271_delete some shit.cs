namespace Ctm_Col.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletesomeshit : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuarios", "TaxiId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "TaxiId", c => c.Int(nullable: false));
        }
    }
}
