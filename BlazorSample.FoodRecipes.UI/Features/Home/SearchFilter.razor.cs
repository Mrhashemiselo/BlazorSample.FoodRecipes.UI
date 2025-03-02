using Microsoft.AspNetCore.Components;

namespace BlazorSample.FoodRecipes.UI.Features.Home;

public partial class SearchFilter
{
    [Parameter]
    public int MaxTime { get; set; }
    [Parameter, EditorRequired]
    public string SearchTerm { get; set; } = string.Empty;

    private void Filter()
    {
        var myNewAddress = _navigationManager.GetUriWithQueryParameter("MaxTime", MaxTime);
        _navigationManager.NavigateTo(myNewAddress);
    }

    private void Clear()
    {
        MaxTime = 0;
        _navigationManager.NavigateTo($"/search/{SearchTerm}");
    }
}
