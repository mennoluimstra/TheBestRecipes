namespace TheBestRecipes.Models
{
	public class RecipeStep
    {
		public int RecipeId { get; set; }
		public Recipe Recipe { get; set; }
		public int StepId { get; set; }
		public Step Step { get; set; }
	}
}
