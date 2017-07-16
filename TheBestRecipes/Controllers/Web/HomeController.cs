using Microsoft.AspNetCore.Mvc;
using TheBestRecipes.Models;
using TheBestRecipes.Services;
using TheBestRecipes.ViewModels;

namespace TheBestRecipes.Controllers.Web
{
	public class HomeController : Controller
	{
		private readonly IRecipeDataService _recipeDataService;

		public HomeController(IRecipeDataService recipeDataService)
		{
			_recipeDataService = recipeDataService;
		}

		public IActionResult Index()
		{
			var recipes = _recipeDataService.GetAllRecipes();
			return View(recipes);
		}

		public IActionResult Recipe()
		{
			var model = _recipeDataService.GetRecipe(1); //todo: get the id.
			return View(model);
		}

		[HttpPost]
		public IActionResult Recipe(Recipe model)
		{
			if (ModelState.IsValid)
			{
				// todo: save in db.

				// todo: clear model state.
				//ModelState.Clear();
				// return the returned recipe.
			}

			return View(model);
		}
	}
}
