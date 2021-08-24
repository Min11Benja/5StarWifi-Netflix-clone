namespace _5StarWifi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedImagePath : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ImgPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "ImgPath");
        }
    }
}
