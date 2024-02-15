﻿using Entities.Abstract;

namespace Entities.Concrete;

public class Course : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public byte CompletionRate { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public int InstructorId { get; set; }
    public Instructor Instructor { get; set; }
}