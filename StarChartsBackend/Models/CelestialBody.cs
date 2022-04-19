using System.ComponentModel.DataAnnotations.Schema;
using StarChartsBackend.Models.Base;

namespace StarChartsBackend.Models;

public class CelestialBody : BaseModel
{
    public string Name { get; set; }
    public double Age { get; set; }
    public double Diameter { get; set; }
    public double Mass { get; set; }
    
    public int PlanetarySystemId { get; set; }
    public virtual PlanetarySystem? System { get; set; }
    
    public int CelestialBodyTypeId { get; set; }
    public virtual CelestialBodyType? BodyType { get; set; }
}