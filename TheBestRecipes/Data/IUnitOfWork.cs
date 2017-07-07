using System;
using TheBestRecipes.Models;

namespace TheBestRecipes.Data
{
	public interface IUnitOfWork : IDisposable
    {
		IRepository<Recipe> RecipeRepository { get; }
		void Save();
	}
}
