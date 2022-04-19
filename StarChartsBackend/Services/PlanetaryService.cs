using StarChartsBackend.DAL.Repositories;
using StarChartsBackend.Models;
using StarChartsBackend.Models.Base;

namespace StarChartsBackend.Services;

public class PlanetaryService : IPlanetaryService
{
    private IBaseRepository<PlanetarySystem> System { get; set; }
    private IBaseRepository<CelestialBody> Body { get; set; }
    private IBaseRepository<CelestialBodyType> BodyType { get; set; }

    public void AppendStellarCentre()
    {
        System.GetAll().ToList();
    }
}