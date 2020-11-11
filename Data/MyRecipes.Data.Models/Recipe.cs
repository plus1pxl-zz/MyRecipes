namespace MyRecipes.Data.Models
{
    using System;
    using MyRecipes.Data.Common.Models;

    public class Recipe : BaseDeletableModel<int>
    {
        public TimeSpan PreparationTime { get; set; }

        public TimeSpan CookingTime { get; set; }

        public int PortionCount { get; set; }
    }
}
