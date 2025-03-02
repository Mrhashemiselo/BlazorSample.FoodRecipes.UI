using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorSample.FoodRecipes.UI.Features.Home;

public partial class SearchPage
{
    [Parameter]
    public string SearchTerm { get; set; } = string.Empty;
    [Parameter, SupplyParameterFromQuery]
    public int MaxTime { get; set; }

    public IEnumerable<Recipe> _recipes { get; set; }
    public Recipe selectedRecipe { get; set; }
    protected async override Task OnInitializedAsync()
    {
        try
        {
            _recipes = (await _httpClient.GetFromJsonAsync<IEnumerable<Recipe>>("Data.json"))
                .Where(w => w.Name.Contains(SearchTerm) || w.Description.Contains(SearchTerm))
                .Where(a => MaxTime == 0 || a.TimeInMinutes <= MaxTime);


        }
        catch (Exception ex)
        {
            Console.WriteLine($"Badness => {ex.Message}");
        }
    }

    void OnSelectRecipeHandler(Recipe recipe)
    {
        selectedRecipe = recipe;
    }
}
