namespace Ctm_Col.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changearenotchanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Polizas", "ConcesionarioId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Polizas", "ConcesionarioId");
        }
    }
}
