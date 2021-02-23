namespace BlueBadge.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.VideoGames", "IsOnline");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VideoGames", "IsOnline", c => c.Boolean(nullable: false));
        }
    }
}
