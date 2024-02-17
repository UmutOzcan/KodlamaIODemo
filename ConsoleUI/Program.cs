using Business.Concrete;
using DataAccess.Concrete;

CategoryManager categoryManager = new CategoryManager(new CategoryDal());
CourseManager courseManager = new CourseManager(new CourseDal());
InstructorManager instructorManager = new InstructorManager(new InstructorDal());

foreach (var category in categoryManager.TGetAll())
{
    Console.WriteLine(category.Id + " - " + category.Name);
}
Console.WriteLine();

foreach (var course in courseManager.TGetAll())
{
    Console.WriteLine(course.Id + " - " + course.Name + " - " + course.Description.ToString()[..10] + "... - %" + course.CompletionRate);
}
Console.WriteLine();

foreach (var instructor in instructorManager.TGetAll())
{
    Console.WriteLine(instructor.Id + " - " + instructor.FirstName + " " + instructor.LastName);
}



Console.ReadKey();