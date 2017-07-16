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
				var recipe1 = new Recipe
				{
					Title = "Wok­scho­tel met run­der­reep­jes en pak­soi",
					ImagePath = "Wokschotel-met-runderreepjes-en-paksoi.jpg",
				};

				var steps = new List<Step>
				{
					new Step { Index = 0, Description = "Paksoi schoonmaken en in reepjes snijden.", Recipe = recipe1 },
					new Step { Index = 1, Description = "Paprika schoonmaken en in stukjes snijden.", Recipe = recipe1 },
					new Step { Index = 2, Description = "Bosui schoonmaken en in ringetjes snijden.", Recipe = recipe1 },
					new Step { Index = 3, Description = "In wok olie verhitten en vlees 5 min. bakken.", Recipe = recipe1 },
					new Step { Index = 4, Description = "Paprika 2 min. meebakken.", Recipe = recipe1 },
					new Step { Index = 5, Description = "Paksoi in gedeelten toevoegen en roerbakken tot het slinkt.", Recipe = recipe1 },
					new Step { Index = 6, Description = "Roerbaksaus door mengsel roeren.", Recipe = recipe1 },
					new Step { Index = 7, Description = "Noodles erdoor scheppen en 2 min. mee verwarmen.", Recipe = recipe1 },
					new Step { Index = 8, Description = "Wokschotel over vier borden verdelen en met bosui bestrooien.", Recipe = recipe1 },
					new Step { Index = 9, Description = "Lekker met cassavekroepoek.", Recipe = recipe1 },
				};

				_context.Recipes.Add(recipe1);
				_context.Steps.AddRange(steps);
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
