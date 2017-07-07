using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBestRecipes.Models;

namespace TheBestRecipes.Data
{
    public class SeedData
    {
		private ApplicationDbContext _context;

		public SeedData(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task EnsureSeedData()
		{
			if (!_context.Recipes.Any())
			{
				_context.Recipes.Add(new Recipe { Title = "Wok­scho­tel met run­der­reep­jes en pak­soi", ImagePath = "Wokschotel-met-runderreepjes-en-paksoi.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Spi­na­zie­cur­ry met kaas en naan­brood", ImagePath = "Spinaziecurry-met-kaas-en-naan­brood.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Brit­se cot­ta­ge pie", ImagePath = "Britse-cottage-pie.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Wok­scho­tel met run­der­reep­jes en pak­soi", ImagePath = "Wokschotel-met-runderreepjes-en-paksoi.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Spi­na­zie­cur­ry met kaas en naan­brood", ImagePath = "Spinaziecurry-met-kaas-en-naan­brood.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Brit­se cot­ta­ge pie", ImagePath = "Britse-cottage-pie.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Wok­scho­tel met run­der­reep­jes en pak­soi", ImagePath = "Wokschotel-met-runderreepjes-en-paksoi.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Spi­na­zie­cur­ry met kaas en naan­brood", ImagePath = "Spinaziecurry-met-kaas-en-naan­brood.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Brit­se cot­ta­ge pie", ImagePath = "Britse-cottage-pie.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Wok­scho­tel met run­der­reep­jes en pak­soi", ImagePath = "Wokschotel-met-runderreepjes-en-paksoi.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Spi­na­zie­cur­ry met kaas en naan­brood", ImagePath = "Spinaziecurry-met-kaas-en-naan­brood.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Brit­se cot­ta­ge pie", ImagePath = "Britse-cottage-pie.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Wok­scho­tel met run­der­reep­jes en pak­soi", ImagePath = "Wokschotel-met-runderreepjes-en-paksoi.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Spi­na­zie­cur­ry met kaas en naan­brood", ImagePath = "Spinaziecurry-met-kaas-en-naan­brood.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Brit­se cot­ta­ge pie", ImagePath = "Britse-cottage-pie.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Wok­scho­tel met run­der­reep­jes en pak­soi", ImagePath = "Wokschotel-met-runderreepjes-en-paksoi.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Spi­na­zie­cur­ry met kaas en naan­brood", ImagePath = "Spinaziecurry-met-kaas-en-naan­brood.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Brit­se cot­ta­ge pie", ImagePath = "Britse-cottage-pie.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Wok­scho­tel met run­der­reep­jes en pak­soi", ImagePath = "Wokschotel-met-runderreepjes-en-paksoi.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Spi­na­zie­cur­ry met kaas en naan­brood", ImagePath = "Spinaziecurry-met-kaas-en-naan­brood.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Brit­se cot­ta­ge pie", ImagePath = "Britse-cottage-pie.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Wok­scho­tel met run­der­reep­jes en pak­soi", ImagePath = "Wokschotel-met-runderreepjes-en-paksoi.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Spi­na­zie­cur­ry met kaas en naan­brood", ImagePath = "Spinaziecurry-met-kaas-en-naan­brood.jpg" });
				_context.Recipes.Add(new Recipe { Title = "Brit­se cot­ta­ge pie", ImagePath = "Britse-cottage-pie.jpg" });

				await _context.SaveChangesAsync();
			}
		}

	}
}
