namespace BlueBadge.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovedPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VideoGames", "Price", c => c.Double(nullable: false));
            DropColumn("dbo.OrderItems", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderItems", "Price", c => c.Double(nullable: false));
            DropColumn("dbo.VideoGames", "Price");
        }
    }
}
