namespace HamburgerShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderSum_added_rev02 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderSums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalSum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MenuSum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExtraSum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrderSums");
        }
    }
}
