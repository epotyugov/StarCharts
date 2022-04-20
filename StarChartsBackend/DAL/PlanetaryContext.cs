using Microsoft.EntityFrameworkCore;
using StarChartsBackend.Models;

namespace StarChartsBackend.DAL;

public class PlanetaryContext : DbContext
{
    public PlanetaryContext(DbContextOptions<PlanetaryContext> options) : base(options)
    {
    }
    
    public DbSet<CelestialBody> CelestialBodies { get; set; }
    public DbSet<CelestialBodyType> CelestialBodyTypes { get; set; }
    public DbSet<PlanetarySystem> PlanetarySystems { get; set; }
}