using System;
using System.Threading.Tasks;
using TheBestRecipes.Models;

namespace TheBestRecipes.Data
{
	public interface IUnitOfWork : IDisposable
    {
		IRepository<Recipe> RecipeRepository { get; }
		Task<bool> SaveChangesAsync();
	}
}
