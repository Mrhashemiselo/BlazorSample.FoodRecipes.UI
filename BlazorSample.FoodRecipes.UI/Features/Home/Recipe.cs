namespace BlazorSample.FoodRecipes.UI.Features.Home;

public class Recipe
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    public string Originality { get; set; }
    public int TimeInMinutes { get; set; }
    public int Price { get; set; }
    public IEnumerable<Ingredient> Ingredients { get; set; } = Enumerable.Empty<Ingredient>();
}
