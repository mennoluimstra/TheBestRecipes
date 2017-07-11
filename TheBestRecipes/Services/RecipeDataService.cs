using System.Collections.Generic;
using System.Linq;
using TheBestRecipes.Data;
using TheBestRecipes.ViewModels;

namespace TheBestRecipes.Services
{
	public class RecipeDataService : IRecipeDataService
	{
		private IUnitOfWork _unitOfWork;

		public RecipeDataService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public IList<RecipeViewModel> GetAllRecipes()
		{
			var result = _unitOfWork.RecipeRepository.Get().Select(r => 
							new RecipeViewModel
							{
								Name = r.Title,
								Description = r.Description,
								Image = r.ImagePath,
							}).ToList();
			return result;
		}

		public RecipeCompleteViewModel GetRecipe(int id)
		{
			var result = _unitOfWork.RecipeRepository.GetByID(id);
			return new RecipeCompleteViewModel
			{
				Name = result.Title,
				Description = result.Description,
				Image = result.ImagePath,
			};
		}
	}
}
