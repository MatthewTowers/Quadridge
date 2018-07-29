namespace Quadridge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateProvinces : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Provinces (Name) VALUES ('Eastern Cape'), ('Free State'), ('Gauteng'), ('KwaZulu Natal'), ('Limpopo'), ('Mpumalanga'), ('North West'), ('Northern Cape'),('Western Cape')");
        }
        
        public override void Down()
        {
        }
    }
}
