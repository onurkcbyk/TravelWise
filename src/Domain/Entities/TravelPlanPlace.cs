namespace TravelWise.Domain.Entities;

public class TravelPlanPlace : BaseAuditableEntity
{
    public int TravelPlanId { get; set; }

    public string SourceProvider { get; set; } = string.Empty;

    public string ExternalPlaceId { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string? City { get; set; }

    public string? CountryCode { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public DateOnly? PlannedDate { get; set; }

    public int SortOrder { get; set; }

    public string? Notes { get; set; }

    public TravelPlan TravelPlan { get; set; } = null!;
}
