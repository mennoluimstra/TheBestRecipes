using System.Collections.Generic;

namespace TheBestRecipes.Models
{
	public class Ingredient
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Unit Unit { get; set; }
        public string Description { get; set; }
		public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
	}
}