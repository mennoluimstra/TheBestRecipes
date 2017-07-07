using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TheBestRecipes.Business;
using TheBestRecipes.Data;
using TheBestRecipes.ViewModels;

namespace TheBestRecipes.Controllers.Web
{
	public class HomeController : Controller
	{
		private readonly IRecipeManager _recipemanager;

		public HomeController(IRecipeManager recipemanager)
		{
			_recipemanager = recipemanager;
		}

		public IActionResult Index()
		{
			var recipes = _recipemanager.GetAllRecipes();
			return View(recipes);
		}

		public IActionResult Recipe()
		{
			var model = new RecipeCompleteViewModel { Name = "Brit­se cot­ta­ge pie", Image = "Britse-cottage-pie.jpg" };
			return View(model);
		}

		[HttpPost]
		public IActionResult Recipe(RecipeCompleteViewModel model)
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
