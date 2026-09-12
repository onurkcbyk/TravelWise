namespace TravelWise.Domain.Entities;

public class TravelPlan : BaseAuditableEntity
{
    public string UserId { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string? Notes { get; set; }

    public decimal? BudgetAmount { get; set; }

    public string? BudgetCurrencyCode { get; set; }

    public ICollection<TravelPlanPlace> Places { get; set; } = new List<TravelPlanPlace>();
}
