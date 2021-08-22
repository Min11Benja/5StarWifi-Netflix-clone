namespace _5StarWifi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStartEndDateVarChar10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "StartDate", c => c.String(maxLength: 10));
            AddColumn("dbo.Customers", "EndDate", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "EndDate");
            DropColumn("dbo.Customers", "StartDate");
        }
    }
}
