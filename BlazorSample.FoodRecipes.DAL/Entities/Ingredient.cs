namespace BlazorSample.FoodRecipes.DAL.Entities;

public class Ingredient
{
    public int Id { get; set; }
    public string Name { get; set; }

    #region Relations
    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; }
    #endregion
}