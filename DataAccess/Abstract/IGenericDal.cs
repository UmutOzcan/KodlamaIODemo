namespace DataAccess.Abstract;

public interface IGenericDal<T>
{
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    List<T> GetAll();
    T Get(int id);
}