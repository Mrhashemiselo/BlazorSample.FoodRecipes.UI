using BlazorSample.FoodRecipes.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorSample.FoodRecipes.DAL.Configurations;
public class RecipeConfig : IEntityTypeConfiguration<Recipe>
{
    public void Configure(EntityTypeBuilder<Recipe> builder)
    {
        builder.Property(p => p.Name)
               .IsRequired()
               .HasMaxLength(200);
        builder.Property(p => p.ImageUrl)
               .IsRequired()
               .HasMaxLength(200);
        builder.Property(p => p.Description)
               .IsRequired();
        builder.Property(p => p.Originality)
               .IsRequired()
               .HasMaxLength(200);
    }
}
