using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarChartsBackend.Models;

public class PlanetarySystem
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public double Age { get; set; }

    public int CeestialBodyId { get; set; }
    public virtual CelestialBody? CentralBody { get; set; }
    
    public int CelestialBodyTypeId { get; set; }
    public virtual CelestialBodyType? CentralBodyType { get; set; }
    
    public virtual ICollection<CelestialBody>? SystemBodies { get; set; }
}