using System.Collections.Generic;
using TheBestRecipes.ViewModels;

namespace TheBestRecipes.Services
{
	public interface IRecipeDataService
	{
		IList<RecipeViewModel> GetAllRecipes();

		RecipeCompleteViewModel GetRecipe(int id);
	}
}