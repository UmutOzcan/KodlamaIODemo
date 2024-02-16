using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class CourseDal : ICourseDal
{
    private List<Course> _courses = new();

    public CourseDal()
    {
        _courses.Add(new Course { Id = 1, CategoryId = 2, InstructorId = 1, Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)", Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", Image = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/We86Zc3xQy6FUqhyBJJc", CompletionRate=73 });
        _courses.Add(new Course { Id = 2, CategoryId = 2, InstructorId = 2, Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)", Description = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", Image = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/3nqAGqHARL6uEULbaQvr", CompletionRate = 10 });
        _courses.Add(new Course { Id = 3, CategoryId = 2, InstructorId = 1, Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)", Description = "1,5 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.", Image = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://www.filepicker.io/api/file/Cs7lHNsJSCi1mkPzo8fT", CompletionRate = 100 });
    }

    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Delete(Course course)
    {
        _courses.Remove(course);
    }

    public Course Get(int id)
    {
        var cou = _courses.FirstOrDefault(c => c.Id == id);
        return cou;
    }

    public List<Course> GetAll()
    {
        return _courses;
    }

    public void Update(Course course)
    {
        var cou = _courses.FirstOrDefault(c => c.Id == course.Id);
        if (cou != null)
        {
            cou.Name = course.Name;
            cou.Description = course.Description;
            cou.Image = course.Image;
            cou.CategoryId = course.CategoryId;
            cou.InstructorId = course.InstructorId;
            cou.CompletionRate = course.CompletionRate;
        }
    }
}
