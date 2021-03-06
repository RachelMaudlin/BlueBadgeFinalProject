namespace BlueBadge.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestDatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderItems", "ShipDate", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderItems", "ShipDate", c => c.DateTime(nullable: false));
        }
    }
}
