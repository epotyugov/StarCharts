using System.ComponentModel.DataAnnotations.Schema;
using StarChartsBackend.Models.Base;

namespace StarChartsBackend.Models;

public class CelestialBodyType : BaseModel
{
    public const string StellarCategory = "stellar";
    public const string OrbitalCategory = "orbital";
    
    public string Name { get; set; }
    public string Category { get; set; }
}