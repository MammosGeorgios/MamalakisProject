using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MamalakisProject.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //public string Type { get; set; }

        [Display(Name="Ingredient Type") ]
        public int IngredientTypeId { get; set; }
        public IngredientType IngredientType { get; set; }
        public ICollection<IngredientsPerRecipe> IngredientsPerRecipeId { get; set; }
    }
}