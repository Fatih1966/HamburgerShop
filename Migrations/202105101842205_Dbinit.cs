namespace HamburgerShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dbinit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Extras",
                c => new
                    {
                        ExtraId = c.Int(nullable: false, identity: true),
                        ExtraName = c.String(),
                        ExtraPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Order_OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.ExtraId)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .Index(t => t.Order_OrderId);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        MenuId = c.Int(nullable: false, identity: true),
                        MenuName = c.String(),
                        MenuPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MenuId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderTakenBy = c.String(),
                        OrderDate = c.DateTime(nullable: false),
                        SelectedSize = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MenusAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExtrasAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Menu_MenuId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Menus", t => t.Menu_MenuId)
                .Index(t => t.Menu_MenuId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Menu_MenuId", "dbo.Menus");
            DropForeignKey("dbo.Extras", "Order_OrderId", "dbo.Orders");
            DropIndex("dbo.Orders", new[] { "Menu_MenuId" });
            DropIndex("dbo.Extras", new[] { "Order_OrderId" });
            DropTable("dbo.Orders");
            DropTable("dbo.Menus");
            DropTable("dbo.Extras");
        }
    }
}
