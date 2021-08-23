namespace _5StarWifi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPaymentStatusToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "PaymentStatus", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "PaymentStatus");
        }
    }
}
