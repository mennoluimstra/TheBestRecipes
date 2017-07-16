using System.Collections.Generic;
using System.Threading.Tasks;
using TheBestRecipes.Models;
using TheBestRecipes.ViewModels;

namespace TheBestRecipes.Services
{
	public interface IRecipeDataService
	{
		Task<bool> DeleteAsync(int id);
		Task<bool> DeleteAsync(Recipe recipe);
		IList<RecipeViewModel> GetAllRecipes();
		Recipe GetRecipe(int id);
		Task<bool> InsertAsync(Recipe recipe);
		Task<bool> UpdateAsync(Recipe recipe);
	}
}