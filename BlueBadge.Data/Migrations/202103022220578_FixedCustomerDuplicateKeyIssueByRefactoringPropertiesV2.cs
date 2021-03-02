namespace BlueBadge.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedCustomerDuplicateKeyIssueByRefactoringPropertiesV2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                {
                    CustomerId = c.Int(nullable: false, identity: true),
                    OwnerId = c.Guid(nullable: false),
                    FirstName = c.String(),
                    LastName = c.String(),
                    Email = c.String(),
                    ShippingAddress = c.String(),
                    CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                    ModifiedUtc = c.DateTimeOffset(precision: 7),
                })
                .PrimaryKey(t => t.CustomerId);
        }
        
        public override void Down()
        {
            DropTable("dbo.Customer");
        }
    }
}
