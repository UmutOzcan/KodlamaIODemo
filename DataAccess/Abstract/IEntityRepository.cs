namespace DataAccess.Abstract;

public interface IEntityRepository<T>
{
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    List<T> GetAll();
    T Get(int id);
}