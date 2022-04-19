namespace StarChartsBackend.DAL.Repositories;

public interface IBaseRepository<T>
{
    public List<T> GetAll();
    public T GetById(int id);
    public T Create(T model);
    public T Update(T model);
    public void Delete(int id);
}