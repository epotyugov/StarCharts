using StarChartsBackend.Models;

namespace StarChartsBackend.DAL;

public class PlanetaryInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<PlanetaryContext>
{
    protected override void Seed(PlanetaryContext context)
    {
        List<CelestialBodyType> bodyTypes = new ()
        {
            new CelestialBodyType { Name = "Планета", Category = CelestialBodyType.OrbitalCategory },
            new CelestialBodyType { Name = "Газовый гигант", Category = CelestialBodyType.OrbitalCategory },
            new CelestialBodyType { Name = "Комета", Category = CelestialBodyType.OrbitalCategory },
            new CelestialBodyType { Name = "Звезда",  Category = CelestialBodyType.StellarCategory },
            new CelestialBodyType { Name = "Чёрная дыра", Category = CelestialBodyType.StellarCategory },
        };
        bodyTypes.ForEach(cbt => context.CelestialBodyTypes.Add(cbt));
        context.SaveChanges();

        int StarTypeId = bodyTypes.FirstOrDefault(i => i.Name == "Звезда").Id;
        int PlanetTypeId = bodyTypes.FirstOrDefault(i => i.Name == "Планета").Id;
        int GasGiantTypeId = bodyTypes.FirstOrDefault(i => i.Name == "Газовый гигант").Id;
        List<CelestialBody> celestialBodies = new ()
        {
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
        celestialBodies.ForEach(cb => context.CelestialBodies.Add(cb));
        context.SaveChanges();

        CelestialBody Sun = celestialBodies.FirstOrDefault(i => i.Name == "Солнце");
        List<PlanetarySystem> planetarySystems = new ()
        {
            new PlanetarySystem {
                Name = "Солнечная система",
                Age = 4571000000,
                CentralBody = Sun,
                SystemBodies = new List<CelestialBody>
                {
                    //накидать
                },
            },
            new PlanetarySystem {
                Name = "Альфа Центавра",
                Age = 4853000000,
                CentralBody = Sun,
                SystemBodies = new List<CelestialBody>
                {
                    //накидать
                }
            },
        };
        planetarySystems.ForEach(ps => context.PlanetarySystems.Add(ps));
        context.SaveChanges(); //возможно хватит объявить только один раз
    }
}