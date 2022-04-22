using Microsoft.AspNetCore.Mvc;
using StarChartsBackend.DAL.Repositories;
using StarChartsBackend.Models;

namespace StarChartsBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class PlanetarySystemController : ControllerBase
{
    private IBaseRepository<CelestialBody> Bodies { get; set; }

    public PlanetarySystemController(IBaseRepository<CelestialBody> bodies)
    {
        Bodies = bodies;
    }

    private static int StarTypeId = 0;
    private static int PlanetTypeId = 1;
    private static int GasGiantTypeId = 3;
    
    List<CelestialBody> celestialBodies = new ()
    {
        new CelestialBody(),
        new CelestialBody {
            Name = "Солнце",
            Age = 4543000000,
            Diameter = 12472,
            Mass = 9001,
            CelestialBodyTypeId = StarTypeId,
        },
        new CelestialBody {
            Name = "Земля",
            Age = 4543000000,
            Diameter = 12472,
            Mass = 9001,
            CelestialBodyTypeId = PlanetTypeId,
        },
        new CelestialBody {
            Name = "Меркурий",
            Age = 4503000000,
            Diameter = 12472,
            Mass = 9001,
            CelestialBodyTypeId = PlanetTypeId,
        },
        new CelestialBody {
            Name = "Венера",
            Age = 4503000000,
            Diameter = 12472,
            Mass = 9001,
            CelestialBodyTypeId = PlanetTypeId,
        },
        new CelestialBody {
            Name = "Марс",
            Age = 4603000000,
            Diameter = 12472,
            Mass = 9001,
            CelestialBodyTypeId = PlanetTypeId,
        },
        new CelestialBody {
            Name = "Юпитер",
            Age = 4603000000,
            Diameter = 12472,
            Mass = 9001,
            CelestialBodyTypeId = GasGiantTypeId,
        },
        new CelestialBody {
            Name = "Сатурн",
            Age = 4503000000,
            Diameter = 12472,
            Mass = 9001,
            CelestialBodyTypeId = GasGiantTypeId,
        },
    };
        
    [HttpGet(Name = "GetPlanetarySystem")]
    public IEnumerable<CelestialBody> Get()
    {
        return Enumerable.Range(1, 7).Select(index => celestialBodies[index]).ToArray();
    }
}