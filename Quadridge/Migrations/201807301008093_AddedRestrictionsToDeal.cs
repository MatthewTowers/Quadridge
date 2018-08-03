namespace Quadridge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRestrictionsToDeal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Deal", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Deal", "Name", c => c.String());
        }
    }
}
