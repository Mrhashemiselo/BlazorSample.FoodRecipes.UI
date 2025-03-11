using FluentValidation;

namespace BlazorSample.FoodRecipes.Shared.Features.ManageRecipes;

public class IngredientDtoValidator : AbstractValidator<IngredientDto>
{
    public IngredientDtoValidator()
    {
        RuleFor(r => r.Name).NotEmpty().WithMessage("Please enter a name");
    }
}