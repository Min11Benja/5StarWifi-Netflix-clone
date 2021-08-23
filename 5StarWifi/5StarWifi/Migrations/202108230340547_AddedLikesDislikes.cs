namespace _5StarWifi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLikesDislikes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Likes", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Dislikes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Dislikes");
            DropColumn("dbo.Movies", "Likes");
        }
    }
}
