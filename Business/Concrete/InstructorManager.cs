using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class InstructorManager : IInstructorService
{
    IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void TAdd(Instructor entity)
    {
        _instructorDal.Add(entity);
    }

    public void TDelete(Instructor entity)
    {
        _instructorDal.Delete(entity);
    }

    public Instructor TGet(int id)
    {
        return _instructorDal.Get(id);
    }

    public List<Instructor> TGetAll()
    {
        return _instructorDal.GetAll();
    }

    public void TUpdate(Instructor entity)
    {
        _instructorDal.Update(entity);
    }
}
