using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheBestRecipes.Models;

namespace TheBestRecipes.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{


		}

		public DbSet<Recipe> Recipes { get; set; }
		public DbSet<Ingredient> Ingredients { get; set; }
		public DbSet<Step> Steps { get; set; }
		public DbSet<Tag> Tags { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			// Customize the ASP.NET Identity model and override the defaults if needed.
			// For example, you can rename the ASP.NET Identity table names and more.
			// Add your customizations after calling base.OnModelCreating(builder);


			// The relationship also needs to be configured via the Fluent API for
			// EF Core 1.1.0 to be able to map it successfully
			// http://www.learnentityframeworkcore.com/configuration/many-to-many-relationship-configuration

			#region RecipeIngredient

			builder.Entity<RecipeIngredient>()
				.HasKey(bc => new { bc.RecipeId, bc.IngredientId });

			builder.Entity<RecipeIngredient>()
				.HasOne(bc => bc.Recipe)
				.WithMany(b => b.RecipeIngredients)
				.HasForeignKey(bc => bc.RecipeId);

			builder.Entity<RecipeIngredient>()
				.HasOne(bc => bc.Ingredient)
				.WithMany(c => c.RecipeIngredients)
				.HasForeignKey(bc => bc.IngredientId);

			#endregion RecipeIngredient

			#region RecipeStep

			builder.Entity<RecipeStep>()
				.HasKey(bc => new { bc.RecipeId, bc.StepId });

			builder.Entity<RecipeStep>()
				.HasOne(bc => bc.Recipe)
				.WithMany(b => b.RecipeSteps)
				.HasForeignKey(bc => bc.RecipeId);

			builder.Entity<RecipeStep>()
				.HasOne(bc => bc.Step)
				.WithMany(c => c.RecipeSteps)
				.HasForeignKey(bc => bc.StepId);

			#endregion RecipeStep

			#region RecipeTag

			builder.Entity<RecipeTag>()
				.HasKey(bc => new { bc.RecipeId, bc.TagId });

			builder.Entity<RecipeTag>()
				.HasOne(bc => bc.Recipe)
				.WithMany(b => b.RecipeTags)
				.HasForeignKey(bc => bc.RecipeId);

			builder.Entity<RecipeTag>()
				.HasOne(bc => bc.Tag)
				.WithMany(c => c.RecipeTags)
				.HasForeignKey(bc => bc.TagId);

			#endregion RecipeTag
		}
	}
}
