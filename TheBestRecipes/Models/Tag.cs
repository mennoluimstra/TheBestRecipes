﻿using System.Collections.Generic;

namespace TheBestRecipes.Models
{
	public class Tag
    {
        public int Id { get; set; }
        public string Title { get; set; }
		public ICollection<RecipeTag> RecipeTags { get; set; }
	}
}