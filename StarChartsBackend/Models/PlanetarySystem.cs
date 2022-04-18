namespace StarChartsBackend.Models;

public class PlanetarySystem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual CelestialBody CentralBody { get; set; }
    public virtual CelestialBodyType CentralBodyType { get; set; }
    
    public virtual ICollection<CelestialBody> SystemBodies { get; set; }
}