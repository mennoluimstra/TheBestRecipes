using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheBestRecipes.ViewModels;

namespace TheBestRecipes.Controllers.Web
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			var recipeList = new List<RecipeViewModel>()
			{
				new RecipeViewModel { Name = "Wok­scho­tel met run­der­reep­jes en pak­soi", Image="Wokschotel-met-runderreepjes-en-paksoi.jpg" },
				new RecipeViewModel{ Name = "Spi­na­zie­cur­ry met kaas en naan­brood", Image="Spinaziecurry-met-kaas-en-naan­brood.jpg" },
				new RecipeViewModel { Name = "Brit­se cot­ta­ge pie", Image="Britse-cottage-pie.jpg" },
				new RecipeViewModel { Name = "Wok­scho­tel met run­der­reep­jes en pak­soi", Image="Wokschotel-met-runderreepjes-en-paksoi.jpg" },
				new RecipeViewModel{ Name = "Spi­na­zie­cur­ry met kaas en naan­brood", Image="Spinaziecurry-met-kaas-en-naan­brood.jpg" },
				new RecipeViewModel { Name = "Brit­se cot­ta­ge pie", Image="Britse-cottage-pie.jpg" },
				new RecipeViewModel { Name = "Wok­scho­tel met run­der­reep­jes en pak­soi", Image="Wokschotel-met-runderreepjes-en-paksoi.jpg" },
				new RecipeViewModel{ Name = "Spi­na­zie­cur­ry met kaas en naan­brood", Image="Spinaziecurry-met-kaas-en-naan­brood.jpg" },
				new RecipeViewModel { Name = "Brit­se cot­ta­ge pie", Image="Britse-cottage-pie.jpg" },
				new RecipeViewModel { Name = "Wok­scho­tel met run­der­reep­jes en pak­soi", Image="Wokschotel-met-runderreepjes-en-paksoi.jpg" },
				new RecipeViewModel{ Name = "Spi­na­zie­cur­ry met kaas en naan­brood", Image="Spinaziecurry-met-kaas-en-naan­brood.jpg" },
				new RecipeViewModel { Name = "Brit­se cot­ta­ge pie", Image="Britse-cottage-pie.jpg" },
				new RecipeViewModel { Name = "Wok­scho­tel met run­der­reep­jes en pak­soi", Image="Wokschotel-met-runderreepjes-en-paksoi.jpg" },
				new RecipeViewModel{ Name = "Spi­na­zie­cur­ry met kaas en naan­brood", Image="Spinaziecurry-met-kaas-en-naan­brood.jpg" },
				new RecipeViewModel { Name = "Brit­se cot­ta­ge pie", Image="Britse-cottage-pie.jpg" },

			};
			return View(recipeList);
		}
	}
}
