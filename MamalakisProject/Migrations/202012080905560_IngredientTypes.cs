namespace MamalakisProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IngredientTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IngredientTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IngredientTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Ingredients", "IngredientTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Ingredients", "IngredientTypeId");
            AddForeignKey("dbo.Ingredients", "IngredientTypeId", "dbo.IngredientTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ingredients", "IngredientTypeId", "dbo.IngredientTypes");
            DropIndex("dbo.Ingredients", new[] { "IngredientTypeId" });
            DropColumn("dbo.Ingredients", "IngredientTypeId");
            DropTable("dbo.IngredientTypes");
        }
    }
}
