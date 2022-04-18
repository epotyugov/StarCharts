namespace StarChartsBackend.Models;

public class CelestialBodyType
{
    public const string StellarCategory = "stellar";
    public const string OrbitalCategory = "orbital";
    
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
}