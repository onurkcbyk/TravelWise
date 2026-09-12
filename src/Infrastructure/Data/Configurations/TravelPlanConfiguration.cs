using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelWise.Domain.Entities;
using TravelWise.Infrastructure.Identity;

namespace TravelWise.Infrastructure.Data.Configurations;

public class TravelPlanConfiguration : IEntityTypeConfiguration<TravelPlan>
{
    public void Configure(EntityTypeBuilder<TravelPlan> builder)
    {
        builder.ToTable("TravelPlans");

        builder.Property(x => x.UserId)
            .IsRequired();

        builder.Property(x => x.Title)
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.Notes)
            .HasMaxLength(2000);

        builder.Property(x => x.BudgetAmount)
            .HasPrecision(18, 2);

        builder.Property(x => x.BudgetCurrencyCode)
            .HasMaxLength(3);

        builder.HasIndex(x => x.UserId);

        builder.HasOne<ApplicationUser>()
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.Places)
            .WithOne(x => x.TravelPlan)
            .HasForeignKey(x => x.TravelPlanId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
