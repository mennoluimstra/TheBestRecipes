using System.Collections.Generic;
using System.Linq;
using TheBestRecipes.Data;
using TheBestRecipes.ViewModels;

namespace TheBestRecipes.Business
{
	public class RecipeManager : IRecipeManager
	{
		private IUnitOfWork _unitOfWork;

		public RecipeManager(IUnitOfWork unitOfWork)
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
								Image = r.ImagePath
							}).ToList();
			return result;
		}
    }
}
