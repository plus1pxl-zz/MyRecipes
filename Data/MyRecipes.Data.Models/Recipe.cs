using System.Collections.Generic;

namespace MyRecipes.Data.Models
{
    using System;
    using MyRecipes.Data.Common.Models;

    public class Recipe : BaseDeletableModel<int>
    {

        public string Name { get; set; }

        public string Instructions { get; set; }

        public TimeSpan PreparationTime { get; set; }

        public TimeSpan CookingTime { get; set; }

        public int PortionCount { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<RecipeIngredient> Ingredients { get; set; } = new HashSet<RecipeIngredient>();
    }
}
