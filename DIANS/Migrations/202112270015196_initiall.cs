namespace DIANS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initiall : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.bars");
            DropPrimaryKey("dbo.restaurants");
            AlterColumn("dbo.bars", "id", c => c.Int(nullable: false));
            AlterColumn("dbo.restaurants", "id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.bars", "ID");
            AddPrimaryKey("dbo.restaurants", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.restaurants");
            DropPrimaryKey("dbo.bars");
            AlterColumn("dbo.restaurants", "id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.bars", "id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.restaurants", "id");
            AddPrimaryKey("dbo.bars", "id");
        }
    }
}
