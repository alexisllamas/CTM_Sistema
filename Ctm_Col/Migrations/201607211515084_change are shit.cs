namespace Ctm_Col.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeareshit : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Polizas", "ConcesionarioId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Polizas", "ConcesionarioId", c => c.Int(nullable: false));
        }
    }
}
