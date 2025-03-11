using FluentValidation;

namespace BlazorSample.FoodRecipes.Shared.Features.ManageRecipes;

public class RecipeDtoValidator : AbstractValidator<RecipeDto>
{
    public RecipeDtoValidator()
    {
        RuleFor(r => r.Name).NotEmpty().WithMessage("Please enter a name");
        RuleFor(r => r.Description).NotEmpty().WithMessage("Please enter a description");
        RuleFor(r => r.Originality).NotEmpty().WithMessage("Please enter an originality");
        RuleFor(r => r.Price).GreaterThan(0).WithMessage("Please enter a value greater then 0");
        RuleFor(r => r.TimeInMinutes).GreaterThan(0).WithMessage("Please enter a value greater then 0");
        RuleFor(r => r.Ingredients).NotEmpty().WithMessage("Please enter an ingredient");
        RuleForEach(r => r.Ingredients).SetValidator(new IngredientDtoValidator());
    }
}