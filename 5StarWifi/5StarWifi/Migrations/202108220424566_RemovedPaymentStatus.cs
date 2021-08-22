namespace _5StarWifi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedPaymentStatus : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "PaymentStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "PaymentStatus", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
