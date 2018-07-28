namespace Quadridge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientInteractionsCascadeOnDelete : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClientInteraction", "ClientId", "dbo.Client");
            AddForeignKey("dbo.ClientInteraction", "ClientId", "dbo.Client", "ClientId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientInteraction", "ClientId", "dbo.Client");
            AddForeignKey("dbo.ClientInteraction", "ClientId", "dbo.Client", "ClientId");
        }
    }
}
