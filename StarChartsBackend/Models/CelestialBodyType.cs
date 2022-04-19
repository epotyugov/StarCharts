using System.ComponentModel.DataAnnotations.Schema;

namespace StarChartsBackend.Models;

public class CelestialBodyType
{
    public const string StellarCategory = "stellar";
    public const string OrbitalCategory = "orbital";
    
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
}