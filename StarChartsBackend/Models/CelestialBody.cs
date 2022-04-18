namespace StarChartsBackend.Models;

public class CelestialBody
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Diameter { get; set; }
    public int Mass { get; set; }
    
    public virtual PlanetarySystem System { get; set; }
    public virtual CelestialBodyType BodyType { get; set; }
}