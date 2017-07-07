using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBestRecipes.Models
{
	/// <summary>
	/// Join table between Recipe & Ingredient. In EF Core this is necessary. 
	/// http://www.learnentityframeworkcore.com/configuration/many-to-many-relationship-configuration
	/// </summary>
	public class RecipeIngredient
    {
		public int RecipeId { get; set; }
		public Recipe Recipe { get; set; }
		public int IngredientId { get; set; }
		public Ingredient Ingredient { get; set; }
	}
}
