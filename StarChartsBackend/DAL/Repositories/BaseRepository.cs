using System.Data.Entity.Migrations;
using StarChartsBackend.Models.Base;

namespace StarChartsBackend.DAL.Repositories;

public class BaseRepository<Model> : IBaseRepository<Model> where Model : BaseModel
{
    private PlanetaryContext Context { get; set; }
    public BaseRepository(PlanetaryContext context)
    {
        Context = context;
    }

    public List<Model> GetAll()
    {
        return Context.Set<Model>().ToList();
    }

    public Model GetById(Guid id)
    {
        return Context.Set<Model>().FirstOrDefault(model => model.Id == id);
    }

    public Model Create(Model model)
    {
        Context.Set<Model>().Add(model);
        Context.SaveChanges();
        
        return model;
    }

    public Model Update(Model model)
    {
        Model modelForUpdating = Context.Set<Model>().FirstOrDefault(elem => elem.Id == model.Id);
        /*
         зачем, а главное зачем? глянь другие примеры репозиториев
         if (modelForUpdating != null)
        {
            modelForUpdating = model;
        }
        */

        Context.Set<Model>().AddOrUpdate(model);
        Context.SaveChanges();
        return modelForUpdating;
    }

    public void Delete(Guid id)
    {
        Model modelForDeletion = Context.Set<Model>().FirstOrDefault(model => model.Id == id);
        Context.Set<Model>().Remove(modelForDeletion);
        Context.SaveChanges();
    }
}