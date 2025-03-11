using BlazorSample.FoodRecipes.DAL;
using BlazorSample.FoodRecipes.DAL.Entities;
using BlazorSample.FoodRecipes.Shared.Features.ManageRecipes;
using Microsoft.AspNetCore.Mvc;

namespace BlazorSample.FoodRecipes.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class RecipeController(FoodRecipeDbContext dbContext,
                              ILogger<RecipeController> logger) : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> Add(RecipeDto model)
    {
        try
        {
            Recipe recipe = new()
            {
                Name = model.Name,
                Description = model.Description,
                Originality = model.Originality,
                Price = model.Price,
                TimeInMinutes = model.TimeInMinutes,
                ImageUrl = "https://png.pngtree.com/thumb_back/fw800/background/20250227/pngtree-ramadan-mubarak-iftar-theme-background-vector-art-image_17007039.jpg",
                Ingredients = model.Ingredients.Select(s => new Ingredient()
                {
                    Name = s.Name
                }).ToList()
            };
            await dbContext.AddAsync(recipe);
            await dbContext.SaveChangesAsync();
            return Ok(recipe.Id);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Badness");
            return BadRequest(-1);
        }

    }
}
