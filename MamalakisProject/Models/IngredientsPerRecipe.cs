using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MamalakisProject.Models
{
    public class IngredientsPerRecipe
    {
        [Key]
        [Column(Order=1)]
        public int RecipeId { get; set; }

        [Key]
        [Column(Order = 2)]

        public int IngredientId { get; set; }

        public int MetricId { get; set; }

        public Recipe Recipe { get; set; }

        public Metric Metric { get; set; }

        public Ingredient Ingredients { get; set; }
    }
}