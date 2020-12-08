namespace MamalakisProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShortName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Metrics", "ShortName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Metrics", "ShortName");
        }
    }
}
