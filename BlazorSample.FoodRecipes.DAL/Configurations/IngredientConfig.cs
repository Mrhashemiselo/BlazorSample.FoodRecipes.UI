using BlazorSample.FoodRecipes.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorSample.FoodRecipes.DAL.Configurations;

public class IngredientConfig : IEntityTypeConfiguration<Ingredient>
{
    public void Configure(EntityTypeBuilder<Ingredient> builder)
    {
        builder.Property(p => p.Name)
               .IsRequired()
               .HasMaxLength(200);
    }
}
