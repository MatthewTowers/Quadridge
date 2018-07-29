namespace Quadridge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToDeal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Deal", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Deal", "Name");
        }
    }
}
