using System.Collections.Generic;

namespace TheBestRecipes.Models
{
	public class Step
    {
        public int Id { get; set; }
        public int Index { get; set; }
        public string Description { get; set; }
		public Recipe Recipe { get; set; }
	}
}