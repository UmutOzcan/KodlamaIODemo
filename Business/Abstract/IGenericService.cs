﻿namespace Business.Abstract;

public interface IGenericService<T>
{
    void TAdd(T entity);
    void TDelete(T entity);
    void TUpdate(T entity);
    List<T> TGetAll();
    T TGet(int id);
}
