namespace DIANS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.bars",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        lon = c.String(),
                        lat = c.String(),
                        amenity = c.String(),
                        name = c.String(),
                        cuisine = c.String(),
                        opening_hours = c.String(),
                        takeaway = c.String(),
                        phone = c.String(),
                        website = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.restaurants",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        lon = c.String(),
                        lat = c.String(),
                        amenity = c.String(),
                        name = c.String(),
                        cuisine = c.String(),
                        opening_hours = c.String(),
                        takeaway = c.String(),
                        phone = c.String(),
                        website = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.restaurants");
            DropTable("dbo.bars");
        }
    }
}
