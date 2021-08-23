namespace _5StarWifi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedViewCount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ViewCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "ViewCount");
        }
    }
}
