using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using StarChartsBackend.Models;

namespace StarChartsBackend.DAL;

public class PlanetaryContext : DbContext
{
    public PlanetaryContext() : base(nameOrConnectionString: "Default")
    {
    }
    
    public DbSet<CelestialBody> CelestialBodies { get; set; }
    public DbSet<CelestialBodyType> CelestialBodyTypes { get; set; }
    public DbSet<PlanetarySystem> PlanetarySystems { get; set; }
}