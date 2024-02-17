using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CourseManager : ICourseService
{
    ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void TAdd(Course entity)
    {
        _courseDal.Add(entity);
    }

    public void TDelete(Course entity)
    {
        _courseDal.Delete(entity);
    }

    public Course TGet(int id)
    {
        return _courseDal.Get(id);
    }

    public List<Course> TGetAll()
    {
        return _courseDal.GetAll();
    }

    public void TUpdate(Course entity)
    {
        _courseDal.Update(entity);
    }
}
