﻿using Entities.Abstract;

namespace Entities.Concrete;

public class Instructor : IEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public List<Course> Courses { get; set; }
}
