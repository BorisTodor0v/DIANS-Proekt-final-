namespace DIANS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracija : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.bars");
            DropPrimaryKey("dbo.restaurants");
            AddColumn("dbo.bars", "br", c => c.Int(nullable: false));
            AddColumn("dbo.restaurants", "br", c => c.Int(nullable: false));
            AlterColumn("dbo.bars", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.restaurants", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.bars", "ID");
            AddPrimaryKey("dbo.restaurants", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.restaurants");
            DropPrimaryKey("dbo.bars");
            AlterColumn("dbo.restaurants", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.bars", "ID", c => c.Int(nullable: false));
            DropColumn("dbo.restaurants", "br");
            DropColumn("dbo.bars", "br");
            AddPrimaryKey("dbo.restaurants", "ID");
            AddPrimaryKey("dbo.bars", "ID");
        }
    }
}
