using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class CategoryDal : ICategoryDal
{
    private List<Category> _categories = new();

    public CategoryDal()
    {
        _categories.Add(new Category { Id = 1, Name = "Tümü" });
        _categories.Add(new Category { Id = 2, Name = "Programlama" });
    }

    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Delete(Category category)
    {
        _categories.Remove(category);
    }

    public Category Get(int id)
    {
        var cat = _categories.FirstOrDefault(c => c.Id == id);
        return cat;
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public void Update(Category category)
    {
        var cat = _categories.FirstOrDefault(c => c.Id == category.Id);
        if (cat != null) cat.Name = category.Name;
    }
}
