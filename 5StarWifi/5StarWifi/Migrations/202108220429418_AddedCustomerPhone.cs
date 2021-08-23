namespace _5StarWifi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCustomerPhone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Phone", c => c.String(maxLength: 25));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Phone");
        }
    }
}
