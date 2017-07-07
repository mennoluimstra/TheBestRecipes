using System.Collections.Generic;
using TheBestRecipes.ViewModels;

namespace TheBestRecipes.Business
{
	public interface IRecipeManager
	{
		IList<RecipeViewModel> GetAllRecipes();
	}
}