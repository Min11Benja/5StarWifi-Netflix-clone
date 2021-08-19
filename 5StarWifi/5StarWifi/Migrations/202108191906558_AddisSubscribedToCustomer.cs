namespace _5StarWifi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddisSubscribedToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "isSubscribedToCustomer", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "isSubscribedToCustomer");
        }
    }
}
