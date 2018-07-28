namespace Quadridge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bank",
                c => new
                    {
                        BankId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.BankId);
            
            CreateTable(
                "dbo.ClientInteraction",
                c => new
                    {
                        ClientInterationId = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Comment = c.String(nullable: false, maxLength: 2000, unicode: false),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientInterationId)
                .ForeignKey("dbo.Client", t => t.ClientId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false, maxLength: 100, unicode: false),
                        Surname = c.String(nullable: false, maxLength: 100, unicode: false),
                        CompanyId = c.Int(),
                        Email = c.String(nullable: false, maxLength: 255, unicode: false),
                        CellNo = c.String(nullable: false, maxLength: 10, unicode: false),
                        BusinessNo = c.String(maxLength: 10, unicode: false),
                        FirstAddressLine = c.String(nullable: false, maxLength: 255, unicode: false),
                        SecondAddressLine = c.String(maxLength: 255, unicode: false),
                        City = c.String(nullable: false, maxLength: 100, unicode: false),
                        Zip = c.String(maxLength: 8, unicode: false),
                        Province = c.String(maxLength: 100, unicode: false),
                        Country = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.Company", t => t.CompanyId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255, unicode: false),
                        AddressLine1 = c.String(nullable: false, maxLength: 255, unicode: false),
                        AddressLine2 = c.String(maxLength: 255, unicode: false),
                        City = c.String(nullable: false, maxLength: 255, unicode: false),
                        Zip = c.String(maxLength: 8, unicode: false),
                        Province = c.String(maxLength: 100, unicode: false),
                        Country = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.Deal",
                c => new
                    {
                        DealId = c.Int(nullable: false, identity: true),
                        DealTypeId = c.Int(nullable: false),
                        RevenueId = c.Int(),
                        Date = c.DateTime(nullable: false),
                        BankId = c.Int(),
                        StatusId = c.Int(nullable: false),
                        LawyerId = c.Int(),
                    })
                .PrimaryKey(t => t.DealId)
                .ForeignKey("dbo.DealType", t => t.DealTypeId)
                .ForeignKey("dbo.Status", t => t.StatusId)
                .Index(t => t.DealTypeId)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.DealType",
                c => new
                    {
                        DealTypeId = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.DealTypeId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        StatusType = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.StatusId);
            
            CreateTable(
                "dbo.Expense",
                c => new
                    {
                        ExpenseId = c.Int(nullable: false, identity: true),
                        RevenueId = c.Int(nullable: false),
                        ExpenseTypeId = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ExpenseId)
                .ForeignKey("dbo.ExpenseType", t => t.ExpenseTypeId)
                .ForeignKey("dbo.Revenue", t => t.RevenueId)
                .Index(t => t.RevenueId)
                .Index(t => t.ExpenseTypeId);
            
            CreateTable(
                "dbo.ExpenseType",
                c => new
                    {
                        ExpenseTypeId = c.Int(nullable: false, identity: true),
                        ExpenseType = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ExpenseTypeId);
            
            CreateTable(
                "dbo.Revenue",
                c => new
                    {
                        RevenueId = c.Int(nullable: false, identity: true),
                        TotalRevenue = c.Double(nullable: false),
                        Profit = c.Double(),
                    })
                .PrimaryKey(t => t.RevenueId);
            
            CreateTable(
                "dbo.Interaction",
                c => new
                    {
                        InteractionId = c.Int(nullable: false, identity: true),
                        InteractionType = c.String(nullable: false, maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.InteractionId);
            
            CreateTable(
                "dbo.Lawyer",
                c => new
                    {
                        LawyerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        Surname = c.String(nullable: false, maxLength: 100, unicode: false),
                        Firm = c.String(maxLength: 100, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        ContactNo = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.LawyerId);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        Password = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Expense", "RevenueId", "dbo.Revenue");
            DropForeignKey("dbo.Expense", "ExpenseTypeId", "dbo.ExpenseType");
            DropForeignKey("dbo.Deal", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Deal", "DealTypeId", "dbo.DealType");
            DropForeignKey("dbo.Client", "CompanyId", "dbo.Company");
            DropForeignKey("dbo.ClientInteraction", "ClientId", "dbo.Client");
            DropIndex("dbo.Expense", new[] { "ExpenseTypeId" });
            DropIndex("dbo.Expense", new[] { "RevenueId" });
            DropIndex("dbo.Deal", new[] { "StatusId" });
            DropIndex("dbo.Deal", new[] { "DealTypeId" });
            DropIndex("dbo.Client", new[] { "CompanyId" });
            DropIndex("dbo.ClientInteraction", new[] { "ClientId" });
            DropTable("dbo.User");
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.Lawyer");
            DropTable("dbo.Interaction");
            DropTable("dbo.Revenue");
            DropTable("dbo.ExpenseType");
            DropTable("dbo.Expense");
            DropTable("dbo.Status");
            DropTable("dbo.DealType");
            DropTable("dbo.Deal");
            DropTable("dbo.Company");
            DropTable("dbo.Client");
            DropTable("dbo.ClientInteraction");
            DropTable("dbo.Bank");
        }
    }
}
