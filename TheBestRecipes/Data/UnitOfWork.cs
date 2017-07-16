using System;
using System.Threading.Tasks;
using TheBestRecipes.Models;

namespace TheBestRecipes.Data
{
	public class UnitOfWork : IUnitOfWork, IDisposable
	{
		private ApplicationDbContext _context;
		private IRepository<Recipe> recipeRepository;

		public IRepository<Recipe> RecipeRepository
		{
			get
			{

				if (this.recipeRepository == null)
				{
					this.recipeRepository = new Repository<Recipe>(_context);
				}
				return recipeRepository;
			}
		}

		public UnitOfWork(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<bool> SaveChangesAsync()
		{
			return (await _context.SaveChangesAsync()) > 0;
		}

		private bool disposed = false;

		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					_context.Dispose();
				}
			}
			this.disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
