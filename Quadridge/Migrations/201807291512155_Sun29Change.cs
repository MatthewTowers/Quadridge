namespace Quadridge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sun29Change : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Deal", "BankId");
            CreateIndex("dbo.Deal", "LawyerId");
            AddForeignKey("dbo.Deal", "BankId", "dbo.Bank", "BankId");
            AddForeignKey("dbo.Deal", "LawyerId", "dbo.Lawyer", "LawyerId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Deal", "LawyerId", "dbo.Lawyer");
            DropForeignKey("dbo.Deal", "BankId", "dbo.Bank");
            DropIndex("dbo.Deal", new[] { "LawyerId" });
            DropIndex("dbo.Deal", new[] { "BankId" });
        }
    }
}
