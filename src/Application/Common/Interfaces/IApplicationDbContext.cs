using Microsoft.EntityFrameworkCore;
using TravelWise.Domain.Entities;

namespace TravelWise.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TravelPlan> TravelPlans { get; }

    DbSet<TravelPlanPlace> TravelPlanPlaces { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
