using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void TAdd(Category entity)
    {
        _categoryDal.Add(entity);
    }

    public void TDelete(Category entity)
    {
        _categoryDal.Delete(entity);
    }

    public Category TGet(int id)
    {
        return _categoryDal.Get(id);
    }

    public List<Category> TGetAll()
    {
        return _categoryDal.GetAll();
    }

    public void TUpdate(Category entity)
    {
        _categoryDal.Update(entity);
    }
}
