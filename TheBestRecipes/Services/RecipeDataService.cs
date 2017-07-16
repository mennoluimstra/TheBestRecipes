using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBestRecipes.Data;
using TheBestRecipes.Models;
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

		public async Task<bool> DeleteAsync(int id)
		{
			_unitOfWork.RecipeRepository.Delete(id);
			if (await _unitOfWork.SaveChangesAsync())
			{
				return true;
			}
			else
				return false;
		}

		public async Task<bool> DeleteAsync(Recipe recipe)
		{
			_unitOfWork.RecipeRepository.Delete(recipe);
			if (await _unitOfWork.SaveChangesAsync())
			{
				return true;
			}
			else
				return false;
		}

		public IList<RecipeViewModel> GetAllRecipes()
		{
			var result = _unitOfWork.RecipeRepository.Get().Select(r => 
							new RecipeViewModel
							{
								Id = r.Id,
								Title = r.Title,
								ImagePath = r.ImagePath ?? "not-available.jpg",
							}).ToList();
			return result;
		}

		public Recipe GetRecipe(int id)
		{
			return _unitOfWork.RecipeRepository.GetByID(id);
		}

		public async Task<bool> InsertAsync(Recipe recipe)
		{
			_unitOfWork.RecipeRepository.Insert(recipe);
			if (await _unitOfWork.SaveChangesAsync())
			{
				return true;
			}
			else
				return false;
		}

		public async Task<bool> UpdateAsync(Recipe recipe)
		{
			_unitOfWork.RecipeRepository.Update(recipe);
			if (await _unitOfWork.SaveChangesAsync())
			{
				return true;
			}
			else
				return false;
		}
	}
}
