using System.Collections.Generic;

namespace TheBestRecipes.Models
{
	public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int NumberOfPersons { get; set; }
		public ICollection<Step> Steps { get; set; }
		public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
        public ICollection<RecipeTag> RecipeTags { get; set; }
        public string Source { get; set; }
        public string ImagePath { get; set; }
    }
}