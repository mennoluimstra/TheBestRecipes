using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheBestRecipes.Models;
using TheBestRecipes.Services;
using System;

namespace TheBestRecipes.Controllers.Web
{
	public class RecipesController : Controller
    {

		private readonly IRecipeDataService _recipeDataService;

		public RecipesController(IRecipeDataService recipeDataService)
        {
			_recipeDataService = recipeDataService;
		}

		// GET: Recipes
		public async Task<IActionResult> Index()
		{
			var recipes = await Task.Factory.StartNew(() => _recipeDataService.GetAllRecipes());
			return View(recipes);
		}

		// GET: Recipes/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var recipe = await Task.Factory.StartNew(() => _recipeDataService.GetRecipe((int)id));
			if (recipe == null)
			{
				return NotFound();
			}

			return View(recipe);
		}

        // GET: Recipes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Recipes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Rating,NumberOfPersons,Source,ImagePath")] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
				if(await _recipeDataService.InsertAsync(recipe))
					return RedirectToAction("Index");
				else
				{
					ModelState.AddModelError("", "Het recept kon helaas niet bewaard worden. Prebeer het nog eens");
					return View(recipe);
				}
            }
            return View(recipe);
        }

        // GET: Recipes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await Task<Recipe>.Factory.StartNew(()=> _recipeDataService.GetRecipe((int)id));
            if (recipe == null)
            {
                return NotFound();
            }
            return View(recipe);
        }

		// POST: Recipes/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Rating,NumberOfPersons,Source,ImagePath")] Recipe recipe)
		{
			if (id != recipe.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					await _recipeDataService.UpdateAsync(recipe);
				}
				catch (Exception)
				{
					if (!RecipeExists(recipe.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction("Index");
			}
			return View(recipe);
		}

        // GET: Recipes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

			var recipe = await Task.Factory.StartNew(() => _recipeDataService.GetRecipe((int)id));

			if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

		// POST: Recipes/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			if (await _recipeDataService.DeleteAsync(id))
			{
				return RedirectToAction("Index");
			}
			else
			{
				ModelState.AddModelError("", "Het recept kon helaas niet verwijderd worden.");
				return BadRequest(ModelState);
			}
		}

        private bool RecipeExists(int id)
        {
            return _recipeDataService.GetRecipe(id) != null;
        }
    }
}
