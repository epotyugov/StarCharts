using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StarChartsBackend.Models.Base;

namespace StarChartsBackend.Models;

public class PlanetarySystem : BaseModel
{
    public string Name { get; set; }
    public double Age { get; set; }

    public int CelestialBodyId { get; set; }
    public virtual CelestialBody? CentralBody { get; set; }
    
    public int CelestialBodyTypeId { get; set; }
    public virtual CelestialBodyType? CentralBodyType { get; set; }
    
    public virtual ICollection<CelestialBody>? SystemBodies { get; set; }
}