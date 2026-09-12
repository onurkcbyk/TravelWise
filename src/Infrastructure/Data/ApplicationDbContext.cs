using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelWise.Application.Common.Interfaces;
using TravelWise.Domain.Entities;
using TravelWise.Infrastructure.Identity;

namespace TravelWise.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<TravelPlan> TravelPlans => Set<TravelPlan>();

    public DbSet<TravelPlanPlace> TravelPlanPlaces => Set<TravelPlanPlace>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
