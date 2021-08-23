namespace _5StarWifi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMovieSourcePath : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "SrcPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "SrcPath");
        }
    }
}
