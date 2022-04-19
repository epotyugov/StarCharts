using StarChartsBackend.Models;

namespace StarChartsBackend.DAL;

public class PlanetaryInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<PlanetaryContext>
{
    protected override void Seed(PlanetaryContext context)
    {
        List<CelestialBody> celestialBodies = new ()
        {
            new CelestialBody { Name = "Земля", Age = 4543000000, Diameter = 12472, Mass = 9001},
            new CelestialBody { Name = "Меркурий", Age = 4503000000, Diameter = 12472, Mass = 9001},
            new CelestialBody { Name = "Венера", Age = 4503000000, Diameter = 12472, Mass = 9001},
            new CelestialBody { Name = "Марс", Age = 4603000000, Diameter = 12472, Mass = 9001},
            new CelestialBody { Name = "Юпитер", Age = 4603000000, Diameter = 12472, Mass = 9001},
            new CelestialBody { Name = "Сатурн", Age = 4503000000, Diameter = 12472, Mass = 9001},
        };
        celestialBodies.ForEach(cb => context.CelestialBodies.Add(cb));
        context.SaveChanges();

        List<CelestialBodyType> celestialBodyTypes = new ()
        {
            new CelestialBodyType { Name = "Планета", Category = CelestialBodyType.OrbitalCategory },
            new CelestialBodyType { Name = "Газовый гигант", Category = CelestialBodyType.OrbitalCategory },
            new CelestialBodyType { Name = "Комета", Category = CelestialBodyType.OrbitalCategory },
            new CelestialBodyType { Name = "Звезда",  Category = CelestialBodyType.StellarCategory },
            new CelestialBodyType { Name = "Чёрная дыра", Category = CelestialBodyType.StellarCategory },
        };
        celestialBodyTypes.ForEach(cbt => context.CelestialBodyTypes.Add(cbt));
        context.SaveChanges();

        List<PlanetarySystem> planetarySystems = new ()
        {
            new PlanetarySystem{ Name = "Солнечная система", Age = 4571000000},
            new PlanetarySystem{ Name = "Альфа Центавра", Age = 4853000000},
        };
        planetarySystems.ForEach(ps => context.PlanetarySystems.Add(ps));
        context.SaveChanges(); //возможно хватит объявить только один раз
    }
}