using DataAccess.Abstracts;
using Entities.Concrete;

namespace DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> _courses;
    public CourseDal()
    {
        Course course1 = new Course 
        {
            Id = 1,
            CategoryId = 1,
            InstructorId = 1,
            Name = "C#", 
            Description = "C# Software Developer Bootcamp",
            Price = 0,
            ImageUrl = "csharp.jpg"
        };

        Course course2 = new Course
        {
            Id = 2,
            CategoryId = 1,
            InstructorId = 1,
            Name = "Java",
            Description = "Java Software Developer Bootcamp",
            Price = 0,
            ImageUrl = "java.jpg"
        };

        _courses = new List<Course> { course1, course2 };
    }
    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Delete(Course course)
    {
        var courseToDelete = _courses.FirstOrDefault(c => c.Id == course.Id);

        if (courseToDelete != null)
        {
            _courses.Remove(courseToDelete);
        }
    }

    public List<Course> GetAll()
    {
        return _courses;
    }

    public Course? GetById(int courseId)
    {
        return _courses.FirstOrDefault(c => c.Id == courseId);
    }

    public void Update(Course course)
    {
        var courseToUpdate = _courses.FirstOrDefault(c => c.Id == course.Id);

        if (courseToUpdate != null)
        {
            courseToUpdate.CategoryId = course.CategoryId;
            courseToUpdate.InstructorId = course.InstructorId;
            courseToUpdate.Name = course.Name;
            courseToUpdate.Description = course.Description;
            courseToUpdate.Price = course.Price;
            courseToUpdate.ImageUrl = course.ImageUrl;
        }
    }
}
