namespace _5StarWifi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMovieRating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Rating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Rating");
        }
    }
}
