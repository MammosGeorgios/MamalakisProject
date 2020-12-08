namespace MamalakisProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIngredient : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Ingredients", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ingredients", "Type", c => c.String());
        }
    }
}
