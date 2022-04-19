using System.Data.Entity.Migrations;
using StarChartsBackend.Models.Base;

namespace StarChartsBackend.DAL.Repositories;

public class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : BaseModel
{
    private PlanetaryContext Context { get; set; }
    public BaseRepository(PlanetaryContext context)
    {
        Context = context;
    }

    public List<TModel> GetAll()
    {
        return Context.Set<TModel>().ToList();
    }

    public TModel GetById(int id)
    {
        return Context.Set<TModel>().FirstOrDefault(model => model.Id == id);
    }

    public TModel Create(TModel model)
    {
        Context.Set<TModel>().Add(model);
        Context.SaveChanges();
        
        return model;
    }

    public TModel Update(TModel model)
    {
        TModel modelForUpdating = Context.Set<TModel>().FirstOrDefault(elem => elem.Id == model.Id);
        /*
         зачем, а главное зачем? глянь другие примеры репозиториев
         if (modelForUpdating != null)
        {
            modelForUpdating = model;
        }
        */

        Context.Set<TModel>().AddOrUpdate(model);
        Context.SaveChanges();
        return modelForUpdating;
    }

    public void Delete(int id)
    {
        TModel modelForDeletion = Context.Set<TModel>().FirstOrDefault(model => model.Id == id);
        Context.Set<TModel>().Remove(modelForDeletion);
        Context.SaveChanges();
    }
}