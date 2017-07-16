namespace TheBestRecipes.ViewModels
{
	/// A subset of Recipe used to display the list on the main page.
	public class RecipeViewModel
    {
		public int Id { get; set; }
		public string Title { get; set; }
		public string ImagePath { get; set; }
	}
}
