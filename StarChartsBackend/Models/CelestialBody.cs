namespace StarChartsBackend.Models;

public class CelestialBody
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Age { get; set; }
    public double Diameter { get; set; }
    public double Mass { get; set; }
    
    public virtual PlanetarySystem? System { get; set; }
    public virtual CelestialBodyType? BodyType { get; set; }
}