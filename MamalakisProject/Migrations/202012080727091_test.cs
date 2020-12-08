namespace MamalakisProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Creators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IngredientsPerRecipes",
                c => new
                    {
                        RecipeId = c.Int(nullable: false),
                        IngredientId = c.Int(nullable: false),
                        MetricId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RecipeId, t.IngredientId })
                .ForeignKey("dbo.Ingredients", t => t.IngredientId, cascadeDelete: true)
                .ForeignKey("dbo.Metrics", t => t.MetricId, cascadeDelete: true)
                .ForeignKey("dbo.Recipes", t => t.RecipeId, cascadeDelete: true)
                .Index(t => t.RecipeId)
                .Index(t => t.IngredientId)
                .Index(t => t.MetricId);
            
            CreateTable(
                "dbo.Metrics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Creators", t => t.CreatorId, cascadeDelete: true)
                .Index(t => t.CreatorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IngredientsPerRecipes", "RecipeId", "dbo.Recipes");
            DropForeignKey("dbo.Recipes", "CreatorId", "dbo.Creators");
            DropForeignKey("dbo.IngredientsPerRecipes", "MetricId", "dbo.Metrics");
            DropForeignKey("dbo.IngredientsPerRecipes", "IngredientId", "dbo.Ingredients");
            DropIndex("dbo.Recipes", new[] { "CreatorId" });
            DropIndex("dbo.IngredientsPerRecipes", new[] { "MetricId" });
            DropIndex("dbo.IngredientsPerRecipes", new[] { "IngredientId" });
            DropIndex("dbo.IngredientsPerRecipes", new[] { "RecipeId" });
            DropTable("dbo.Recipes");
            DropTable("dbo.Metrics");
            DropTable("dbo.IngredientsPerRecipes");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Creators");
        }
    }
}
