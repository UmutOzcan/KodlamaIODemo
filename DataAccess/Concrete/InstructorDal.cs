using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class InstructorDal : IInstructorDal
{
    private List<Instructor> _instructors = new();

    public InstructorDal()
    {
        _instructors.Add(new Instructor { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Image = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:30,height:30/https://www.filepicker.io/api/file/GsqiGFGCRmuBuel0qqF3", Description = "" });
        _instructors.Add(new Instructor { Id = 2, FirstName = "Halit Enes", LastName = "Kalaycı", Image = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:30,height:30/https://cdn.filestackcontent.com/XwoZsQ1LTaOU9ke59grx", Description = "" });
    }
    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
        _instructors.Remove(instructor);
    }

    public Instructor Get(int id)
    {
        var ins = _instructors.FirstOrDefault(c => c.Id == id);
        return ins;
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public void Update(Instructor instructor)
    {
        var ins = _instructors.FirstOrDefault(c => c.Id == instructor.Id);
        ins.FirstName = instructor.FirstName;
        ins.LastName = instructor.LastName;
        ins.Image = instructor.Image;
        ins.Description = instructor.Description;
    }
}
