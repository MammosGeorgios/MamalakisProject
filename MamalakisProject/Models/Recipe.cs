﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MamalakisProject.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; }



        public int CreatorId { get; set; }

        public Creator Creator {get; set;}

        public ICollection<IngredientsPerRecipe> IngredientsPerRecipeId { get; set; }
    }
}