using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelWise.Domain.Entities;

namespace TravelWise.Infrastructure.Data.Configurations;

public class TravelPlanPlaceConfiguration : IEntityTypeConfiguration<TravelPlanPlace>
{
    public void Configure(EntityTypeBuilder<TravelPlanPlace> builder)
    {
        builder.ToTable("TravelPlanPlaces");

        builder.Property(x => x.SourceProvider)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(x => x.ExternalPlaceId)
            .HasMaxLength(500)
            .IsRequired();

        builder.Property(x => x.Name)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(x => x.City)
            .HasMaxLength(150);

        builder.Property(x => x.CountryCode)
            .HasMaxLength(2);

        builder.Property(x => x.Notes)
            .HasMaxLength(2000);

        builder.HasIndex(x => x.TravelPlanId);

        builder.HasIndex(x => new
        {
            x.TravelPlanId,
            x.SortOrder
        });
    }
}
