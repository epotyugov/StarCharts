using StarChartsBackend.Models;

namespace StarChartsBackend.DAL;

public class PlanetaryInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<PlanetaryContext>
{
    protected override void Seed(PlanetaryContext context)
    {
        List<CelestialBody> celestialBodies = new ()
        {
            new CelestialBody { Id = 0, Name = "Земля", Age = 4543000000, Diameter = 12472, Mass = 9001},
            new CelestialBody { Id = 1, Name = "Меркурий", Age = 4503000000, Diameter = 12472, Mass = 9001},
            new CelestialBody { Id = 2, Name = "Венера", Age = 4503000000, Diameter = 12472, Mass = 9001},
            new CelestialBody { Id = 3, Name = "Марс", Age = 4603000000, Diameter = 12472, Mass = 9001},
            new CelestialBody { Id = 4, Name = "Юпитер", Age = 4603000000, Diameter = 12472, Mass = 9001},
            new CelestialBody { Id = 5, Name = "Сатурн", Age = 4503000000, Diameter = 12472, Mass = 9001},
        };
        celestialBodies.ForEach(cb => context.CelestialBodies.Add(cb));
        context.SaveChanges();

        List<CelestialBodyType> celestialBodyTypes = new ()
        {
            new CelestialBodyType { Id  = 0, Name = "Планета", Category = CelestialBodyType.OrbitalCategory },
            new CelestialBodyType { Id  = 1, Name = "Газовый гигант", Category = CelestialBodyType.OrbitalCategory },
            new CelestialBodyType { Id  = 2, Name = "Комета", Category = CelestialBodyType.OrbitalCategory },
            new CelestialBodyType { Id  = 3, Name = "Звезда",  Category = CelestialBodyType.StellarCategory },
            new CelestialBodyType { Id  = 4, Name = "Чёрная дыра", Category = CelestialBodyType.StellarCategory },
        };
        celestialBodyTypes.ForEach(cbt => context.CelestialBodyTypes.Add(cbt));
        context.SaveChanges();

        List<PlanetarySystem> planetarySystems = new ()
        {
            new PlanetarySystem{ Id = 0, Name = "Солнечная система", Age = 4571000000},
            new PlanetarySystem{ Id = 1, Name = "Альфа Центавра", Age = 4853000000},
        };
        planetarySystems.ForEach(ps => context.PlanetarySystems.Add(ps));
        context.SaveChanges(); //возможно хватит объявить только один раз
    }
}