using BlazorSample.FoodRecipes.DAL.Configurations;
using BlazorSample.FoodRecipes.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorSample.FoodRecipes.DAL;

public class FoodRecipeDbContext : DbContext
{
    public FoodRecipeDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new RecipeConfig());
        modelBuilder.ApplyConfiguration(new IngredientConfig());
    }
}
